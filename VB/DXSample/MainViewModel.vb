' Developer Express Code Central Example:
' How to navigate through views by using NavBarControl control and NavigationFrame class
' 
' This example demonstrates how to implement navigation between views by using the
' NavBarControl control and NavigationFrame class.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5129

Imports DevExpress.Mvvm
Imports DXSample.ViewModel
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace DXSample
	Public Class MainViewModel
		Inherits ViewModelBase

		Public Property Items() As ObservableCollection(Of UserControlViewModel)


		Private _SelectedViewModel As UserControlViewModel
		Public Property SelectedViewModel() As UserControlViewModel
			Get
				Return _SelectedViewModel
			End Get
			Set(ByVal value As UserControlViewModel)
				SetProperty(_SelectedViewModel, value, Function() SelectedViewModel)
				ServiceContainer.GetService(Of INavigationService)().Navigate(SelectedViewModel.ViewName, Nothing, Me)
			End Set
		End Property

		Public Sub New()
			Items = New ObservableCollection(Of UserControlViewModel)() From {
				New UserControlViewModel() With {.ViewName = "UserControl1"},
				New UserControlViewModel() With {.ViewName = "UserControl2"},
				New UserControlViewModel() With {.ViewName = "UserControl3"},
				New UserControlViewModel() With {.ViewName = "HomeView"}
			}

		End Sub
	End Class
End Namespace
