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
        private string UserID { get; set; }
        public FormAdminDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.TrainListGridView();
            this.CartGridView();
            this.gdvTrainList.DataBindingComplete += gdvTrainList_DataBindingComplete;
            this.gdvTrainList.SelectionChanged += gdvTrainList_SelectionChanged_1;
            this.gdvCart.SelectionChanged += gdvCart_SelectionChanged_1;
        }

        public FormAdminDashboard(string info, string userId) : this()
        {
            this.lblWelcome.Text += info.ToUpper();
            this.UserID = userId;
        }

        private void TrainListGridView()
        {
            string sql = "select* from TrainInfo;";
            var ds = this.Da.ExecuteQuery(sql);

            this.gdvTrainList.AutoGenerateColumns = false;
            this.gdvTrainList.DataSource = ds.Tables[0];
        }

        private void CartGridView()
        {
            string sql = $"select * from CartView where UserId = '{ this.UserID }';";
            var ds = this.Da.ExecuteQuery(sql);

            this.gdvCart.AutoGenerateColumns = false;
            this.gdvCart.DataSource = ds.Tables[0];
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out from the system");
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            FormEmployeeList formEmployeeList = new FormEmployeeList(this); 
            formEmployeeList.Show(); 
            this.Hide();

        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gdvTrainList.SelectedRows.Count > 0)
                {
                    var selectedRow = this.gdvTrainList.CurrentRow;
                    var trainId = selectedRow.Cells["TrainId"].Value.ToString();

                    var query = $"SELECT COUNT(*) FROM TrainInfo WHERE TrainId = '{trainId}';";
                    var result = this.Da.ExecuteQueryTable(query);

                    if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
                    {
                        MessageBox.Show($"Train with ID {trainId} already exists in the TrainInfo table.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                FormTrainInfo formTrainInfo = new FormTrainInfo(this, this.UserID);
                formTrainInfo.ShowDialog();
                this.RefreshTrainListGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {

                if (gdvTrainList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to add in the cart!", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = this.gdvTrainList.CurrentRow;
                var trainId = selectedRow.Cells["TrainId"].Value.ToString(); 
                var trainName = selectedRow.Cells["TrainName"].Value.ToString(); 
                var fromStation = selectedRow.Cells["FromStation"].Value.ToString();
                var toStation = selectedRow.Cells["ToStation"].Value.ToString();
                var price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                var availability = selectedRow.Cells["Available"].Value.ToString();

                if(availability.ToLower() != "yes")
                {
                    MessageBox.Show("The train is not available!", "Unavailable Train", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbQuantity.SelectedItem == null)
                {
                    MessageBox.Show("Please select a quantity!", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantity = Convert.ToInt32(cmbQuantity.SelectedItem.ToString());
                decimal total = price * quantity;

                this.lblAmount.Text = total.ToString();

                this.gdvTrainList.ClearSelection();

                var sql = $"INSERT INTO CartView (TrainIdCart, TrainNameCart, FromStationCart, ToStationCart, PriceCart, UserId) VALUES ('{trainId}', '{trainName}', '{fromStation}', '{toStation}', {total}, '{this.UserID}');";
                var rowsAffected = Da.ExecuteDMLQuery(sql);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Informatoin added to the cart successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbQuantity.SelectedIndex = -1;
                    this.lblAmount.Text = "";
                    this.CartGridView(); 
                    this.gdvCart.ClearSelection();
                    
                }
                else
                {
                    MessageBox.Show("An error occurred while adding to cart. Please try again.", "Error", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("This Information Already Exist in the Cart!  "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gdvTrainList.ClearSelection();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.gdvCart.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to cancel", "Select a row first!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = this.gdvCart.CurrentRow;
                var invoiceNumber = selectedRow.Cells["InvoiceNumber"].Value.ToString();
                
                var confirmCancel = MessageBox.Show("Are you sure want to cancel the ticket?'", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmCancel == DialogResult.Yes)
                {
                    var deleteSql = $"DELETE FROM CartView WHERE InvoiceNumber = {invoiceNumber};";
                    var rowsAffected = Da.ExecuteDMLQuery(deleteSql);
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("The ticket is cancel from the cart successfully!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CartGridView();
                        this.gdvCart.ClearSelection();
                    }

                    else
                    {
                        return;
                    }
                }
                else
                {
                    return; 
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory(this, this.UserID);
            formHistory.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gdvCart.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to confirm!", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = this.gdvCart.CurrentRow;
                var invoiceNumber = selectedRow.Cells["InvoiceNumber"].Value.ToString();
                var trainId = selectedRow.Cells["TrainIdCart"].Value.ToString();
                var trainName = selectedRow.Cells["TrainNameCart"].Value.ToString();
                var fromStation = selectedRow.Cells["FromStationCart"].Value.ToString();
                var toStation = selectedRow.Cells["ToStationCart"].Value.ToString();
                var price = Convert.ToDecimal(selectedRow.Cells["PriceCart"].Value);
                var userId = selectedRow.Cells["UserId"].Value.ToString();

                var insertSql = $"INSERT INTO HistoryTable (TrainIdHistory, TrainNameHistory, FromStationHistory, ToStationHistory, PriceHistory, UserIdHistory) " +
                                $"VALUES ('{trainId}', '{trainName}', '{fromStation}', '{toStation}', {price}, '{userId}');";
                var rowsInserted = Da.ExecuteDMLQuery(insertSql);

                if (rowsInserted == 1)
                {
                    var deleteSql = $"DELETE FROM CartView WHERE InvoiceNumber = {invoiceNumber};";
                    var rowsDeleted = Da.ExecuteDMLQuery(deleteSql);

                    if (rowsDeleted == 1)
                    {
                        this.Da.ExecuteDMLQuery("DBCC CHECKIDENT('CartView', RESEED, 0);");
                        MessageBox.Show("The ticket has been confirmed and added to the history!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.CartGridView(); 
                        this.gdvCart.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove the ticket from the cart. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to confirm the ticket. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void RefreshTrainListGrid()
        {
            try
            {
                this.TrainListGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing train list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gdvTrainList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = this.gdvTrainList.CurrentRow;
                string trainId = selectedRow.Cells["TrainId"].Value.ToString();
                string trainName = selectedRow.Cells["TrainName"].Value.ToString();
                string fromStation = selectedRow.Cells["FromStation"].Value.ToString();
                string toStation = selectedRow.Cells["ToStation"].Value.ToString();
                string available = selectedRow.Cells["Available"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();

                FormTrainInfo formTrainInfo = new FormTrainInfo(this, trainId, trainName, fromStation, toStation, available, price, this.UserID);
                formTrainInfo.ShowDialog(); 

                this.RefreshTrainListGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                if (this.gdvTrainList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = this.gdvTrainList.CurrentRow;
                var trainId = selectedRow.Cells["TrainId"].Value.ToString();
                var trainName = selectedRow.Cells["TrainName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete Train: {trainName} (ID: {trainId})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var sql = $"DELETE FROM TrainInfo WHERE TrainId = '{trainId}';";
                    int rowsAffected = this.Da.ExecuteDMLQuery(sql);

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show($"Train {trainName} has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.RefreshTrainListGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the train record. Please try again.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the train record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void gdvTrainList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.gdvTrainList.ClearSelection();
        }

        private void gdvTrainList_SelectionChanged_1(object sender, EventArgs e)
        {
            if (gdvTrainList.SelectedRows.Count > 0)
            {
                gdvCart.ClearSelection();
            }

        }

        private void gdvCart_SelectionChanged_1(object sender, EventArgs e)
        {
            if (gdvCart.SelectedRows.Count > 0)
            {
                gdvTrainList.ClearSelection();
            }
        }

    }
}
