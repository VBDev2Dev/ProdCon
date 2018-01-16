Imports ProdCon

Public Class ConsumerProcessingView


    Sub New(Name As String)
        Working = False
        Me.Name = Name
        TotalTime = TimeSpan.Zero
        ProcessedCount = 0
    End Sub
    Public Property Name As String
    Public Property Working As Boolean
    Public Property TotalTime As TimeSpan
    Public Property ProcessedCount As Integer

End Class
