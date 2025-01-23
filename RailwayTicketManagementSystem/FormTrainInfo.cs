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
    public partial class FormTrainInfo : Form
    {
        private DataAccess Da { get; set; }
        private FormAdminDashboard FormAdmindashboard {  get; set; }
        private FormEmployeDashbord FormEmployebord {  get; set; }
        public FormTrainInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        //public FormTrainInfo(FormAdminDashboard formAdminDashboard) : this()
        //{
        //    this.FormAdmindashboard = formAdminDashboard;
        //}

        public FormTrainInfo(FormAdminDashboard adminDashboard) : this()
        {
            this.FormAdmindashboard = adminDashboard;
            this.AutoIdGenerate();
        }
        public FormTrainInfo(FormEmployeDashbord employeDashbord) : this()
        {
            this.FormEmployebord =   employeDashbord;
            this.AutoIdGenerate();
        }

        public FormTrainInfo(FormAdminDashboard adminDashboard, string trainId, string trainName, string fromStation, string toStation, string available, string price) : this()
        {
            this.FormAdmindashboard = adminDashboard;
            this.txtTrainId.Text = trainId;
            this.txtTrainName.Text = trainName;
            this.txtFrom.Text = fromStation;
            this.txtTo.Text = toStation;
            this.txtAvailable.Text = available;
            this.txtPrice.Text = price;
            this.txtTrainId.Enabled = false; // Disable editing TrainId
        }
        public FormTrainInfo(FormEmployeDashbord EDashboard, string trainId, string trainName, string fromStation, string toStation, string available, string price) : this()
        {
            this.FormEmployebord = EDashboard;
            this.txtTrainId.Text = trainId;
            this.txtTrainName.Text = trainName;
            this.txtFrom.Text = fromStation;
            this.txtTo.Text = toStation;
            this.txtAvailable.Text = available;
            this.txtPrice.Text = price;
            this.txtTrainId.Enabled = false; // Disable editing TrainId
        }

        private void PopulateGridView(string sql = "select* from TrainInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvTrainInfo.AutoGenerateColumns = false;
            this.dgvTrainInfo.DataSource = ds.Tables[0];

            this.dgvTrainInfo.ClearSelection();
            this.dgvTrainInfo.CurrentCell = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void ClearTextBoxOnly()
        {
            this.txtTrainName.Clear();
            this.txtFrom.Clear();
            this.txtTo.Clear();
            this.txtAvailable.Clear();
            this.txtPrice.Clear();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearTextBoxOnly();
        }

        private void AutoIdGenerate()
        {
            var query = "select max(TrainId) from TrainInfo;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var newId = "tr-" + (++num).ToString("d3");
            this.txtTrainId.Text = newId;
        }
        private void txtTrainId_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtTrainId.Text) || string.IsNullOrEmpty(this.txtTrainName.Text) ||
                string.IsNullOrEmpty(this.txtFrom.Text) || string.IsNullOrEmpty(this.txtTo.Text) || string.IsNullOrEmpty(this.txtAvailable.Text) || string.IsNullOrEmpty(this.txtPrice.Text))
                return false;
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from TrainInfo where TrainId = '" + this.txtTrainId.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    var sql = @"update TrainInfo
                set TrainName = '" + txtTrainName.Text + @"',
                FromStation = '" + txtFrom.Text + @"',
                ToStation = '" + txtTo.Text + @"',
                Available = '" + txtAvailable.Text + @"',
                Price = '" + Convert.ToDecimal(txtPrice.Text) + @"'
                where TrainId = '" + txtTrainId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    var sql = @"insert into TrainInfo values('" + this.txtTrainId.Text + "', '" + this.txtTrainName.Text + "', '" + this.txtFrom.Text + "', '" + this.txtTo.Text + "', '" + this.txtAvailable.Text + "', " + Convert.ToDecimal(this.txtPrice.Text) + "); ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }

                this.PopulateGridView();
                this.ClearTextBoxOnly();

                this.FormAdmindashboard.RefreshTrainListGrid();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from TrainInfo where TrainId like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvTrainInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void lblAvailable_Click(object sender, EventArgs e)
        {

        }

        private void txtAvailable_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddMsg_Click(object sender, EventArgs e)
        {

        }

        private void lblUpdateMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
