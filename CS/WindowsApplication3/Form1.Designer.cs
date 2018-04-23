namespace DXSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new DXSample.DataSet1();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.exportButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.exportProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.exportGridControl = new DevExpress.XtraGrid.GridControl();
            this.exportGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportProgressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "CustomerInfo";
            this.customerInfoBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.exportButton);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.exportProgressBar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 423);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(519, 60);
            this.panelControl1.TabIndex = 0;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(5, 6);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(87, 48);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.Click += new System.EventHandler(this.OnExportGrid);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(98, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Export Progress";
            // 
            // exportProgressBar
            // 
            this.exportProgressBar.Location = new System.Drawing.Point(193, 29);
            this.exportProgressBar.Name = "exportProgressBar";
            this.exportProgressBar.Size = new System.Drawing.Size(314, 26);
            this.exportProgressBar.TabIndex = 0;
            // 
            // exportGridControl
            // 
            this.exportGridControl.DataSource = this.customerInfoBindingSource;
            this.exportGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportGridControl.Location = new System.Drawing.Point(0, 0);
            this.exportGridControl.MainView = this.exportGridView;
            this.exportGridControl.Name = "exportGridControl";
            this.exportGridControl.Size = new System.Drawing.Size(519, 423);
            this.exportGridControl.TabIndex = 1;
            this.exportGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.exportGridView});
            // 
            // exportGridView
            // 
            this.exportGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colFirstName,
            this.colLastName,
            this.colDate,
            this.colCheck});
            this.exportGridView.GridControl = this.exportGridControl;
            this.exportGridView.Name = "exportGridView";
            this.exportGridView.OptionsView.ShowGroupPanel = false;
            this.exportGridView.AfterPrintRow += new DevExpress.XtraGrid.Views.Base.AfterPrintRowEventHandler(this.OnAfterPrintRow);
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            // 
            // colCheck
            // 
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 483);
            this.Controls.Add(this.exportGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "How to show a progress bar during exporting";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportProgressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private DataSet1 dataSet11;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ProgressBarControl exportProgressBar;
        private DevExpress.XtraGrid.GridControl exportGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView exportGridView;
        private DevExpress.XtraEditors.SimpleButton exportButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
    }
}

