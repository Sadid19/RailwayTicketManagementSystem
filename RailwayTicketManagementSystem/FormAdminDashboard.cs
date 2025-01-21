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
    public partial class FormAdminDashboard : Form
    {
        private DataAccess Da { get; set; }
        private FormLogin FormLogin {  get; set; }
        public FormAdminDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        
        public FormAdminDashboard(string info, FormLogin formLogin) : this()
        {
            this.lblWelcome.Text += info.ToUpper();
            this.FormLogin = formLogin;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlAdminDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out from the system");
            this.Hide();
            this.FormLogin.Show();
        }

        private void FormAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTrainInfo_Click(object sender, EventArgs e)
        {
             new FormTrainInfo(this).Show();           
             this.Visible = false;

        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            new FormEmployeeList(this).Show();
            this.Visible = false;
            
        }
    }
}
