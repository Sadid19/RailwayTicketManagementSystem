namespace RailwayTicketManagementSystem
{
    partial class FormEmployeDashbord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblTrainList = new System.Windows.Forms.Label();
            this.gdvCart = new System.Windows.Forms.DataGridView();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainIdCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainNameCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStationCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStationCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.gdvTrainList = new System.Windows.Forms.DataGridView();
            this.TrainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTrainList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnUpdateDetails);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAddTrain);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.lblTotalOutput);
            this.panel1.Controls.Add(this.lblCart);
            this.panel1.Controls.Add(this.lblTrainList);
            this.panel1.Controls.Add(this.gdvCart);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.cmbQuantity);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.gdvTrainList);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 594);
            this.panel1.TabIndex = 0;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Green;
            this.btnHistory.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistory.Location = new System.Drawing.Point(938, 16);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(82, 39);
            this.btnHistory.TabIndex = 41;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.BackColor = System.Drawing.Color.Green;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateDetails.Location = new System.Drawing.Point(315, 547);
            this.btnUpdateDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(94, 32);
            this.btnUpdateDetails.TabIndex = 40;
            this.btnUpdateDetails.Text = "Update Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = false;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(445, 547);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.BackColor = System.Drawing.Color.Green;
            this.btnAddTrain.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrain.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddTrain.Location = new System.Drawing.Point(198, 547);
            this.btnAddTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(82, 32);
            this.btnAddTrain.TabIndex = 38;
            this.btnAddTrain.Text = "Add Train";
            this.btnAddTrain.UseVisualStyleBackColor = false;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(1039, 507);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 32);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(963, 507);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(71, 32);
            this.btnConfirm.TabIndex = 36;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Green;
            this.btnContinue.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Transparent;
            this.btnContinue.Location = new System.Drawing.Point(490, 450);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(82, 32);
            this.btnContinue.TabIndex = 35;
            this.btnContinue.Text = "Continue>>";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.AutoSize = true;
            this.lblTotalOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOutput.ForeColor = System.Drawing.Color.Green;
            this.lblTotalOutput.Location = new System.Drawing.Point(63, 507);
            this.lblTotalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(105, 16);
            this.lblTotalOutput.TabIndex = 34;
            this.lblTotalOutput.Text = "Total Outptut";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.Green;
            this.lblCart.Location = new System.Drawing.Point(829, 48);
            this.lblCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(38, 16);
            this.lblCart.TabIndex = 33;
            this.lblCart.Text = "Cart";
            // 
            // lblTrainList
            // 
            this.lblTrainList.AutoSize = true;
            this.lblTrainList.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainList.ForeColor = System.Drawing.Color.Green;
            this.lblTrainList.Location = new System.Drawing.Point(240, 48);
            this.lblTrainList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainList.Name = "lblTrainList";
            this.lblTrainList.Size = new System.Drawing.Size(79, 16);
            this.lblTrainList.TabIndex = 32;
            this.lblTrainList.Text = "Train List";
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
            this.gdvCart.Location = new System.Drawing.Point(591, 76);
            this.gdvCart.Margin = new System.Windows.Forms.Padding(2);
            this.gdvCart.Name = "gdvCart";
            this.gdvCart.ReadOnly = true;
            this.gdvCart.RowHeadersWidth = 51;
            this.gdvCart.RowTemplate.Height = 24;
            this.gdvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvCart.Size = new System.Drawing.Size(548, 366);
            this.gdvCart.TabIndex = 31;
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(4, 507);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 16);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbQuantity.Location = new System.Drawing.Point(73, 464);
            this.cmbQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(43, 21);
            this.cmbQuantity.TabIndex = 29;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Green;
            this.lblQuantity.Location = new System.Drawing.Point(2, 464);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 16);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity";
            // 
            // gdvTrainList
            // 
            this.gdvTrainList.AllowUserToAddRows = false;
            this.gdvTrainList.AllowUserToDeleteRows = false;
            this.gdvTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainID,
            this.TrainName,
            this.FromStation,
            this.ToStation,
            this.Available,
            this.Price});
            this.gdvTrainList.Location = new System.Drawing.Point(2, 76);
            this.gdvTrainList.Margin = new System.Windows.Forms.Padding(2);
            this.gdvTrainList.Name = "gdvTrainList";
            this.gdvTrainList.ReadOnly = true;
            this.gdvTrainList.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.gdvTrainList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gdvTrainList.RowTemplate.Height = 24;
            this.gdvTrainList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvTrainList.Size = new System.Drawing.Size(578, 366);
            this.gdvTrainList.TabIndex = 27;
            // 
            // TrainID
            // 
            this.TrainID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainID.DataPropertyName = "TrainID";
            this.TrainID.HeaderText = "Train ID";
            this.TrainID.MinimumWidth = 6;
            this.TrainID.Name = "TrainID";
            this.TrainID.ReadOnly = true;
            // 
            // TrainName
            // 
            this.TrainName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainName.DataPropertyName = "TrainName";
            this.TrainName.HeaderText = "Train Name";
            this.TrainName.MinimumWidth = 6;
            this.TrainName.Name = "TrainName";
            this.TrainName.ReadOnly = true;
            // 
            // FromStation
            // 
            this.FromStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromStation.DataPropertyName = "FromStation";
            this.FromStation.HeaderText = "From Station";
            this.FromStation.MinimumWidth = 6;
            this.FromStation.Name = "FromStation";
            this.FromStation.ReadOnly = true;
            // 
            // ToStation
            // 
            this.ToStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToStation.DataPropertyName = "ToStation";
            this.ToStation.HeaderText = "To Station";
            this.ToStation.MinimumWidth = 6;
            this.ToStation.Name = "ToStation";
            this.ToStation.ReadOnly = true;
            // 
            // Available
            // 
            this.Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "Available Train";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Ticket Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Green;
            this.btnLogOut.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Location = new System.Drawing.Point(1043, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 44);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Green;
            this.lblWelcome.Location = new System.Drawing.Point(12, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(79, 16);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome,";
            // 
            // FormEmployeDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 595);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEmployeDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployeDashbord_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTrainList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblTrainList;
        private System.Windows.Forms.DataGridView gdvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainIdCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNameCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView gdvTrainList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnHistory;
    }
}