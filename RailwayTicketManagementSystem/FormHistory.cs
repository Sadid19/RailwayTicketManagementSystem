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
    public partial class FormHistory : Form
    {
        private FormAdminDashboard FormAdmindashboard { get; set; }

        private FormEmployeDashbord FormEmployedashboard { get; set; }

        public FormHistory(DataAccess da, FormEmployeDashbord formEmployeDashboard)
        {
            InitializeComponent();
            this.FormEmployedashboard = formEmployeDashboard; // Assign the reference
            this.Da = da;
            this.FormEmployedashboard = formEmployeDashboard;
            string sql = "select * from HistoryTable;"; // Default query to load history data
            this.HistoryData(sql);
            this.gdvHistory.ClearSelection();
            this.gdvHistory.CurrentCell = null;
        }


        private string UserID{ get; set; }
        private DataAccess Da { get; set; }
        public FormHistory(DataAccess da, FormAdminDashboard formadminDashboard)
        {
            InitializeComponent();
            this.FormAdmindashboard = formadminDashboard;
            this.Da = da; 
            string sql = "select* from HistoryTable;";
            this.HistoryData(sql);
            this.gdvHistory.ClearSelection(); 
            this.gdvHistory.CurrentCell = null;
        }
       
        public FormHistory(DataAccess da,string id)
        {
            InitializeComponent();
            this.UserID = id;
            this.Da = da;
            string sql = "select* from HistoryTable where UserIdHistory = '" + this.UserID + "';";
            this.HistoryData(sql);
        }

        private void HistoryData(string sql)
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.gdvHistory.AutoGenerateColumns = false;
                this.gdvHistory.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading history data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            this.FormAdmindashboard.Show();
        }

        private void txtUserIDSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from HistoryTable where UserIdHistory like '" + this.txtUserIDSearch.Text + "%';";
            this.HistoryData(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteSql = "delete from HistoryTable;";
                var rowsAffected = this.Da.ExecuteDMLQuery(deleteSql);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("All history records have been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                var sql = "select * from HistoryTable;";
                this.HistoryData(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            this.FormEmployedashboard.Show();
        }
    }
}
