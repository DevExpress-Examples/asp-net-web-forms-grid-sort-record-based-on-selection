Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub ASPxGridView1_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.Web.CustomColumnSortEventArgs)
		Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
		Dim isRow1Selected As Boolean = grid.Selection.IsRowSelectedByKey(e.GetRow1Value(grid.KeyFieldName))
		Dim isRow2Selected As Boolean = grid.Selection.IsRowSelectedByKey(e.GetRow2Value(grid.KeyFieldName))
		e.Handled = isRow1Selected <> isRow2Selected
		If e.Handled Then
			If e.SortOrder = DevExpress.Data.ColumnSortOrder.Descending Then
				If isRow1Selected Then
					e.Result = 1
				Else
					e.Result = -1
				End If
			Else
				If isRow1Selected Then
					e.Result = -1
				Else
					e.Result = 1
				End If
			End If
		End If
	End Sub
End Class