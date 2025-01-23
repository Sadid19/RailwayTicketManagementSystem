﻿using System;
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
            this.gdvCart.SelectionChanged += new EventHandler(GdvCart_SelectionChanged);
            this.gdvTrainList.SelectionChanged += new EventHandler(GdvTrainList_SelectionChanged);
        }

        public FormAdminDashboard(string info, string userId) : this()
        {
            this.lblWelcome.Text += info.ToUpper();
            this.UserID = userId;
        }
        private void gdvTrainList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.gdvTrainList.ClearSelection();
        }

        private void GdvTrainList_SelectionChanged(object sender, EventArgs e)
        {

            if (gdvTrainList.SelectedRows.Count > 0)
            {
                gdvCart.ClearSelection();
            }
        }
        private void GdvCart_SelectionChanged(object sender, EventArgs e)
        {

            if (gdvCart.SelectedRows.Count > 0)
            {
                gdvTrainList.ClearSelection();
            }
        }

        private void TrainListGridView(string sql = "select* from TrainInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.gdvTrainList.AutoGenerateColumns = false;
            this.gdvTrainList.DataSource = ds.Tables[0];

            this.gdvTrainList.ClearSelection();
            this.gdvTrainList.CurrentCell = null;


        }

        private void CartGridView(string sql = "select* from CartView;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.gdvCart.AutoGenerateColumns = false;
            this.gdvCart.DataSource = ds.Tables[0];
        }


        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void pnlAdminDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out from the system");
            this.Hide();
            //this.FormLogin.Show();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
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

        

        private void btnAddTrain_Click(object sender, EventArgs e)
        {

        }

        private void dgvTrainList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                this.lblTotalOutput.Text = total.ToString();

                this.gdvTrainList.ClearSelection();

                var sql = $"INSERT INTO CartView (TrainIdCart, TrainNameCart, FromStationCart, ToStationCart, PriceCart, UserId) VALUES ('{trainId}', '{trainName}', '{fromStation}', '{toStation}', {total}, '{this.UserID}');";
                var rowsAffected = Da.ExecuteDMLQuery(sql);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Informatoin added to the cart successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cmbQuantity.SelectedIndex = -1;
                    this.lblTotalOutput.Text = "";
                    this.CartGridView(); // Refresh cart view
                    this.gdvCart.ClearSelection();
                    
                }
                else
                {
                    MessageBox.Show("An error occurred while adding to cart. Please try again.", "Error", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("This Information Already Exist in the Cart!  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gdvTrainList.ClearSelection();

        }

        private void gdvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {

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
                        //MessageBox.Show("Failed to cancel the ticket. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to cancel the ticket. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
