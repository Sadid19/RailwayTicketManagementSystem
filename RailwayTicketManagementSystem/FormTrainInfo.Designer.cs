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
            this.lblSearchbyTrainName = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.dgvTrainInfo = new System.Windows.Forms.DataGridView();
            this.txtTotalSeat = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.txtTrainId = new System.Windows.Forms.TextBox();
            this.lblTotalSeat = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlFormTrainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormTrainInfo
            // 
            this.pnlFormTrainInfo.BackColor = System.Drawing.Color.White;
            this.pnlFormTrainInfo.Controls.Add(this.lblSearchbyTrainName);
            this.pnlFormTrainInfo.Controls.Add(this.txtAutoSearch);
            this.pnlFormTrainInfo.Controls.Add(this.dgvTrainInfo);
            this.pnlFormTrainInfo.Controls.Add(this.txtTotalSeat);
            this.pnlFormTrainInfo.Controls.Add(this.txtTo);
            this.pnlFormTrainInfo.Controls.Add(this.txtFrom);
            this.pnlFormTrainInfo.Controls.Add(this.txtTrainName);
            this.pnlFormTrainInfo.Controls.Add(this.txtTrainId);
            this.pnlFormTrainInfo.Controls.Add(this.lblTotalSeat);
            this.pnlFormTrainInfo.Controls.Add(this.lblTime);
            this.pnlFormTrainInfo.Controls.Add(this.lblTo);
            this.pnlFormTrainInfo.Controls.Add(this.lblFrom);
            this.pnlFormTrainInfo.Controls.Add(this.lblTrainName);
            this.pnlFormTrainInfo.Controls.Add(this.dtpTime);
            this.pnlFormTrainInfo.Controls.Add(this.label2);
            this.pnlFormTrainInfo.Controls.Add(this.btnDelete);
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
            // lblSearchbyTrainName
            // 
            this.lblSearchbyTrainName.AutoSize = true;
            this.lblSearchbyTrainName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyTrainName.ForeColor = System.Drawing.Color.Green;
            this.lblSearchbyTrainName.Location = new System.Drawing.Point(552, 261);
            this.lblSearchbyTrainName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchbyTrainName.Name = "lblSearchbyTrainName";
            this.lblSearchbyTrainName.Size = new System.Drawing.Size(147, 16);
            this.lblSearchbyTrainName.TabIndex = 74;
            this.lblSearchbyTrainName.Text = "Search by Train Name";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(707, 258);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(194, 22);
            this.txtAutoSearch.TabIndex = 71;
            // 
            // dgvTrainInfo
            // 
            this.dgvTrainInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainInfo.Location = new System.Drawing.Point(12, 290);
            this.dgvTrainInfo.Name = "dgvTrainInfo";
            this.dgvTrainInfo.RowHeadersWidth = 51;
            this.dgvTrainInfo.RowTemplate.Height = 24;
            this.dgvTrainInfo.Size = new System.Drawing.Size(901, 314);
            this.dgvTrainInfo.TabIndex = 70;
            // 
            // txtTotalSeat
            // 
            this.txtTotalSeat.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSeat.Location = new System.Drawing.Point(535, 158);
            this.txtTotalSeat.Name = "txtTotalSeat";
            this.txtTotalSeat.Size = new System.Drawing.Size(164, 28);
            this.txtTotalSeat.TabIndex = 22;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(535, 89);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(164, 28);
            this.txtTo.TabIndex = 21;
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(535, 21);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(164, 28);
            this.txtFrom.TabIndex = 20;
            // 
            // txtTrainName
            // 
            this.txtTrainName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainName.Location = new System.Drawing.Point(158, 89);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(164, 31);
            this.txtTrainName.TabIndex = 19;
            // 
            // txtTrainId
            // 
            this.txtTrainId.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainId.Location = new System.Drawing.Point(158, 22);
            this.txtTrainId.Name = "txtTrainId";
            this.txtTrainId.Size = new System.Drawing.Size(164, 28);
            this.txtTrainId.TabIndex = 18;
            // 
            // lblTotalSeat
            // 
            this.lblTotalSeat.AutoSize = true;
            this.lblTotalSeat.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeat.Location = new System.Drawing.Point(404, 159);
            this.lblTotalSeat.Name = "lblTotalSeat";
            this.lblTotalSeat.Size = new System.Drawing.Size(116, 21);
            this.lblTotalSeat.TabIndex = 17;
            this.lblTotalSeat.Text = "Total Seat: ";
            this.lblTotalSeat.Click += new System.EventHandler(this.lblTotalSeat_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(23, 160);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 21);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Time";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(404, 90);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 21);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(404, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(65, 21);
            this.lblFrom.TabIndex = 14;
            this.lblFrom.Text = "From:";
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainName.Location = new System.Drawing.Point(23, 92);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(117, 21);
            this.lblTrainName.TabIndex = 13;
            this.lblTrainName.Text = "Train Name";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "yyyy-MM-dd";
            this.dtpTime.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(158, 158);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(164, 31);
            this.dtpTime.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Train Id";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(206, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(53, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Green;
            this.btnClearAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearAll.Location = new System.Drawing.Point(771, 92);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(98, 32);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = false;
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
            // FormTrainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 660);
            this.Controls.Add(this.pnlFormTrainInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormTrainInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrainInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTrainInfo_FormClosed);
            this.pnlFormTrainInfo.ResumeLayout(false);
            this.pnlFormTrainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTrainInfo;
        private System.Windows.Forms.Label lblSearchbyTrainName;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridView dgvTrainInfo;
        private System.Windows.Forms.TextBox txtTotalSeat;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.TextBox txtTrainId;
        private System.Windows.Forms.Label lblTotalSeat;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTrainName;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnBack;
    }
}