namespace RailwayTicketManagementSystem
{
    partial class FormEmployeeList
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearchbyId = new System.Windows.Forms.Label();
            this.txtEmployeeListAutoSearch = new System.Windows.Forms.TextBox();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlTrainInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.pnlEmployeeList = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnlTrainInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEmployeeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(13, 620);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 35);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSearchbyId
            // 
            this.lblSearchbyId.AutoSize = true;
            this.lblSearchbyId.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyId.ForeColor = System.Drawing.Color.Green;
            this.lblSearchbyId.Location = new System.Drawing.Point(688, 267);
            this.lblSearchbyId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchbyId.Name = "lblSearchbyId";
            this.lblSearchbyId.Size = new System.Drawing.Size(86, 16);
            this.lblSearchbyId.TabIndex = 74;
            this.lblSearchbyId.Text = "Search by Id";
            // 
            // txtEmployeeListAutoSearch
            // 
            this.txtEmployeeListAutoSearch.Location = new System.Drawing.Point(782, 261);
            this.txtEmployeeListAutoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeListAutoSearch.Name = "txtEmployeeListAutoSearch";
            this.txtEmployeeListAutoSearch.Size = new System.Drawing.Size(116, 22);
            this.txtEmployeeListAutoSearch.TabIndex = 71;
            this.txtEmployeeListAutoSearch.TextChanged += new System.EventHandler(this.txtEmployeeListAutoSearch_TextChanged);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Password,
            this.Role});
            this.dgvEmployeeList.Location = new System.Drawing.Point(12, 290);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(889, 314);
            this.dgvEmployeeList.TabIndex = 70;
            this.dgvEmployeeList.DoubleClick += new System.EventHandler(this.dgvEmployeeList_DoubleClick);
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(137, 213);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(164, 28);
            this.txtRole.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(137, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 28);
            this.txtPassword.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(137, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 31);
            this.txtName.TabIndex = 19;
            // 
            // pnlTrainInfo
            // 
            this.pnlTrainInfo.BackColor = System.Drawing.Color.White;
            this.pnlTrainInfo.Controls.Add(this.panel1);
            this.pnlTrainInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrainInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlTrainInfo.Name = "pnlTrainInfo";
            this.pnlTrainInfo.Size = new System.Drawing.Size(913, 671);
            this.pnlTrainInfo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnShowDetails);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblSearchbyId);
            this.panel1.Controls.Add(this.txtEmployeeListAutoSearch);
            this.panel1.Controls.Add(this.dgvEmployeeList);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 671);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.Green;
            this.btnShowDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowDetails.Location = new System.Drawing.Point(436, 87);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(117, 55);
            this.btnShowDetails.TabIndex = 76;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(137, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 28);
            this.txtId.TabIndex = 18;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(23, 214);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(52, 21);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 21);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 21);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(23, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 21);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(741, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 53);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(592, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 53);
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
            this.btnClearAll.Location = new System.Drawing.Point(341, 213);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(88, 41);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // pnlEmployeeList
            // 
            this.pnlEmployeeList.Controls.Add(this.pnlTrainInfo);
            this.pnlEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeList.Name = "pnlEmployeeList";
            this.pnlEmployeeList.Size = new System.Drawing.Size(913, 671);
            this.pnlEmployeeList.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "User Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "User Name";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 671);
            this.Controls.Add(this.pnlEmployeeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployeeList_FormClosed);
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnlTrainInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEmployeeList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchbyId;
        private System.Windows.Forms.TextBox txtEmployeeListAutoSearch;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlTrainInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel pnlEmployeeList;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}