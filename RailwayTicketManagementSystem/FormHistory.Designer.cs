namespace RailwayTicketManagementSystem
{
    partial class FormHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHistory = new System.Windows.Forms.Label();
            this.gdvCart = new System.Windows.Forms.DataGridView();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainIdCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainNameCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStationCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStationCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearchbyId = new System.Windows.Forms.Label();
            this.txtUserIDSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearchbyId);
            this.panel1.Controls.Add(this.txtUserIDSearch);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblHistory);
            this.panel1.Controls.Add(this.gdvCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 525);
            this.panel1.TabIndex = 0;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.Green;
            this.lblHistory.Location = new System.Drawing.Point(322, 9);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(61, 16);
            this.lblHistory.TabIndex = 35;
            this.lblHistory.Text = "History";
            // 
            // gdvCart
            // 
            this.gdvCart.AllowUserToAddRows = false;
            this.gdvCart.AllowUserToDeleteRows = false;
            this.gdvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNumber,
            this.TrainIdCart,
            this.TrainNameCart,
            this.FromStationCart,
            this.ToStationCart,
            this.PriceCart,
            this.UserId});
            this.gdvCart.Location = new System.Drawing.Point(11, 94);
            this.gdvCart.Margin = new System.Windows.Forms.Padding(2);
            this.gdvCart.Name = "gdvCart";
            this.gdvCart.ReadOnly = true;
            this.gdvCart.RowHeadersWidth = 51;
            this.gdvCart.RowTemplate.Height = 24;
            this.gdvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvCart.Size = new System.Drawing.Size(682, 366);
            this.gdvCart.TabIndex = 34;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "Invoice No";
            this.InvoiceNumber.MinimumWidth = 6;
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // TrainIdCart
            // 
            this.TrainIdCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainIdCart.DataPropertyName = "TrainIdCart";
            this.TrainIdCart.HeaderText = "Train ID";
            this.TrainIdCart.MinimumWidth = 6;
            this.TrainIdCart.Name = "TrainIdCart";
            this.TrainIdCart.ReadOnly = true;
            // 
            // TrainNameCart
            // 
            this.TrainNameCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainNameCart.DataPropertyName = "TrainNameCart";
            this.TrainNameCart.HeaderText = "Train Name";
            this.TrainNameCart.MinimumWidth = 6;
            this.TrainNameCart.Name = "TrainNameCart";
            this.TrainNameCart.ReadOnly = true;
            // 
            // FromStationCart
            // 
            this.FromStationCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromStationCart.DataPropertyName = "FromStationCart";
            this.FromStationCart.HeaderText = "From Station";
            this.FromStationCart.MinimumWidth = 6;
            this.FromStationCart.Name = "FromStationCart";
            this.FromStationCart.ReadOnly = true;
            // 
            // ToStationCart
            // 
            this.ToStationCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToStationCart.DataPropertyName = "ToStationCart";
            this.ToStationCart.HeaderText = "To Station";
            this.ToStationCart.MinimumWidth = 6;
            this.ToStationCart.Name = "ToStationCart";
            this.ToStationCart.ReadOnly = true;
            // 
            // PriceCart
            // 
            this.PriceCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceCart.DataPropertyName = "PriceCart";
            this.PriceCart.HeaderText = "Price";
            this.PriceCart.MinimumWidth = 6;
            this.PriceCart.Name = "PriceCart";
            this.PriceCart.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(278, 473);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 32);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblSearchbyId
            // 
            this.lblSearchbyId.AutoSize = true;
            this.lblSearchbyId.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyId.ForeColor = System.Drawing.Color.Green;
            this.lblSearchbyId.Location = new System.Drawing.Point(528, 69);
            this.lblSearchbyId.Name = "lblSearchbyId";
            this.lblSearchbyId.Size = new System.Drawing.Size(67, 13);
            this.lblSearchbyId.TabIndex = 76;
            this.lblSearchbyId.Text = "Search by Id";
            // 
            // txtUserIDSearch
            // 
            this.txtUserIDSearch.Location = new System.Drawing.Point(599, 64);
            this.txtUserIDSearch.Name = "txtUserIDSearch";
            this.txtUserIDSearch.Size = new System.Drawing.Size(74, 20);
            this.txtUserIDSearch.TabIndex = 75;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 525);
            this.Controls.Add(this.panel1);
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView gdvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainIdCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNameCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchbyId;
        private System.Windows.Forms.TextBox txtUserIDSearch;
    }
}