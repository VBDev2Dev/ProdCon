Imports System.ComponentModel

Public MustInherit Class WorkItem(Of DataT, ResultT As {Class, IWorkInfo})
    Implements INotifyPropertyChanged


    Private _working As Boolean = False
    ReadOnly Property Working As Boolean
        Get
            Return _working
        End Get
    End Property
    Public Sub New(Data As DataT)
        Me.Data = Data

    End Sub
    ReadOnly Property Data As DataT
    MustOverride Property Work As Func(Of DataT, ResultT)
    Private _result As ResultT
    Property Result As ResultT
        Get

            If _result Is Nothing AndAlso Not _working Then Start()
            Return _result
        End Get
        Private Set(value As ResultT)
            _result = value
            OnNotifyPropertyChanged(New PropertyChangedEventArgs(NameOf(Result)))
        End Set
    End Property
    Private _ThreadID As Integer?
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Property ThreadID As Integer?
        Get
            Return _ThreadID
        End Get
        Private Set(value As Integer?)
            _ThreadID = value
        End Set
    End Property
    Public Sub Start(Optional Redo As Boolean = False)
        If Not Redo AndAlso _working Then Return
        _working = True
        _ThreadID = Threading.Thread.CurrentThread.ManagedThreadId
        Result = Work(Data)
        _working = False
    End Sub

    Overridable Sub OnNotifyPropertyChanged(e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub



End Class
