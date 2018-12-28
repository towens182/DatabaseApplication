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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void hiringButton_Click(object sender, EventArgs e)
        {
            HiringForm hiringForm = new HiringForm();
            hiringForm.Show(this);
        }

        private void instrumentButton_Click(object sender, EventArgs e)
        {
            InstrumentForm instrumentForm = new InstrumentForm();
            instrumentForm.Show(this);
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show(this);
        }

        private void storePerformance_Click(object sender, EventArgs e)
        {
            StoreForm storeForm = new StoreForm();
            storeForm.Show(this);
        }
    }
}
