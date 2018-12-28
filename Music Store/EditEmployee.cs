using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Music_Store
{
    public partial class EditEmployee : Form
    {
        private string empId;
        MyRegex myRegex = new MyRegex();
        DBconnection db = new DBconnection();

        List<string> myList = new List<string>();
        List<string> jobList = new List<string>();
        List<string> storeList = new List<string>();

        String first = null;
        String last = null;
        String address = null;
        String phone = null;
        String job = null;
        String wage = null;
        String department = null;
        String store = null;

        public EditEmployee(string id)
        {
            InitializeComponent();
            empId = id;

            db.FillDepartmentName(departmentSelect, myList);
            db.FillJobTitles(jobSelect, jobList);
            db.FillStores(storeSelect, storeList);

            //Get employee data and populate the form
            FillFields(db.GetEmployeeInfo(empId));
        }

        public void FillFields(DataSet person)
        {
            lastNameText.Text = person.Tables[0].Rows[0]["Last"].ToString();
            firstNameText.Text = person.Tables[0].Rows[0]["First"].ToString();
            addressText.Text = person.Tables[0].Rows[0]["Address"].ToString(); ;
            phoneText.Text = person.Tables[0].Rows[0]["Phone"].ToString();
            wageText.Text = person.Tables[0].Rows[0]["Wage"].ToString();
            hireDateText.Text = person.Tables[0].Rows[0]["Hire"].ToString();
            dobText.Text = person.Tables[0].Rows[0]["DOB"].ToString();
            jobSelect.SelectedItem = person.Tables[0].Rows[0]["Job"].ToString(); ;
            storeSelect.SelectedItem = GetStoreName(person.Tables[0].Rows[0]["City"].ToString(), person.Tables[0].Rows[0]["State"].ToString());
            departmentSelect.SelectedItem = person.Tables[0].Rows[0]["Department"].ToString();
        }

        public string getUpdateString()
        {
            String update = null;
            List<string> list = new List<string>();

            if (first != null) { list.Add(first); }
            if (last != null) { list.Add(last); }
            if (address != null) { list.Add(address); }
            if (phone != null) { list.Add(phone); }
            if (job != null) { list.Add(job); }
            if (wage != null) { list.Add(wage); }
            if (department != null) { list.Add(department); }
            if (store != null) { list.Add(store); }

            if(list.Count > 0) { update = "SET "; }

            for(int i = 0; i < list.Count; i++)
            {
                update = update + list[i];
                if(list[i] != list.Last()) { update = update + ","; }
            }
            return update;
        }

        public string GetStoreName(string city, string state)
        {
            return city + ", " + state;
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            first = "first_name=\"" + firstNameText.Text + "\"";
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            last = "last_name=\"" + lastNameText.Text + "\"";
        }

        private void addressText_TextChanged(object sender, EventArgs e)
        {
            address = "address=\"" + addressText.Text + "\"";
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            phone = "phone_number=\"" + phoneText.Text + "\"";
        }

        private void wageText_TextChanged(object sender, EventArgs e)
        {
            wage = "wage=\"" + wageText.Text + "\"";
        }

        private void jobSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            job = "job_title=\"" + db.GetJobId(jobSelect.Text) + "\"";
        }

        private void departmentSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            department = "department_name=\"" + db.GetDepId(departmentSelect.Text) + "\"";
        }

        private void storeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] location = storeSelect.Text.Split(new string[] { ", " }, StringSplitOptions.None);

            store = "store_id=\"" + db.GetStoreID(location[0], location[1]) + "\"";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateEmployee(getUpdateString(), empId);
                DialogResult result =  MessageBox.Show("Success!", "Music Store", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
