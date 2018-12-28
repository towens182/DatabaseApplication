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
    public partial class StoreForm : Form
    {
        DBconnection db = new DBconnection();

        List<string> storeList = new List<string>();

        public StoreForm()
        {
            InitializeComponent();
            db.FillStores(storeSelect, storeList);
        }

        private void storeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] location = storeSelect.Text.Split(new string[] { ", " }, StringSplitOptions.None);
            DataSet ds, empDS;
            int id;
            id = db.GetStoreID(location[0], location[1]);
            ds = db.GetStoreDetails(id);
            empDS = db.GetTopEmployeeDetails(id.ToString());
            fillDetails(ds, empDS, id.ToString());
        }

        private void fillDetails(DataSet ds, DataSet empDS, String storeId)
        {
            String city, state, manager, phone;
            city = ds.Tables[0].Rows[0]["city"].ToString();
            state = ds.Tables[0].Rows[0]["state"].ToString();
            manager = ds.Tables[0].Rows[0]["first_name"].ToString() + " " + ds.Tables[0].Rows[0]["last_name"].ToString();
            phone = ds.Tables[0].Rows[0]["phone_number"].ToString().Insert(3, "-");

            storeIdLabel.Text = ds.Tables[0].Rows[0]["store_id"].ToString();
            locationLabel.Text = GetStoreName(city, state);
            phoneLabel.Text = phone;
            managerLabel.Text = manager;
            numEmployeeLabel.Text = ds.Tables[0].Rows[0]["numEmp"].ToString();
            avgTenureLabel.Text = ds.Tables[0].Rows[0]["avgTenure"].ToString() + " years";
            avgWageLabel.Text = "$" + String.Format("{0:F2}", ds.Tables[0].Rows[0]["avgWage"]);

            //Sales details
            String numSales, employee;

            expensiveItemLabel.Text = db.GetInstrumentSoldName(storeId);
            employee = empDS.Tables[0].Rows[0]["first_name"].ToString() + " " + empDS.Tables[0].Rows[0]["last_name"].ToString();
            topEmpLabel.Text = employee;

            numSales = empDS.Tables[0].Rows[0]["count"].ToString();
            numSalesLabel.Text = numSales;
            if (numSales.Length == 0)
            {
                numSalesLabel.Text = "0";
            }
        }

        public string GetStoreName(string city, string state)
        {
            return city + ", " + state;
        }
    }

}
