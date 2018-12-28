using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Store
{
    public partial class EmployeeForm : Form
    {
        DBconnection db = new DBconnection();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            DataTable results;
            results = db.ViewEmployees();
            dataGrid.DataSource = results;
            deleteButton.Enabled = true;
            editButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Int32 rowCount = dataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (rowCount == 1)
            {
                string message = "Are you sure you want to delete\n";

                string id = Convert.ToString(dataGrid.SelectedRows[0].Cells["ID"].Value);
                string first = Convert.ToString(dataGrid.SelectedRows[0].Cells["First"].Value);
                string last = Convert.ToString(dataGrid.SelectedRows[0].Cells["Last"].Value);

                message = message + first + " " + last + "\nfrom the Music Store?\nTHIS ACTION CANNOT BE UNDONE!";
                DialogResult result = MessageBox.Show(message, "Delete Employee", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.DeleteEmployee(id);
                        DataTable results;
                        results = db.ViewEmployees();
                        dataGrid.DataSource = results;
                        MessageBox.Show(first + " " + last + " was removed from the Music Store.", "Success!");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Select ONE row to be deleted.", "Error");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Int32 rowCount = dataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (rowCount == 1)
            {
                string id = Convert.ToString(dataGrid.SelectedRows[0].Cells["ID"].Value);

                EditEmployee edit = new EditEmployee(id);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select ONE row to be edited.", "Error");
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}