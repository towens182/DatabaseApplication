using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Music_Store
{
    public partial class HiringForm : Form
    {
        MyRegex myRegex = new MyRegex();
        DBconnection db = new DBconnection();

        double clerkPay = 10.00;
        double janitorPay = 11.00;
        double amPay = 16.50;
        double manPay = 20.00;
        double selectedPay = 0;
        List<string> myList = new List<string>();
        List<string> jobList = new List<string>();
        List<string> storeList = new List<string>();

        public HiringForm()
        {
            InitializeComponent();

            db.FillDepartmentName(departmentSelect, myList);
            db.FillJobTitles(jobSelect, jobList);
            db.FillStores(storeSelect, storeList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";

            if (myRegex.AcceptName(firstNameText.Text) == true
                && myRegex.AcceptName(lastNameText.Text) == true
                && myRegex.AcceptPhone(phoneText.Text) == true
                && addressText.Text != ""
                && departmentSelect.SelectedIndex != -1
                && jobSelect.SelectedIndex != -1
                && storeSelect.SelectedIndex != -1)
            {
                try
                {
                    db.AddEmployee(lastNameText.Text, firstNameText.Text, addressText.Text, myRegex.GetPhone(phoneText.Text),
                        calendar.SelectionStart.Date.ToString("yyyy-MM-dd"), departmentSelect.Text, selectedPay, storeSelect.Text, jobSelect.Text);

                    //Show success message box
                    MessageBox.Show("Congratulate " + firstNameText.Text + " " + lastNameText.Text
                            + " on joining the Music Store!", "Success!");


                    //Clear all field values to allow additional entries
                    firstNameText.Clear();
                    lastNameText.Clear();
                    addressText.Clear();
                    phoneText.Clear();
                    departmentSelect.SelectedIndex = -1;
                    jobSelect.SelectedIndex = -1;
                    storeSelect.SelectedIndex = -1;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
            else
            {
                //check for errors in labels highlight the errors then display
                if (myRegex.AcceptName(firstNameText.Text) == false)
                {
                    firstNameText.BackColor = Color.Red;
                    error = error + "First Name not valid entry.\n";
                };
                if (myRegex.AcceptName(lastNameText.Text) == false)
                {
                    lastNameText.BackColor = Color.Red;
                    error = error + "Last Name not valid entry.\n";
                }
                if (myRegex.AcceptPhone(phoneText.Text) == false)
                {
                    phoneText.BackColor = Color.Red;
                    error = error + "Phone Number not valid entry.\n";
                }
                if (addressText.Text == "")
                {
                    addressText.BackColor = Color.Red;
                    error = error + "Please enter an address.\n";
                }
                if (departmentSelect.SelectedIndex == -1 ||
                 jobSelect.SelectedIndex == -1 ||
                 storeSelect.SelectedIndex == -1)
                {
                    error = error + "Please make dropdown selections.\n";
                }
                MessageBox.Show(error, "Error");
            }
        }

        private void jobSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jobSelect.SelectedIndex == -1)
            {
                wageDisplay.Text = "";
                departmentSelect.Enabled = true;
                selectedPay = 0;
            }
            else if (jobSelect.Items[jobSelect.SelectedIndex].ToString() == "Clerk")
            {
                wageDisplay.Text = "$" + String.Format("{0:F2}", clerkPay);
                selectedPay = clerkPay;
            }
            else if (jobSelect.Items[jobSelect.SelectedIndex].ToString() == "Custodian")
            {
                wageDisplay.Text = "$" + String.Format("{0:F2}", janitorPay);
                selectedPay = janitorPay;
            }
            else if (jobSelect.Items[jobSelect.SelectedIndex].ToString() == "Assistant Manager")
            {
                wageDisplay.Text = "$" + String.Format("{0:F2}", amPay);
                selectedPay = amPay;
            }
            else if (jobSelect.Items[jobSelect.SelectedIndex].ToString() == "Manager")
            {
                wageDisplay.Text = "$" + String.Format("{0:F2}", manPay);
                selectedPay = manPay;
            }
            else
            {
                wageDisplay.Text = "";
                departmentSelect.Enabled = true;
                selectedPay = 0;
            }
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            firstNameText.BackColor = Color.White;
        }

        private void addressText_TextChanged(object sender, EventArgs e)
        {
            addressText.BackColor = Color.White;
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            lastNameText.BackColor = Color.White;
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            phoneText.BackColor = Color.White;
        }

        private void HiringForm_Load(object sender, EventArgs e)
        {

        }
    }
}
