using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDB_HW
{
    public partial class enterAccNo : Form
    {
        public enterAccNo()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int accNo;
        public static DateTime fromDate;
        public static DateTime toDate;
        private void makeStateBTN_Click(object sender, EventArgs e)
        {
            //set the variables it's values to pass them to the statment form.
            accNo = int.Parse(acc_no.Text);
            fromDate = dateTimePicker1.Value.Date;
            toDate = dateTimePicker2.Value.Date;
            
            
            makeStatmentForm stForm = new makeStatmentForm();
            stForm.Show();
        }
    }
}
