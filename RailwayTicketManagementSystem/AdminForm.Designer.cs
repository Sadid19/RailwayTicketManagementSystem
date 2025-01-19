namespace RailwayTicketManagementSystem
{
    partial class AdminForm
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
            this.pnlAdminDashboard = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeOutput = new System.Windows.Forms.Label();
            this.btnTrainInfo = new System.Windows.Forms.Button();
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblChooseClass = new System.Windows.Forms.Label();
            this.cmbChooseClass = new System.Windows.Forms.ComboBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.pbProfileIcon = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblRouteTrainDetails = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.txtPassengerPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPassengerPhoneNum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlAdminDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.BackColor = System.Drawing.SystemColors.Window;
            this.pnlAdminDashboard.Controls.Add(this.btnCancel);
            this.pnlAdminDashboard.Controls.Add(this.btnConfirm);
            this.pnlAdminDashboard.Controls.Add(this.btnContinue);
            this.pnlAdminDashboard.Controls.Add(this.cmbQuantity);
            this.pnlAdminDashboard.Controls.Add(this.lblQuantity);
            this.pnlAdminDashboard.Controls.Add(this.lblTotal);
            this.pnlAdminDashboard.Controls.Add(this.txtPassengerPhoneNum);
            this.pnlAdminDashboard.Controls.Add(this.lblPassengerPhoneNum);
            this.pnlAdminDashboard.Controls.Add(this.lblHistory);
            this.pnlAdminDashboard.Controls.Add(this.lblRouteTrainDetails);
            this.pnlAdminDashboard.Controls.Add(this.dataGridView2);
            this.pnlAdminDashboard.Controls.Add(this.dataGridView1);
            this.pnlAdminDashboard.Controls.Add(this.txtTo);
            this.pnlAdminDashboard.Controls.Add(this.txtFrom);
            this.pnlAdminDashboard.Controls.Add(this.cmbChooseClass);
            this.pnlAdminDashboard.Controls.Add(this.lblChooseClass);
            this.pnlAdminDashboard.Controls.Add(this.lblTo);
            this.pnlAdminDashboard.Controls.Add(this.lblFrom);
            this.pnlAdminDashboard.Controls.Add(this.btnLogout);
            this.pnlAdminDashboard.Controls.Add(this.btnEmployeeList);
            this.pnlAdminDashboard.Controls.Add(this.btnTrainInfo);
            this.pnlAdminDashboard.Controls.Add(this.lblWelcomeOutput);
            this.pnlAdminDashboard.Controls.Add(this.lblWelcome);
            this.pnlAdminDashboard.Controls.Add(this.pbProfileIcon);
            this.pnlAdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminDashboard.ForeColor = System.Drawing.Color.Black;
            this.pnlAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(1545, 781);
            this.pnlAdminDashboard.TabIndex = 0;
            this.pnlAdminDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminDashboard_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(54, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(103, 21);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, ";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblWelcomeOutput
            // 
            this.lblWelcomeOutput.AutoSize = true;
            this.lblWelcomeOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeOutput.ForeColor = System.Drawing.Color.Black;
            this.lblWelcomeOutput.Location = new System.Drawing.Point(153, 32);
            this.lblWelcomeOutput.Name = "lblWelcomeOutput";
            this.lblWelcomeOutput.Size = new System.Drawing.Size(151, 21);
            this.lblWelcomeOutput.TabIndex = 2;
            this.lblWelcomeOutput.Text = "WelcomeOutput";
            this.lblWelcomeOutput.Click += new System.EventHandler(this.lblWelcomeOutput_Click);
            // 
            // btnTrainInfo
            // 
            this.btnTrainInfo.BackColor = System.Drawing.Color.Green;
            this.btnTrainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnTrainInfo.Location = new System.Drawing.Point(983, 17);
            this.btnTrainInfo.Name = "btnTrainInfo";
            this.btnTrainInfo.Size = new System.Drawing.Size(166, 53);
            this.btnTrainInfo.TabIndex = 3;
            this.btnTrainInfo.Text = "Train Information";
            this.btnTrainInfo.UseVisualStyleBackColor = false;
            this.btnTrainInfo.Click += new System.EventHandler(this.btnTrainInfo_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.Green;
            this.btnEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeList.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmployeeList.Location = new System.Drawing.Point(1172, 17);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(166, 53);
            this.btnEmployeeList.TabIndex = 4;
            this.btnEmployeeList.Text = "Employee List";
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Green;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(1358, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 53);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(24, 110);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(67, 21);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From: ";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(288, 112);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 21);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // lblChooseClass
            // 
            this.lblChooseClass.AutoSize = true;
            this.lblChooseClass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseClass.ForeColor = System.Drawing.Color.Black;
            this.lblChooseClass.Location = new System.Drawing.Point(529, 114);
            this.lblChooseClass.Name = "lblChooseClass";
            this.lblChooseClass.Size = new System.Drawing.Size(142, 21);
            this.lblChooseClass.TabIndex = 8;
            this.lblChooseClass.Text = "Choose Class: ";
            this.lblChooseClass.Click += new System.EventHandler(this.lblChooseClass_Click);
            // 
            // cmbChooseClass
            // 
            this.cmbChooseClass.ForeColor = System.Drawing.Color.Black;
            this.cmbChooseClass.FormattingEnabled = true;
            this.cmbChooseClass.Items.AddRange(new object[] {
            "AC_B",
            "AC_S",
            "S_Chair",
            "Snigdha"});
            this.cmbChooseClass.Location = new System.Drawing.Point(677, 113);
            this.cmbChooseClass.Name = "cmbChooseClass";
            this.cmbChooseClass.Size = new System.Drawing.Size(152, 24);
            this.cmbChooseClass.TabIndex = 9;
            this.cmbChooseClass.SelectedIndexChanged += new System.EventHandler(this.cmbChooseClass_SelectedIndexChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.Black;
            this.txtFrom.Location = new System.Drawing.Point(97, 110);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(158, 25);
            this.txtFrom.TabIndex = 10;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.Color.Black;
            this.txtTo.Location = new System.Drawing.Point(341, 110);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(158, 25);
            this.txtTo.TabIndex = 11;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // pbProfileIcon
            // 
            this.pbProfileIcon.BackgroundImage = global::RailwayTicketManagementSystem.Properties.Resources.rsz_usericon;
            this.pbProfileIcon.Location = new System.Drawing.Point(10, 18);
            this.pbProfileIcon.Name = "pbProfileIcon";
            this.pbProfileIcon.Size = new System.Drawing.Size(38, 35);
            this.pbProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfileIcon.TabIndex = 0;
            this.pbProfileIcon.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 351);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(792, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(732, 351);
            this.dataGridView2.TabIndex = 13;
            // 
            // lblRouteTrainDetails
            // 
            this.lblRouteTrainDetails.AutoSize = true;
            this.lblRouteTrainDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteTrainDetails.ForeColor = System.Drawing.Color.Black;
            this.lblRouteTrainDetails.Location = new System.Drawing.Point(315, 201);
            this.lblRouteTrainDetails.Name = "lblRouteTrainDetails";
            this.lblRouteTrainDetails.Size = new System.Drawing.Size(122, 21);
            this.lblRouteTrainDetails.TabIndex = 14;
            this.lblRouteTrainDetails.Text = "Train Details";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.Black;
            this.lblHistory.Location = new System.Drawing.Point(1094, 201);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(74, 21);
            this.lblHistory.TabIndex = 15;
            this.lblHistory.Text = "History";
            // 
            // txtPassengerPhoneNum
            // 
            this.txtPassengerPhoneNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassengerPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.txtPassengerPhoneNum.Location = new System.Drawing.Point(248, 621);
            this.txtPassengerPhoneNum.Name = "txtPassengerPhoneNum";
            this.txtPassengerPhoneNum.Size = new System.Drawing.Size(146, 25);
            this.txtPassengerPhoneNum.TabIndex = 17;
            // 
            // lblPassengerPhoneNum
            // 
            this.lblPassengerPhoneNum.AutoSize = true;
            this.lblPassengerPhoneNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.lblPassengerPhoneNum.Location = new System.Drawing.Point(17, 621);
            this.lblPassengerPhoneNum.Name = "lblPassengerPhoneNum";
            this.lblPassengerPhoneNum.Size = new System.Drawing.Size(213, 21);
            this.lblPassengerPhoneNum.TabIndex = 16;
            this.lblPassengerPhoneNum.Text = "Passenger Phone No. :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(473, 625);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 21);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total: ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(26, 684);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(95, 21);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.ForeColor = System.Drawing.Color.Black;
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbQuantity.Location = new System.Drawing.Point(127, 685);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(56, 24);
            this.cmbQuantity.TabIndex = 20;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Green;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Transparent;
            this.btnContinue.Location = new System.Drawing.Point(562, 700);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(111, 35);
            this.btnContinue.TabIndex = 21;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Location = new System.Drawing.Point(1287, 607);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 35);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(1404, 607);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 781);
            this.Controls.Add(this.pnlAdminDashboard);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard ";
            this.pnlAdminDashboard.ResumeLayout(false);
            this.pnlAdminDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminDashboard;
        private System.Windows.Forms.PictureBox pbProfileIcon;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTrainInfo;
        private System.Windows.Forms.Label lblWelcomeOutput;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployeeList;
        private System.Windows.Forms.Label lblChooseClass;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ComboBox cmbChooseClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblRouteTrainDetails;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPassengerPhoneNum;
        private System.Windows.Forms.Label lblPassengerPhoneNum;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}