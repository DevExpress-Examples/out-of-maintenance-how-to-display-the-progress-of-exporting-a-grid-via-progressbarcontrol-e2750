Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Diagnostics


Namespace DXSample
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub InitData()
			For i As Integer = 0 To 2999
				dataSet11.Tables(0).Rows.Add(New Object() { i, String.Format("FirstName {0}", i), String.Format("LastName {0}", i), DateTime.Today.AddDays(i), True })
			Next i
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()
			exportGridControl.ForceInitialize()
			exportProgressBar.Properties.ShowTitle = True
			exportProgressBar.Properties.PercentView = True
			exportProgressBar.Properties.Maximum = exportGridView.RowCount * exportProgressBar.Properties.Step
		End Sub

		Private filePath As String = "..\\..Excel.xlsx"
		Private Sub OnExportGrid(ByVal sender As Object, ByVal e As EventArgs) Handles exportButton.Click
			exportGridView.ExportToXlsx(filePath)
			Using pr As New Process()
				pr.StartInfo = New ProcessStartInfo(filePath)
				pr.Start()
			End Using
			exportProgressBar.Position = 0
		End Sub

		Private Sub OnAfterPrintRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Printing.PrintRowEventArgs) Handles exportGridView.AfterPrintRow
			Application.DoEvents()
			exportProgressBar.PerformStep()
			exportProgressBar.Update()
		End Sub
	End Class
End Namespace
