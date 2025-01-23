using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayTicketManagementSystem
{
    public partial class FormLogin : Form
    {
        private DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public string UserID
        {
            get { return this.txtUserId.Text; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill-up all the empty fields!");
                    return;
                }

                var sqlAdmin = $"SELECT * FROM AdminTable WHERE UserId = '{this.txtUserId.Text}' AND Password = '{this.txtPassword.Text}';";
                var sqlEmployee = $"SELECT * FROM EmployeeTable WHERE UserId = '{this.txtUserId.Text}' AND Password = '{this.txtPassword.Text}';";
                Da.ExecuteQuery(sqlAdmin);
                if (Da.Ds.Tables[0].Rows.Count == 1)
                {
                    string name = Da.Ds.Tables[0].Rows[0]["UserName"].ToString();
                    MessageBox.Show("Login Successful as Admin!");
                    this.Visible = false;
                    
                    new FormAdminDashboard(name, this.UserID).Show();
                    return;
                }

                Da.ExecuteQuery(sqlEmployee);

                Da.ExecuteQuery(sqlEmployee);
                if (Da.Ds.Tables[0].Rows.Count == 1)
                {
                    var name = Da.Ds.Tables[0].Rows[0]["UserName"].ToString();
                    MessageBox.Show("Login Successful as Employee!");
                    this.Visible = false;
                    //new FormEmployeeDashboard(name, this, UserId).Show();
                    return;
                }

                MessageBox.Show("Invalid User!");
                Da.Sqlcon.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred: " + exc.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            } 
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtPassword.Clear();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
