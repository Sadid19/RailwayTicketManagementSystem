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
    public partial class FormTrainInfo : Form
    {
        private DataAccess Da { get; set; }
        private FormAdminDashboard FormAdmindashboard {  get; set; }
        public FormTrainInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        
        public FormTrainInfo(FormAdminDashboard formAdminDashboard) : this()
        {
            this.FormAdmindashboard = formAdminDashboard;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void FormTrainInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.FormAdmindashboard.Show();
        }

        private void lblTotalSeat_Click(object sender, EventArgs e)
        {

        }

        private void pnlFormTrainInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
