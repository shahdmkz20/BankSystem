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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

       

        private void dataBackUpBtn_Click(object sender, EventArgs e)
        {
            backUp_restoreData DBUform = new backUp_restoreData();
            DBUform.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Close();
        }


      

        private void chUsBtn_Click(object sender, EventArgs e)
        {
            userInfo userPermForm = new userInfo();
            userPermForm.Show();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            label1.Text = "WELCOME " +login.empName.ToUpper() +"!!";
        }

        private void adddbUserBtn_Click(object sender, EventArgs e)
        {
            add addDBuserForm = new add();
            addDBuserForm.Show();
        }
    }
}
