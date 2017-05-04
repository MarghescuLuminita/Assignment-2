namespace FurnitureManufacturer.View
{
    partial class ReportOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridReportOrder = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReportOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReportOrder
            // 
            this.gridReportOrder.AllowUserToAddRows = false;
            this.gridReportOrder.AllowUserToDeleteRows = false;
            this.gridReportOrder.AllowUserToResizeColumns = false;
            this.gridReportOrder.AllowUserToResizeRows = false;
            this.gridReportOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReportOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReportOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridReportOrder.Location = new System.Drawing.Point(-2, 1);
            this.gridReportOrder.MultiSelect = false;
            this.gridReportOrder.Name = "gridReportOrder";
            this.gridReportOrder.RowHeadersVisible = false;
            this.gridReportOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReportOrder.Size = new System.Drawing.Size(357, 202);
            this.gridReportOrder.TabIndex = 21;
            this.gridReportOrder.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridReportOrder_CellMouseMove);
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "idReport";
            this.Column0.FillWeight = 83.26755F;
            this.Column0.HeaderText = "idReport";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Customer";
            this.Column1.FillWeight = 84.50786F;
            this.Column1.HeaderText = "Customer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "addOp";
            this.Column2.FillWeight = 78.88686F;
            this.Column2.HeaderText = "Add";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "updateOp";
            this.Column3.FillWeight = 84.50786F;
            this.Column3.HeaderText = "Update";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "viewOp";
            this.Column4.FillWeight = 84.50786F;
            this.Column4.HeaderText = "View";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "date";
            this.Column5.FillWeight = 102.3458F;
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(12, 209);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(134, 30);
            this.btnSaveXML.TabIndex = 22;
            this.btnSaveXML.Text = "Save XML";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.Location = new System.Drawing.Point(184, 211);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(126, 27);
            this.btnSaveCSV.TabIndex = 23;
            this.btnSaveCSV.Text = "Save CSV";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // ReportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 247);
            this.Controls.Add(this.btnSaveCSV);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.gridReportOrder);
            this.Name = "ReportOrder";
            this.Text = "ReportOrder";
            ((System.ComponentModel.ISupportInitialize)(this.gridReportOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridReportOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.Button btnSaveCSV;
    }
}