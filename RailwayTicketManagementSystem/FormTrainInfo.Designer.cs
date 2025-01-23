namespace RailwayTicketManagementSystem
{
    partial class FormTrainInfo
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
            this.pnlFormTrainInfo = new System.Windows.Forms.Panel();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lblSearchbyTrainId = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.dgvTrainInfo = new System.Windows.Forms.DataGridView();
            this.TrainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.txtTrainId = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddMsg = new System.Windows.Forms.Label();
            this.lblUpdateMsg = new System.Windows.Forms.Label();
            this.pnlFormTrainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormTrainInfo
            // 
            this.pnlFormTrainInfo.BackColor = System.Drawing.Color.White;
            this.pnlFormTrainInfo.Controls.Add(this.lblUpdateMsg);
            this.pnlFormTrainInfo.Controls.Add(this.lblAddMsg);
            this.pnlFormTrainInfo.Controls.Add(this.txtAvailable);
            this.pnlFormTrainInfo.Controls.Add(this.lblSearchbyTrainId);
            this.pnlFormTrainInfo.Controls.Add(this.txtAutoSearch);
            this.pnlFormTrainInfo.Controls.Add(this.dgvTrainInfo);
            this.pnlFormTrainInfo.Controls.Add(this.txtPrice);
            this.pnlFormTrainInfo.Controls.Add(this.txtTo);
            this.pnlFormTrainInfo.Controls.Add(this.txtFrom);
            this.pnlFormTrainInfo.Controls.Add(this.txtTrainName);
            this.pnlFormTrainInfo.Controls.Add(this.txtTrainId);
            this.pnlFormTrainInfo.Controls.Add(this.lblPrice);
            this.pnlFormTrainInfo.Controls.Add(this.lblAvailable);
            this.pnlFormTrainInfo.Controls.Add(this.lblTo);
            this.pnlFormTrainInfo.Controls.Add(this.lblFrom);
            this.pnlFormTrainInfo.Controls.Add(this.lblTrainName);
            this.pnlFormTrainInfo.Controls.Add(this.label2);
            this.pnlFormTrainInfo.Controls.Add(this.btnSave);
            this.pnlFormTrainInfo.Controls.Add(this.btnClearAll);
            this.pnlFormTrainInfo.Controls.Add(this.btnBack);
            this.pnlFormTrainInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormTrainInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTrainInfo.Name = "pnlFormTrainInfo";
            this.pnlFormTrainInfo.Size = new System.Drawing.Size(925, 660);
            this.pnlFormTrainInfo.TabIndex = 7;
            this.pnlFormTrainInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormTrainInfo_Paint);
            // 
            // txtAvailable
            // 
            this.txtAvailable.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailable.Location = new System.Drawing.Point(454, 23);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(164, 27);
            this.txtAvailable.TabIndex = 75;
            this.txtAvailable.TextChanged += new System.EventHandler(this.txtAvailable_TextChanged);
            // 
            // lblSearchbyTrainId
            // 
            this.lblSearchbyTrainId.AutoSize = true;
            this.lblSearchbyTrainId.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyTrainId.ForeColor = System.Drawing.Color.Green;
            this.lblSearchbyTrainId.Location = new System.Drawing.Point(639, 264);
            this.lblSearchbyTrainId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchbyTrainId.Name = "lblSearchbyTrainId";
            this.lblSearchbyTrainId.Size = new System.Drawing.Size(126, 16);
            this.lblSearchbyTrainId.TabIndex = 74;
            this.lblSearchbyTrainId.Text = "Search by Train ID";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(773, 258);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(128, 22);
            this.txtAutoSearch.TabIndex = 71;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // dgvTrainInfo
            // 
            this.dgvTrainInfo.AllowUserToAddRows = false;
            this.dgvTrainInfo.AllowUserToDeleteRows = false;
            this.dgvTrainInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainId,
            this.TrainName,
            this.FromStation,
            this.ToStation,
            this.Available,
            this.Price});
            this.dgvTrainInfo.Location = new System.Drawing.Point(12, 290);
            this.dgvTrainInfo.Name = "dgvTrainInfo";
            this.dgvTrainInfo.ReadOnly = true;
            this.dgvTrainInfo.RowHeadersWidth = 51;
            this.dgvTrainInfo.RowTemplate.Height = 24;
            this.dgvTrainInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainInfo.Size = new System.Drawing.Size(901, 314);
            this.dgvTrainInfo.TabIndex = 70;
            this.dgvTrainInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainInfo_CellContentClick);
            // 
            // TrainId
            // 
            this.TrainId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainId.DataPropertyName = "TrainId";
            this.TrainId.HeaderText = "Train ID";
            this.TrainId.MinimumWidth = 6;
            this.TrainId.Name = "TrainId";
            this.TrainId.ReadOnly = true;
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
            this.ToStation.HeaderText = "To  Station";
            this.ToStation.MinimumWidth = 6;
            this.ToStation.Name = "ToStation";
            this.ToStation.ReadOnly = true;
            // 
            // Available
            // 
            this.Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(454, 72);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 27);
            this.txtPrice.TabIndex = 22;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(144, 180);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(164, 27);
            this.txtTo.TabIndex = 21;
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(144, 128);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(164, 27);
            this.txtFrom.TabIndex = 20;
            // 
            // txtTrainName
            // 
            this.txtTrainName.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainName.Location = new System.Drawing.Point(144, 71);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(164, 27);
            this.txtTrainName.TabIndex = 19;
            // 
            // txtTrainId
            // 
            this.txtTrainId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainId.Location = new System.Drawing.Point(144, 21);
            this.txtTrainId.Name = "txtTrainId";
            this.txtTrainId.Size = new System.Drawing.Size(164, 27);
            this.txtTrainId.TabIndex = 18;
            this.txtTrainId.TextChanged += new System.EventHandler(this.txtTrainId_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(343, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 21);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblTotalSeat_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(343, 24);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(89, 21);
            this.lblAvailable.TabIndex = 16;
            this.lblAvailable.Text = "Available";
            this.lblAvailable.Click += new System.EventHandler(this.lblAvailable_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(23, 181);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(95, 21);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "To Station";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(23, 129);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(117, 21);
            this.lblFrom.TabIndex = 14;
            this.lblFrom.Text = "From Station";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainName.Location = new System.Drawing.Point(23, 75);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(107, 21);
            this.lblTrainName.TabIndex = 13;
            this.lblTrainName.Text = "Train Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Train Id";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(49, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Green;
            this.btnClearAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearAll.Location = new System.Drawing.Point(667, 75);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(98, 32);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(12, 616);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddMsg
            // 
            this.lblAddMsg.AutoSize = true;
            this.lblAddMsg.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMsg.ForeColor = System.Drawing.Color.Red;
            this.lblAddMsg.Location = new System.Drawing.Point(376, 142);
            this.lblAddMsg.Name = "lblAddMsg";
            this.lblAddMsg.Size = new System.Drawing.Size(287, 32);
            this.lblAddMsg.TabIndex = 79;
            this.lblAddMsg.Text = "*To add a new train fill up the text box\'s and\r\nclick to the save button. \r\n";
            this.lblAddMsg.Click += new System.EventHandler(this.lblAddMsg_Click);
            // 
            // lblUpdateMsg
            // 
            this.lblUpdateMsg.AutoSize = true;
            this.lblUpdateMsg.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMsg.ForeColor = System.Drawing.Color.Red;
            this.lblUpdateMsg.Location = new System.Drawing.Point(376, 197);
            this.lblUpdateMsg.Name = "lblUpdateMsg";
            this.lblUpdateMsg.Size = new System.Drawing.Size(286, 32);
            this.lblUpdateMsg.TabIndex = 80;
            this.lblUpdateMsg.Text = "*To update a train write in the text box\'s and\r\nclick to the save button. \r\n";
            this.lblUpdateMsg.Click += new System.EventHandler(this.lblUpdateMsg_Click);
            // 
            // FormTrainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 660);
            this.Controls.Add(this.pnlFormTrainInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTrainInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrainInfo";
            this.pnlFormTrainInfo.ResumeLayout(false);
            this.pnlFormTrainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTrainInfo;
        private System.Windows.Forms.Label lblSearchbyTrainId;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridView dgvTrainInfo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.TextBox txtTrainId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTrainName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblAddMsg;
        private System.Windows.Forms.Label lblUpdateMsg;
    }
}