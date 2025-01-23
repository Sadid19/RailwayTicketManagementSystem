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
        private DataAccess Da { get; set; }
        public FormHistory(DataAccess da)
        {
            InitializeComponent();
            this.Da = da;
            this.HistoryData();
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserIDSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from HistoryTable where UserIdHistory like '" + this.txtUserIDSearch.Text + "%';";
            this.HistoryData(sql);
        }
    }
}
