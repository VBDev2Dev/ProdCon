Imports System.Collections.Concurrent
Imports ProdCon

Public MustInherit Class Consumer(Of T As {WorkItem(Of dataT, ResultT)}, ResultT As {Class, IWorkInfo}, dataT As Class)
    Implements IConsumerInfo

    Private Notify As Action(Of NotifyConsumeInfo(Of ResultT))
    Public Sub New(ByVal queue As ConcurrentQueue(Of T), Name As String, Notify As Action(Of NotifyConsumeInfo(Of ResultT)))
        Me.Queue = queue
        Me.Notify = Notify
        Me.Name = Name
    End Sub
    Protected MustOverride Async Function ProcessItemAsync(Item As T) As Task(Of ResultT)
    Protected _results As New List(Of ResultT)
    Protected Queue As ConcurrentQueue(Of T)

    ReadOnly Property Results As ResultT()
        Get
            Return _results.ToArray()
        End Get
    End Property

    Public Property Name As String Implements IConsumerInfo.Name


    Public ReadOnly Property Working As Boolean Implements IConsumerInfo.Working
        Get
            Return _working
        End Get
    End Property

    Public ReadOnly Property TotalTime As TimeSpan Implements IConsumerInfo.TotalTime
        Get
            Return TimeSpan.FromTicks(Results.Sum(Function(r) r.HowLong.Ticks))
        End Get
    End Property

    Private _working As Boolean


    Async Function Consume() As Task(Of ResultT())
        If _working Then Throw New InvalidOperationException("Consume can only be called when the consumer is not working.")
        _working = True

        Await Task.Run(Async Function()

                           While Not Queue.IsEmpty
                               Dim itm As T = Nothing
                               If Queue.TryDequeue(itm) Then
                                   Dim res = Await ProcessItemAsync(itm)
                                   _results.Add(res)

                                   If Notify IsNot Nothing Then Notify(
                                   New NotifyConsumeInfo(Of ResultT)(res, _results.Count, Me))


                               End If
                           End While

                       End Function)

        _working = False
        Return Results
    End Function

End Class
