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
            this.lblSearchbyId = new System.Windows.Forms.Label();
            this.txtUserIDSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.gdvHistory = new System.Windows.Forms.DataGridView();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainIdCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainNameCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStationCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStationCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblSearchbyId);
            this.panel1.Controls.Add(this.txtUserIDSearch);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblHistory);
            this.panel1.Controls.Add(this.gdvHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 646);
            this.panel1.TabIndex = 0;
            // 
            // lblSearchbyId
            // 
            this.lblSearchbyId.AutoSize = true;
            this.lblSearchbyId.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyId.ForeColor = System.Drawing.Color.Green;
            this.lblSearchbyId.Location = new System.Drawing.Point(724, 85);
            this.lblSearchbyId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchbyId.Name = "lblSearchbyId";
            this.lblSearchbyId.Size = new System.Drawing.Size(86, 16);
            this.lblSearchbyId.TabIndex = 76;
            this.lblSearchbyId.Text = "Search by Id";
            // 
            // txtUserIDSearch
            // 
            this.txtUserIDSearch.Location = new System.Drawing.Point(818, 79);
            this.txtUserIDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserIDSearch.Name = "txtUserIDSearch";
            this.txtUserIDSearch.Size = new System.Drawing.Size(97, 22);
            this.txtUserIDSearch.TabIndex = 75;
            this.txtUserIDSearch.TextChanged += new System.EventHandler(this.txtUserIDSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(29, 581);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 39);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.Green;
            this.lblHistory.Location = new System.Drawing.Point(434, 27);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(78, 21);
            this.lblHistory.TabIndex = 35;
            this.lblHistory.Text = "History";
            // 
            // gdvHistory
            // 
            this.gdvHistory.AllowUserToAddRows = false;
            this.gdvHistory.AllowUserToDeleteRows = false;
            this.gdvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNumber,
            this.TrainIdCart,
            this.TrainNameCart,
            this.FromStationCart,
            this.ToStationCart,
            this.PriceCart,
            this.UserId});
            this.gdvHistory.Location = new System.Drawing.Point(15, 116);
            this.gdvHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gdvHistory.Name = "gdvHistory";
            this.gdvHistory.ReadOnly = true;
            this.gdvHistory.RowHeadersWidth = 51;
            this.gdvHistory.RowTemplate.Height = 24;
            this.gdvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvHistory.Size = new System.Drawing.Size(909, 450);
            this.gdvHistory.TabIndex = 34;
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
            this.TrainIdCart.DataPropertyName = "TrainIdHistory";
            this.TrainIdCart.HeaderText = "Train ID";
            this.TrainIdCart.MinimumWidth = 6;
            this.TrainIdCart.Name = "TrainIdCart";
            this.TrainIdCart.ReadOnly = true;
            // 
            // TrainNameCart
            // 
            this.TrainNameCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainNameCart.DataPropertyName = "TrainNameHistory";
            this.TrainNameCart.HeaderText = "Train Name";
            this.TrainNameCart.MinimumWidth = 6;
            this.TrainNameCart.Name = "TrainNameCart";
            this.TrainNameCart.ReadOnly = true;
            // 
            // FromStationCart
            // 
            this.FromStationCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromStationCart.DataPropertyName = "FromStationHistory";
            this.FromStationCart.HeaderText = "From Station";
            this.FromStationCart.MinimumWidth = 6;
            this.FromStationCart.Name = "FromStationCart";
            this.FromStationCart.ReadOnly = true;
            // 
            // ToStationCart
            // 
            this.ToStationCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToStationCart.DataPropertyName = "ToStationHistory";
            this.ToStationCart.HeaderText = "To Station";
            this.ToStationCart.MinimumWidth = 6;
            this.ToStationCart.Name = "ToStationCart";
            this.ToStationCart.ReadOnly = true;
            // 
            // PriceCart
            // 
            this.PriceCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceCart.DataPropertyName = "PriceHistory";
            this.PriceCart.HeaderText = "Price";
            this.PriceCart.MinimumWidth = 6;
            this.PriceCart.Name = "PriceCart";
            this.PriceCart.ReadOnly = true;
            this.PriceCart.ToolTipText = "Total price of the ticket";
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserIdHistory";
            this.UserId.HeaderText = "User ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.ToolTipText = "Ticket sell by";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(792, 581);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 39);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "Delete History";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 646);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHistory_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView gdvHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchbyId;
        private System.Windows.Forms.TextBox txtUserIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainIdCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNameCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Button btnDelete;
    }
}