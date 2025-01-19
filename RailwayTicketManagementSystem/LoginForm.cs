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
using System.Xml.Linq;

namespace RailwayTicketManagementSystem
{
    public partial class LoginForm : Form
    {
        private DataAccess Da { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
   

        private void pbLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fillup all the empty fields");
                    return;
                }

                var sql = "select* from UserInfo where Id='" + this.txtUserId.Text + "' and Password='" + this.txtPassword.Text + "';";
                Da.ExecuteQuery(sql);

                //var name = Da.Ds.Tables[0].Rows[0][1].ToString();

                if (Da.Ds.Tables[0].Rows.Count == 1)
                {
                    //this.Visible = false;
                    MessageBox.Show("Login Successful!");

                    if(Da.Ds.Tables[0].Rows[0]["Role"].ToString().Equals("admin"))
                    {
                        //new AdminForm(name, this).Show();
                    }

                    else if(Da.Ds.Tables[0].Rows[0]["Role"].ToString().Equals("employee"))
                    {
                        //new EmployeForm(name, this).Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid User!");
                }

            }
            catch(Exception exc)
            {

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtPassword.Clear();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
