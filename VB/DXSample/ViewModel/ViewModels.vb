Imports DevExpress.Mvvm

Namespace DXSample.ViewModel

    Public Class UserControlViewModel
        Inherits ViewModelBase

        Private _ViewName As String

        Public Property ViewName As String
            Get
                Return _ViewName
            End Get

            Set(ByVal value As String)
                SetProperty(_ViewName, value, Function() ViewName)
            End Set
        End Property
    End Class
End Namespace
