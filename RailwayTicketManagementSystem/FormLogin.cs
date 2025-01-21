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

                var sql = "select* from UserInfo where Id='" + this.txtUserId.Text + "' and Password='" + this.txtPassword.Text + "';";
                Da.ExecuteQuery(sql);

                var name = Da.Ds.Tables[0].Rows[0][1].ToString();

                if (Da.Ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    
                    this.Visible = false;

                    if (Da.Ds.Tables[0].Rows[0]["Role"].ToString().Equals("admin"))
                    {
                        new FormAdminDashboard(name, this).Show();
                    }

                    else if (Da.Ds.Tables[0].Rows[0]["Role"].ToString().Equals("employee"))
                    {
                        //new EmployeForm(name, this).Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid User!");
                }
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
    }
}
