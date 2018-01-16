Imports ProdCon

Public Class MathResult
    Implements IWorkInfo


    ReadOnly _value As Decimal

    Public Sub New(value As Decimal, data As IEnumerable(Of Integer), howLong As TimeSpan, threadID As Integer)
        _value = value
        Me.Data = data
        Me.HowLong = howLong
        Me.ThreadID = threadID
    End Sub

    ReadOnly Property Value As Decimal
        Get
            Return _value
        End Get
    End Property

    Public ReadOnly Property Data As IEnumerable(Of Integer)


    Public ReadOnly Property HowLong As TimeSpan Implements IWorkInfo.HowLong

    Public ReadOnly Property ThreadID As Integer Implements IWorkInfo.ThreadID

End Class
