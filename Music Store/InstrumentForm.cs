using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Music_Store
{
    public partial class InstrumentForm : Form
    {
        DBconnection db = new DBconnection();
        List<string> myList = new List<string>();
        List<string> colorList = new List<string>();

        public InstrumentForm()
        {
            InitializeComponent();
            db.FillDepartmentInstrumentPage(departments, myList);
            db.FillColors(colorSelect, colorList);
            maxPrice.Maximum = db.FillPrice();
            maxPrice.Value = maxPrice.Maximum;
            maxLabel.Text = maxPrice.Value.ToString("C");
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable results;
                results = db.SearchInstruments(buildQuery(searchText.Text, departments.Text, colorSelect.Text, maxPrice.Value));
                dataGrid.DataSource = results;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
            }
            Int32 rowCount = dataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (rowCount == 0)
            {
                MessageBox.Show("No results found.");
            }
        }
        private void departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            getButton.Enabled = true;
        }

        private void maxPrice_Scroll(object sender, EventArgs e)
        {
            maxLabel.Text = maxPrice.Value.ToString("C");
        }

        private string buildQuery(string search, string dep, string color, int max)
        {
            string query = "WHERE ";

            if (search.Length > 0)
            {
                query = query + "(instrument.make LIKE \"%" + search + "%\" || instrument.model LIKE \"%" + search + "\")";
            }

            if (dep != "All")
            {
                if (search.Length > 0) { query = query + " && "; };
                query = query + "department.name =\"" + dep + "\"";
            }

            if (color != "All")
            {
                if (search.Length > 0 || dep != "All") { query = query + " && "; };
                query = query + "instrument.color =\"" + color + "\"";
            }
            if (search.Length > 0 || dep != "All" || color != "All") { query = query + " && "; };

            query = query + "instrument.price <=" + max + ";";

            return query;
        }

        private void InstrumentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
