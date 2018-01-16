Imports ProdCon

Public Class MathWorkItem
    Inherits WorkItem(Of IEnumerable(Of Integer), MathResult)

    Public Sub New(ByVal Data As IEnumerable(Of Integer))
        MyBase.New(Data)
        _work = getWork()

    End Sub

    Private Function getWork() As Func(Of IEnumerable(Of Integer), MathResult)
        Static rand As New Random
        Dim index As Integer = rand.Next(0, 2)
        Dim res As Func(Of IEnumerable(Of Integer), MathResult) = Nothing
        Select Case index
            Case 0
                res = Function(d)
                          Dim sw As New Stopwatch
                          sw.Start()
                          Dim value As Decimal = d.Select(Function(n) CDec(n)).Sum
                          Threading.Thread.Sleep(rand.Next(500, 1301)) 'artificially make work take time
                          sw.Stop()
                          Return New MathResult(value, Data, sw.Elapsed, Threading.Thread.CurrentThread.ManagedThreadId)

                      End Function
            Case 1
                res = Function(d)
                          Dim sw As New Stopwatch
                          sw.Start()
                          Dim value As Decimal = d.Aggregate(1D, Function(c, n) c * n)
                          Threading.Thread.Sleep(rand.Next(500, 1301)) 'artificially make work take time
                          sw.Stop()
                          Return New MathResult(value, Data, sw.Elapsed, Threading.Thread.CurrentThread.ManagedThreadId)


                      End Function


        End Select
        Return res

    End Function
    Private _work As Func(Of IEnumerable(Of Integer), MathResult)
    Public Overrides Property Work As Func(Of IEnumerable(Of Integer), MathResult)
        Get

            Return _work
        End Get
        Set(value As Func(Of IEnumerable(Of Integer), MathResult))
            _work = value
        End Set
    End Property

End Class
