using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SDB_HW
{
    public partial class employeePanel : Form
    {
        public employeePanel()
        {
            InitializeComponent();
        }
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=employee;password=1234";
        SqlConnection con = new SqlConnection(conStr);

        private void userPanel_Load(object sender, EventArgs e)
        {
            label1.Text = "WELCOME " +login.empName.ToUpper() + "!!";
            SqlCommand checkCmd = new SqlCommand();
            checkCmd.Connection = con;
            checkCmd.CommandText = "getPerm";
            checkCmd.CommandType = CommandType.StoredProcedure;
            checkCmd.Parameters.AddWithValue("@empID", login.userName);
            try
            {
                con.Open();
                SqlDataReader sqlReader = checkCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    //gets the permessions of the employee from the stored proc getPerm
                    makeStatement.Enabled = Convert.ToBoolean(sqlReader[0]);
                    openNewAccount.Enabled = Convert.ToBoolean(sqlReader[1]);
                    makeTransferBtn.Enabled = Convert.ToBoolean(sqlReader[3]);
                    closeAccBtn.Enabled = Convert.ToBoolean(sqlReader[2]);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Close();
        }

        private void makeTransferBtn_Click(object sender, EventArgs e)
        {
            makeBankTransfer mkForm = new makeBankTransfer();
            mkForm.Show();
        }

        private void closeAccBtn_Click(object sender, EventArgs e)
        {
            deleteAccount delForm = new deleteAccount();
            delForm.Show();
        }

        private void openNewAccount_Click(object sender, EventArgs e)
        {
            createAccount addForm = new createAccount();
            addForm.Show();
        }

        private void makeStatement_Click(object sender, EventArgs e)
        {
            enterAccNo enterAccNoForm = new enterAccNo();
            enterAccNoForm.Show();
        }
    }
}
