namespace DBapplication
{
    partial class Supplier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpInsert = new System.Windows.Forms.GroupBox();
            this.lblSNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.sNumTextBox = new System.Windows.Forms.TextBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.lblSNumDel = new System.Windows.Forms.Label();
            this.sNumDelTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.lblSNumUpdate = new System.Windows.Forms.Label();
            this.lblCityUpdate = new System.Windows.Forms.Label();
            this.sNumUpdateTextBox = new System.Windows.Forms.TextBox();
            this.cityUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.suppliersDataGrid = new System.Windows.Forms.DataGridView();
            this.grpInsert.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGrid)).BeginInit();
            this.SuspendLayout();
            //
            // grpInsert
            //
            this.grpInsert.Controls.Add(this.lblSNum);
            this.grpInsert.Controls.Add(this.lblName);
            this.grpInsert.Controls.Add(this.lblCity);
            this.grpInsert.Controls.Add(this.lblStatus);
            this.grpInsert.Controls.Add(this.sNumTextBox);
            this.grpInsert.Controls.Add(this.sNameTextBox);
            this.grpInsert.Controls.Add(this.cityTextBox);
            this.grpInsert.Controls.Add(this.statusTextBox);
            this.grpInsert.Controls.Add(this.insertButton);
            this.grpInsert.Location = new System.Drawing.Point(12, 12);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Size = new System.Drawing.Size(380, 200);
            this.grpInsert.TabIndex = 0;
            this.grpInsert.TabStop = false;
            this.grpInsert.Text = "Insert a new supplier";
            //
            // lblSNum
            //
            this.lblSNum.AutoSize = true;
            this.lblSNum.Location = new System.Drawing.Point(15, 30);
            this.lblSNum.Name = "lblSNum";
            this.lblSNum.Text = "S#";
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 62);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Name";
            //
            // lblCity
            //
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(15, 94);
            this.lblCity.Name = "lblCity";
            this.lblCity.Text = "City";
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 126);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Status";
            //
            // sNumTextBox
            //
            this.sNumTextBox.Location = new System.Drawing.Point(110, 27);
            this.sNumTextBox.MaxLength = 5;
            this.sNumTextBox.Name = "sNumTextBox";
            this.sNumTextBox.Size = new System.Drawing.Size(180, 23);
            this.sNumTextBox.TabIndex = 0;
            //
            // sNameTextBox
            //
            this.sNameTextBox.Location = new System.Drawing.Point(110, 59);
            this.sNameTextBox.MaxLength = 20;
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(180, 23);
            this.sNameTextBox.TabIndex = 1;
            //
            // cityTextBox
            //
            this.cityTextBox.Location = new System.Drawing.Point(110, 91);
            this.cityTextBox.MaxLength = 20;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(180, 23);
            this.cityTextBox.TabIndex = 2;
            //
            // statusTextBox
            //
            this.statusTextBox.Location = new System.Drawing.Point(110, 123);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(180, 23);
            this.statusTextBox.TabIndex = 3;
            //
            // insertButton
            //
            this.insertButton.Location = new System.Drawing.Point(110, 156);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 28);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.Insert_Click);
            //
            // grpDelete
            //
            this.grpDelete.Controls.Add(this.lblSNumDel);
            this.grpDelete.Controls.Add(this.sNumDelTextBox);
            this.grpDelete.Controls.Add(this.deleteButton);
            this.grpDelete.Location = new System.Drawing.Point(405, 12);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(380, 80);
            this.grpDelete.TabIndex = 1;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete a supplier";
            //
            // lblSNumDel
            //
            this.lblSNumDel.AutoSize = true;
            this.lblSNumDel.Location = new System.Drawing.Point(15, 34);
            this.lblSNumDel.Name = "lblSNumDel";
            this.lblSNumDel.Text = "S#";
            //
            // sNumDelTextBox
            //
            this.sNumDelTextBox.Location = new System.Drawing.Point(110, 31);
            this.sNumDelTextBox.MaxLength = 5;
            this.sNumDelTextBox.Name = "sNumDelTextBox";
            this.sNumDelTextBox.Size = new System.Drawing.Size(100, 23);
            this.sNumDelTextBox.TabIndex = 0;
            //
            // deleteButton
            //
            this.deleteButton.Location = new System.Drawing.Point(230, 29);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            //
            // grpUpdate
            //
            this.grpUpdate.Controls.Add(this.lblSNumUpdate);
            this.grpUpdate.Controls.Add(this.lblCityUpdate);
            this.grpUpdate.Controls.Add(this.sNumUpdateTextBox);
            this.grpUpdate.Controls.Add(this.cityUpdateTextBox);
            this.grpUpdate.Controls.Add(this.updateButton);
            this.grpUpdate.Location = new System.Drawing.Point(405, 100);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(380, 112);
            this.grpUpdate.TabIndex = 2;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update a supplier's city";
            //
            // lblSNumUpdate
            //
            this.lblSNumUpdate.AutoSize = true;
            this.lblSNumUpdate.Location = new System.Drawing.Point(15, 30);
            this.lblSNumUpdate.Name = "lblSNumUpdate";
            this.lblSNumUpdate.Text = "S#";
            //
            // lblCityUpdate
            //
            this.lblCityUpdate.AutoSize = true;
            this.lblCityUpdate.Location = new System.Drawing.Point(15, 62);
            this.lblCityUpdate.Name = "lblCityUpdate";
            this.lblCityUpdate.Text = "New city";
            //
            // sNumUpdateTextBox
            //
            this.sNumUpdateTextBox.Location = new System.Drawing.Point(110, 27);
            this.sNumUpdateTextBox.MaxLength = 5;
            this.sNumUpdateTextBox.Name = "sNumUpdateTextBox";
            this.sNumUpdateTextBox.Size = new System.Drawing.Size(100, 23);
            this.sNumUpdateTextBox.TabIndex = 0;
            //
            // cityUpdateTextBox
            //
            this.cityUpdateTextBox.Location = new System.Drawing.Point(110, 59);
            this.cityUpdateTextBox.MaxLength = 20;
            this.cityUpdateTextBox.Name = "cityUpdateTextBox";
            this.cityUpdateTextBox.Size = new System.Drawing.Size(150, 23);
            this.cityUpdateTextBox.TabIndex = 1;
            //
            // updateButton
            //
            this.updateButton.Location = new System.Drawing.Point(270, 56);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(90, 28);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            //
            // countButton
            //
            this.countButton.Location = new System.Drawing.Point(12, 225);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(150, 28);
            this.countButton.TabIndex = 3;
            this.countButton.Text = "Count suppliers";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            //
            // countTextBox
            //
            this.countTextBox.Location = new System.Drawing.Point(170, 228);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(80, 23);
            this.countTextBox.TabIndex = 4;
            //
            // selectAllButton
            //
            this.selectAllButton.Location = new System.Drawing.Point(405, 225);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(180, 28);
            this.selectAllButton.TabIndex = 5;
            this.selectAllButton.Text = "Select all suppliers";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            //
            // suppliersDataGrid
            //
            this.suppliersDataGrid.AllowUserToAddRows = false;
            this.suppliersDataGrid.AllowUserToDeleteRows = false;
            this.suppliersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGrid.Location = new System.Drawing.Point(12, 265);
            this.suppliersDataGrid.Name = "suppliersDataGrid";
            this.suppliersDataGrid.ReadOnly = true;
            this.suppliersDataGrid.Size = new System.Drawing.Size(773, 220);
            this.suppliersDataGrid.TabIndex = 6;
            //
            // Supplier
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.grpInsert);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.suppliersDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Supplier_FormClosing);
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInsert;
        private System.Windows.Forms.Label lblSNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox sNumTextBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Label lblSNumDel;
        private System.Windows.Forms.TextBox sNumDelTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Label lblSNumUpdate;
        private System.Windows.Forms.Label lblCityUpdate;
        private System.Windows.Forms.TextBox sNumUpdateTextBox;
        private System.Windows.Forms.TextBox cityUpdateTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.DataGridView suppliersDataGrid;
    }
}
