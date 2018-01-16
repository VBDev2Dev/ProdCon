Imports System.Collections.Concurrent

Class MathWorkItemConsumer
    Inherits Consumer(Of MathWorkItem, MathResult, IEnumerable(Of Integer))
    Public Sub New(ByVal queue As ConcurrentQueue(Of MathWorkItem), ByVal Name As String, ByVal Notify As Action(Of NotifyConsumeInfo(Of MathResult)))
        MyBase.New(queue, Name, Notify)
    End Sub


    Protected Overrides Async Function ProcessItemAsync(Item As MathWorkItem) As Task(Of MathResult)
        Return Await Task.Run(Function()
                                  Return Item.Result
                              End Function)
    End Function
End Class