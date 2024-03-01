using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistratrionApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for(int days = 1; days <= 31; days++)
            {
                dayCombo.Items.Add(days.ToString());
            }

            for(int months = 1; months <= 12; months++)
            {
                monthCombo.Items.Add(months.ToString());
            }

            for(int year = 1900;  year <= 2024; year++)
            {
                yearCombo.Items.Add(year.ToString());
            }
        }
    }
}
