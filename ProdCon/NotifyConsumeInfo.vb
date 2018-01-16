Public Class NotifyConsumeInfo(Of T)

    Public Sub New(Result As T, Count As Integer, Consumer As IConsumerInfo)
        Me.Result = Result
        ProcessedCount = Count
        Me.Consumer = Consumer
    End Sub


    ReadOnly Property Result As T

    ReadOnly Property ProcessedCount As Integer
    ReadOnly Property Consumer As IConsumerInfo


End Class
