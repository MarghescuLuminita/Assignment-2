namespace FurnitureManufacturer.View
{
    partial class ProductToOrder
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
            this.gridProductToOrder = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductToOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductToOrder
            // 
            this.gridProductToOrder.AllowUserToAddRows = false;
            this.gridProductToOrder.AllowUserToDeleteRows = false;
            this.gridProductToOrder.AllowUserToResizeColumns = false;
            this.gridProductToOrder.AllowUserToResizeRows = false;
            this.gridProductToOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductToOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductToOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridProductToOrder.Location = new System.Drawing.Point(-1, 0);
            this.gridProductToOrder.MultiSelect = false;
            this.gridProductToOrder.Name = "gridProductToOrder";
            this.gridProductToOrder.RowHeadersVisible = false;
            this.gridProductToOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductToOrder.Size = new System.Drawing.Size(357, 202);
            this.gridProductToOrder.TabIndex = 20;
            this.gridProductToOrder.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProductToOrder_CellMouseMove);
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "idOrder";
            this.Column0.FillWeight = 65.12508F;
            this.Column0.HeaderText = "idOrder";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idProduct";
            this.Column1.FillWeight = 82.57092F;
            this.Column1.HeaderText = "idProduct";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PriceUnit";
            this.Column2.FillWeight = 105.1859F;
            this.Column2.HeaderText = "PriceUnit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quantity";
            this.Column3.FillWeight = 82.57092F;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.FillWeight = 82.57092F;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ProductToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 202);
            this.Controls.Add(this.gridProductToOrder);
            this.Name = "ProductToOrder";
            this.Text = "ProductToOrder";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductToOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductToOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}