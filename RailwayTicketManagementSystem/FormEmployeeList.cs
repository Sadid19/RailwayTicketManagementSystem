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
    public partial class FormEmployeeList : Form
    {
        private DataAccess Da { get; set; }
        private FormAdminDashboard FormAdmindashboard {  get; set; }
        public FormEmployeeList()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            //this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select* from EmployeeTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployeeList.AutoGenerateColumns = false;
            this.dgvEmployeeList.DataSource = ds.Tables[0];
        }
        public FormEmployeeList(FormAdminDashboard formAdminDashboard) : this() 
        {
            this.FormAdmindashboard = formAdminDashboard;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtRole.Clear();
            this.txtSalary.Clear();

            this.txtEmployeeListAutoSearch.Clear();
            this.dgvEmployeeList.ClearSelection();

            this.AutoIdGenerate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployeeList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgvEmployeeList.CurrentRow.Cells[0].Value.ToString();
                var username = this.dgvEmployeeList.CurrentRow.Cells[1].Value.ToString();


                DialogResult result = MessageBox.Show("Are you sure you want to delete " + username + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                var sql = "delete from EmployeeTable where UserId ='" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(username + " has been removed from the list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Data hasn't been removed properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.PopulateGridView();
                //this.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }

        private void txtEmployeeListAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from EmployeeTable where UserId like '"+ this.txtEmployeeListAutoSearch.Text +"%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtId.Text = this.dgvEmployeeList.CurrentRow.Cells["UserId"].Value.ToString();
                this.txtName.Text = this.dgvEmployeeList.CurrentRow.Cells["UserName"].Value.ToString();
                this.txtPassword.Text = this.dgvEmployeeList.CurrentRow.Cells["Password"].Value.ToString();
                this.txtRole.Text = this.dgvEmployeeList.CurrentRow.Cells["Role"].Value.ToString();
                this.txtSalary.Text = this.dgvEmployeeList.CurrentRow.Cells["Salary"].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtRole.Text) || string.IsNullOrEmpty(this.txtSalary.Text))
                return false;
            else
                return true;
        }

        private void ClearTextBoxOnly()
        {
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtRole.Clear();
            this.txtSalary.Clear();
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

                var query = "select * from EmployeeTable where UserId = '" + this.txtId.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update EmployeeTable
                        set UserName = '" + txtName.Text + @"',
                        Password = '" + txtPassword.Text + @"',
                        Role = '" + txtRole.Text + @"',
                        Salary = " + Convert.ToInt32(txtSalary.Text) + @"
                        where UserId = '" + txtId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);


                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                    
                }
                else
                {
                    //insert
                    var sql = "insert into EmployeeTable values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtRole.Text + "', " + Convert.ToInt32(this.txtSalary.Text) + ");";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }

                this.PopulateGridView();
                this.ClearTextBoxOnly();
               
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: " + exc.Message);
            }
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            this.dgvEmployeeList.ClearSelection();
            this.AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var query = "select max(UserId) from EmployeeTable;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var newId = "e-" + (++num).ToString("d3");
            this.txtId.Text = newId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            FormAdmindashboard.Show();
            this.Hide();

        }

        private void FormEmployeeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
