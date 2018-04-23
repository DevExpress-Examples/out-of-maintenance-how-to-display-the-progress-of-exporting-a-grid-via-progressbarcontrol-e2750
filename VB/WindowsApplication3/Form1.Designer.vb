Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.customerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New DXSample.DataSet1()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.exportButton = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.exportProgressBar = New DevExpress.XtraEditors.ProgressBarControl()
			Me.exportGridControl = New DevExpress.XtraGrid.GridControl()
			Me.exportGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.exportProgressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.exportGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.exportGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customerInfoBindingSource
			' 
			Me.customerInfoBindingSource.DataMember = "CustomerInfo"
			Me.customerInfoBindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.exportButton)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.exportProgressBar)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 423)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(519, 60)
			Me.panelControl1.TabIndex = 0
			' 
			' exportButton
			' 
			Me.exportButton.Location = New System.Drawing.Point(5, 6)
			Me.exportButton.Name = "exportButton"
			Me.exportButton.Size = New System.Drawing.Size(87, 48)
			Me.exportButton.TabIndex = 2
			Me.exportButton.Text = "Export"
'			Me.exportButton.Click += New System.EventHandler(Me.OnExportGrid);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(98, 33)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(90, 16)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Export Progress"
			' 
			' exportProgressBar
			' 
			Me.exportProgressBar.Location = New System.Drawing.Point(193, 29)
			Me.exportProgressBar.Name = "exportProgressBar"
			Me.exportProgressBar.Size = New System.Drawing.Size(314, 26)
			Me.exportProgressBar.TabIndex = 0
			' 
			' exportGridControl
			' 
			Me.exportGridControl.DataSource = Me.customerInfoBindingSource
			Me.exportGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.exportGridControl.Location = New System.Drawing.Point(0, 0)
			Me.exportGridControl.MainView = Me.exportGridView
			Me.exportGridControl.Name = "exportGridControl"
			Me.exportGridControl.Size = New System.Drawing.Size(519, 423)
			Me.exportGridControl.TabIndex = 1
			Me.exportGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.exportGridView})
			' 
			' exportGridView
			' 
			Me.exportGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colFirstName, Me.colLastName, Me.colDate, Me.colCheck})
			Me.exportGridView.GridControl = Me.exportGridControl
			Me.exportGridView.Name = "exportGridView"
			Me.exportGridView.OptionsView.ShowGroupPanel = False
'			Me.exportGridView.AfterPrintRow += New DevExpress.XtraGrid.Views.Base.AfterPrintRowEventHandler(Me.OnAfterPrintRow);
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			' 
			' colDate
			' 
			Me.colDate.FieldName = "Date"
			Me.colDate.Name = "colDate"
			Me.colDate.Visible = True
			Me.colDate.VisibleIndex = 3
			' 
			' colCheck
			' 
			Me.colCheck.FieldName = "Check"
			Me.colCheck.Name = "colCheck"
			Me.colCheck.Visible = True
			Me.colCheck.VisibleIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(519, 483)
			Me.Controls.Add(Me.exportGridControl)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "How to show a progress bar during exporting"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.exportProgressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.exportGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.exportGridView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private customerInfoBindingSource As System.Windows.Forms.BindingSource
		Private dataSet11 As DataSet1
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private exportProgressBar As DevExpress.XtraEditors.ProgressBarControl
		Private exportGridControl As DevExpress.XtraGrid.GridControl
		Private WithEvents exportGridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents exportButton As DevExpress.XtraEditors.SimpleButton
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colCheck As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

