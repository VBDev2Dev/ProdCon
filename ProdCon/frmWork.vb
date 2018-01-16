Imports System.Collections.Concurrent
Imports ProdCon

Public Class frmWork
    Dim items As New ConcurrentQueue(Of MathWorkItem)
    Dim rnd As New Random

    WriteOnly Property AllowModifyCounts As Boolean
        Set(value As Boolean)
            nudCnsumers.Enabled = value
            nudWorkItems.Enabled = value
            btnStart.Enabled = value
            prgWorking.Visible = Not value
        End Set
    End Property
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        AllowModifyCounts = False

        Dim work = Enumerable.Range(0, nudWorkItems.Value).Select(Function(n) New MathWorkItem(
                                                                      Enumerable.Range(0, rnd.Next(2, 6)).
                                                                      Select(Function(n2) rnd.Next(0, 900)).ToArray)).ToArray
        Dim strt As Date = Now

        For Each w In work
            items.Enqueue(w)
        Next

        Dim cons = Enumerable.Range(1, nudCnsumers.Value).Select(Function(n) New MathWorkItemConsumer(items, n.ToString,
                                   Sub(info)
                                       Dim notifyWork As Action = Sub()
                                                                      'Console.WriteLine($"Total time for consumer({kvNotify.Key.Name}):{kvNotify.Key.TotalTime} Items Processed:{kvNotify.Value.ProcessedCount}")
                                                                      Dim pViews As ConsumerProcessingView() = ConsumerProcessingViewBindingSource.DataSource

                                                                      Dim pv = pViews.First(Function(p) p.Name = info.Consumer.Name)

                                                                      pv.Working = info.Consumer.Working
                                                                      pv.TotalTime = info.Consumer.TotalTime
                                                                      pv.ProcessedCount = info.ProcessedCount
                                                                      ConsumerProcessingViewBindingSource.ResetItem(ConsumerProcessingViewBindingSource.IndexOf(pv))

                                                                  End Sub
                                       If InvokeRequired Then
                                           Invoke(notifyWork)
                                       Else
                                           notifyWork()
                                       End If
                                   End Sub))


        Dim views = (From c In cons Select New ConsumerProcessingView(c.Name)).ToArray
        ConsumerProcessingViewBindingSource.DataSource = views

        Dim results = Await Task.WhenAll(cons.AsParallel.Select(Async Function(c) New With {Key .Consumer = c, .Results = Await c.Consume}).ToArray)
        Dim stopped As Date = Now
        For Each v In views
            v.Working = False
        Next
        ConsumerProcessingViewBindingSource.ResetBindings(False)
        Dim resultTimes = results.Select(Function(r) TimeSpan.FromTicks(r.Results.Sum(Function(mr) mr.HowLong.Ticks)))

        Dim status As String = $"All consumers spent  {New TimeSpan(resultTimes.Sum(Function(rt) rt.Ticks))}  processing {work.Count} items while the whole process took {stopped.Subtract(strt)}."

        Console.WriteLine(status)
        lblStatus.Text = status

        AllowModifyCounts = True

    End Sub

End Class