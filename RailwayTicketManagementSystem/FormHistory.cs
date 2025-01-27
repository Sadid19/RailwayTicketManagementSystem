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
        private FormEmployeDashbord FormEmployeedashboard { get; set; }
        private string UserID { get; set; }
        private DataAccess Da { get; set; }

        public FormHistory(FormEmployeDashbord formEmployeDashboard, string id)
        {
            InitializeComponent();
            this.FormEmployeedashboard = formEmployeDashboard;
            this.Da = new DataAccess();
            this.UserID = id;
            string sql = "select* from HistoryTable where UserIdHistory = '" + this.UserID + "';";
            this.SpecificUserHistoryData(sql);
            this.DeleteButtonVisibilityHandle();

        }

        public FormHistory(FormAdminDashboard formadminDashboard, string id)
        {
            InitializeComponent();
            this.FormAdmindashboard = formadminDashboard;
            this.Da = new DataAccess();
            this.UserID = id;
            this.HistoryData();
            this.gdvHistory.ClearSelection();
            this.gdvHistory.CurrentCell = null;
            this.DeleteButtonVisibilityHandle();
        }

        private void HistoryData(string sql = "select* from HistoryTable;")
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

        private void SpecificUserHistoryData(string sql)
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
            try
            {

                if (UserID[0] == 'a')
                {
                    this.Hide();
                    this.FormAdmindashboard.Show();

                }
                else if (UserID[0] == 'e')
                {
                    this.Hide();
                    this.FormEmployeedashboard.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while back button press!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserIDSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from HistoryTable where UserIdHistory like '" + this.txtUserIDSearch.Text + "%';";
            this.HistoryData(sql);
        }

        private void DeleteButtonVisibilityHandle()
        {
            try
            {
                if (this.UserID[0] == 'a' && this.UserID[0] != 'e')
                {
                    btnDelete.Visible = true;
                }
                else 
                {
                    btnDelete.Visible = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while hanlding the visbility of delete button!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteSql = "delete from HistoryTable;";
                var rowsAffected = this.Da.ExecuteDMLQuery(deleteSql);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("All history data have been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Application.Exit();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            this.gdvHistory.ClearSelection();
        }
    }
}
