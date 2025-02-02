﻿namespace RailwayTicketManagementSystem
{
    partial class FormAdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAdminDashboard = new System.Windows.Forms.Panel();
            this.lblTk = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
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
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbAdminProfileIcon = new System.Windows.Forms.PictureBox();
            this.pnlAdminDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTrainList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminProfileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.BackColor = System.Drawing.Color.White;
            this.pnlAdminDashboard.Controls.Add(this.pbAdminProfileIcon);
            this.pnlAdminDashboard.Controls.Add(this.lblTk);
            this.pnlAdminDashboard.Controls.Add(this.btnHistory);
            this.pnlAdminDashboard.Controls.Add(this.btnUpdateDetails);
            this.pnlAdminDashboard.Controls.Add(this.btnDelete);
            this.pnlAdminDashboard.Controls.Add(this.btnAddTrain);
            this.pnlAdminDashboard.Controls.Add(this.btnCancel);
            this.pnlAdminDashboard.Controls.Add(this.btnConfirm);
            this.pnlAdminDashboard.Controls.Add(this.btnContinue);
            this.pnlAdminDashboard.Controls.Add(this.lblAmount);
            this.pnlAdminDashboard.Controls.Add(this.lblCart);
            this.pnlAdminDashboard.Controls.Add(this.lblTrainList);
            this.pnlAdminDashboard.Controls.Add(this.gdvCart);
            this.pnlAdminDashboard.Controls.Add(this.lblTotal);
            this.pnlAdminDashboard.Controls.Add(this.cmbQuantity);
            this.pnlAdminDashboard.Controls.Add(this.lblQuantity);
            this.pnlAdminDashboard.Controls.Add(this.gdvTrainList);
            this.pnlAdminDashboard.Controls.Add(this.btnLogOut);
            this.pnlAdminDashboard.Controls.Add(this.btnEmployeeList);
            this.pnlAdminDashboard.Controls.Add(this.lblWelcome);
            this.pnlAdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(1540, 753);
            this.pnlAdminDashboard.TabIndex = 0;
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.ForeColor = System.Drawing.Color.Green;
            this.lblTk.Location = new System.Drawing.Point(178, 636);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(28, 21);
            this.lblTk.TabIndex = 28;
            this.lblTk.Text = "tk";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Green;
            this.btnHistory.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistory.Location = new System.Drawing.Point(1149, 12);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(109, 48);
            this.btnHistory.TabIndex = 27;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.BackColor = System.Drawing.Color.Green;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateDetails.Location = new System.Drawing.Point(430, 685);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(126, 39);
            this.btnUpdateDetails.TabIndex = 26;
            this.btnUpdateDetails.Text = "Update Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = false;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(602, 685);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 39);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.BackColor = System.Drawing.Color.Green;
            this.btnAddTrain.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrain.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddTrain.Location = new System.Drawing.Point(273, 685);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(109, 39);
            this.btnAddTrain.TabIndex = 24;
            this.btnAddTrain.Text = "Add Train";
            this.btnAddTrain.UseVisualStyleBackColor = false;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(1395, 636);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 39);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(1294, 636);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 39);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Green;
            this.btnContinue.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Transparent;
            this.btnContinue.Location = new System.Drawing.Point(663, 566);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(109, 39);
            this.btnContinue.TabIndex = 21;
            this.btnContinue.Text = "Continue>>";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Green;
            this.lblAmount.Location = new System.Drawing.Point(112, 636);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(38, 21);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "0.0";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.Green;
            this.lblCart.Location = new System.Drawing.Point(1114, 78);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(49, 21);
            this.lblCart.TabIndex = 19;
            this.lblCart.Text = "Cart";
            // 
            // lblTrainList
            // 
            this.lblTrainList.AutoSize = true;
            this.lblTrainList.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainList.ForeColor = System.Drawing.Color.Green;
            this.lblTrainList.Location = new System.Drawing.Point(329, 78);
            this.lblTrainList.Name = "lblTrainList";
            this.lblTrainList.Size = new System.Drawing.Size(101, 21);
            this.lblTrainList.TabIndex = 18;
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
            this.gdvCart.Location = new System.Drawing.Point(798, 112);
            this.gdvCart.Name = "gdvCart";
            this.gdvCart.ReadOnly = true;
            this.gdvCart.RowHeadersWidth = 51;
            this.gdvCart.RowTemplate.Height = 24;
            this.gdvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvCart.Size = new System.Drawing.Size(730, 450);
            this.gdvCart.TabIndex = 17;
            this.gdvCart.SelectionChanged += new System.EventHandler(this.gdvCart_SelectionChanged_1);
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
            this.lblTotal.Location = new System.Drawing.Point(48, 636);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 21);
            this.lblTotal.TabIndex = 16;
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
            this.cmbQuantity.Location = new System.Drawing.Point(140, 584);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(56, 24);
            this.cmbQuantity.TabIndex = 13;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Green;
            this.lblQuantity.Location = new System.Drawing.Point(45, 584);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(89, 21);
            this.lblQuantity.TabIndex = 12;
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
            this.gdvTrainList.Location = new System.Drawing.Point(12, 112);
            this.gdvTrainList.Name = "gdvTrainList";
            this.gdvTrainList.ReadOnly = true;
            this.gdvTrainList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.gdvTrainList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gdvTrainList.RowTemplate.Height = 24;
            this.gdvTrainList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvTrainList.Size = new System.Drawing.Size(771, 450);
            this.gdvTrainList.TabIndex = 11;
            this.gdvTrainList.SelectionChanged += new System.EventHandler(this.gdvTrainList_SelectionChanged_1);
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
            this.btnLogOut.Location = new System.Drawing.Point(1395, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(109, 48);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.Green;
            this.btnEmployeeList.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeList.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmployeeList.Location = new System.Drawing.Point(1274, 12);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(109, 48);
            this.btnEmployeeList.TabIndex = 9;
            this.btnEmployeeList.Text = "Employee List";
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Green;
            this.lblWelcome.Location = new System.Drawing.Point(59, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(101, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            // 
            // pbAdminProfileIcon
            // 
            this.pbAdminProfileIcon.Image = global::RailwayTicketManagementSystem.Properties.Resources.rsz_usericon4;
            this.pbAdminProfileIcon.Location = new System.Drawing.Point(12, 12);
            this.pbAdminProfileIcon.Name = "pbAdminProfileIcon";
            this.pbAdminProfileIcon.Size = new System.Drawing.Size(41, 32);
            this.pbAdminProfileIcon.TabIndex = 29;
            this.pbAdminProfileIcon.TabStop = false;
            // 
            // FormAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 753);
            this.Controls.Add(this.pnlAdminDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminDashboard_FormClosed);
            this.pnlAdminDashboard.ResumeLayout(false);
            this.pnlAdminDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTrainList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminProfileIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminDashboard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEmployeeList;
        private System.Windows.Forms.DataGridView gdvTrainList;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView gdvCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTrainList;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainIdCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNameCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStationCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.PictureBox pbAdminProfileIcon;
    }
}