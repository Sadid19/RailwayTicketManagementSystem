namespace RailwayTicketManagementSystem
{
    partial class FormEmployeeDashboard
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
            this.lblWelcomeOutput = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbChooseClass = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblChooseClass = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTrainInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTrainList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPassenegerPhoneNumber = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTrainList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnTrainInfo);
            this.panel1.Controls.Add(this.lblWelcomeOutput);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 580);
            this.panel1.TabIndex = 0;
            // 
            // lblWelcomeOutput
            // 
            this.lblWelcomeOutput.AutoSize = true;
            this.lblWelcomeOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeOutput.ForeColor = System.Drawing.Color.Green;
            this.lblWelcomeOutput.Location = new System.Drawing.Point(96, 11);
            this.lblWelcomeOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeOutput.Name = "lblWelcomeOutput";
            this.lblWelcomeOutput.Size = new System.Drawing.Size(129, 16);
            this.lblWelcomeOutput.TabIndex = 3;
            this.lblWelcomeOutput.Text = "Welcome Output";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Green;
            this.lblWelcome.Location = new System.Drawing.Point(16, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(79, 16);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome,";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Dhaka",
            "Rajshahi",
            "Chittagong",
            "Khulna",
            "Sirajgonj",
            "Cumilla"});
            this.comboBox3.Location = new System.Drawing.Point(230, 24);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(109, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // cmbChooseClass
            // 
            this.cmbChooseClass.FormattingEnabled = true;
            this.cmbChooseClass.Items.AddRange(new object[] {
            "AC_B",
            "AC_S",
            "S_Chair",
            "Snigdha"});
            this.cmbChooseClass.Location = new System.Drawing.Point(471, 24);
            this.cmbChooseClass.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChooseClass.Name = "cmbChooseClass";
            this.cmbChooseClass.Size = new System.Drawing.Size(109, 21);
            this.cmbChooseClass.TabIndex = 12;
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "Dhaka",
            "Rajshahi",
            "Chittagong",
            "Khulna",
            "Sirajgonj",
            "Cumilla"});
            this.cmbFrom.Location = new System.Drawing.Point(60, 24);
            this.cmbFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(109, 21);
            this.cmbFrom.TabIndex = 11;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Green;
            this.lblTo.Location = new System.Drawing.Point(199, 24);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 16);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "To";
            // 
            // lblChooseClass
            // 
            this.lblChooseClass.AutoSize = true;
            this.lblChooseClass.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseClass.ForeColor = System.Drawing.Color.Green;
            this.lblChooseClass.Location = new System.Drawing.Point(362, 24);
            this.lblChooseClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseClass.Name = "lblChooseClass";
            this.lblChooseClass.Size = new System.Drawing.Size(105, 16);
            this.lblChooseClass.TabIndex = 9;
            this.lblChooseClass.Text = "Choose Class";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Green;
            this.lblFrom.Location = new System.Drawing.Point(11, 24);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(45, 16);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Green;
            this.btnLogOut.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Location = new System.Drawing.Point(1017, 13);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 44);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnTrainInfo
            // 
            this.btnTrainInfo.BackColor = System.Drawing.Color.Green;
            this.btnTrainInfo.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnTrainInfo.Location = new System.Drawing.Point(911, 13);
            this.btnTrainInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrainInfo.Name = "btnTrainInfo";
            this.btnTrainInfo.Size = new System.Drawing.Size(86, 44);
            this.btnTrainInfo.TabIndex = 14;
            this.btnTrainInfo.Text = "Train Information";
            this.btnTrainInfo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(584, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date of Journey";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(724, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblFrom);
            this.panel2.Controls.Add(this.lblChooseClass);
            this.panel2.Controls.Add(this.lblTo);
            this.panel2.Controls.Add(this.cmbFrom);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.cmbChooseClass);
            this.panel2.Location = new System.Drawing.Point(19, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 100);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(3, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 225);
            this.panel3.TabIndex = 20;
            // 
            // lblTrainList
            // 
            this.lblTrainList.AutoSize = true;
            this.lblTrainList.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainList.ForeColor = System.Drawing.Color.Green;
            this.lblTrainList.Location = new System.Drawing.Point(487, 222);
            this.lblTrainList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainList.Name = "lblTrainList";
            this.lblTrainList.Size = new System.Drawing.Size(79, 16);
            this.lblTrainList.TabIndex = 21;
            this.lblTrainList.Text = "Train List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1113, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(2, 67);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 16);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 25;
            // 
            // lblPassenegerPhoneNumber
            // 
            this.lblPassenegerPhoneNumber.AutoSize = true;
            this.lblPassenegerPhoneNumber.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassenegerPhoneNumber.ForeColor = System.Drawing.Color.Green;
            this.lblPassenegerPhoneNumber.Location = new System.Drawing.Point(2, 18);
            this.lblPassenegerPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassenegerPhoneNumber.Name = "lblPassenegerPhoneNumber";
            this.lblPassenegerPhoneNumber.Size = new System.Drawing.Size(161, 16);
            this.lblPassenegerPhoneNumber.TabIndex = 24;
            this.lblPassenegerPhoneNumber.Text = "Passenger Phone No.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dhaka",
            "Rajshahi",
            "Chittagong",
            "Khulna",
            "Sirajgonj",
            "Cumilla"});
            this.comboBox1.Location = new System.Drawing.Point(413, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Green;
            this.lblQuantity.Location = new System.Drawing.Point(342, 16);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 16);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(805, 520);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(964, 520);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPassenegerPhoneNumber);
            this.panel4.Controls.Add(this.lblQuantity);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(4, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 87);
            this.panel4.TabIndex = 29;
            // 
            // FormEmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcomeOutput;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cmbChooseClass;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblChooseClass;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTrainInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTrainList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassenegerPhoneNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}