Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports DevExpress.Data
Imports DevExpress.Xpf.Grid

Namespace DXGridTest

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As New List(Of TestData)()
			For i As Integer = 0 To 9
				list.Add(New TestData() With {.Text = "Row" & i, .Number = i})
			Next i

			grid.DataSource = list
		End Sub
	End Class

	Public Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateNumber As Integer
		Public Property Number() As Integer
			Get
				Return privateNumber
			End Get
			Set(ByVal value As Integer)
				privateNumber = value
			End Set
		End Property
	End Class

	Public Class MyTableView
		Inherits TableView
		Protected Overrides Sub OnColumnHeaderClick(ByVal column As GridColumn, ByVal isShift As Boolean, _
		ByVal isCtrl As Boolean)
			MyBase.OnColumnHeaderClick(column, isShift, _
				column.SortOrder = ColumnSortOrder.Descending)
		End Sub
	End Class
End Namespace
