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
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=employee;password=1234";
        SqlConnection con = new SqlConnection(conStr);
        SqlConnection con2 = new SqlConnection(conStr);

        private void addUser_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields())
            {
                //check if custmer exists
                SqlCommand checkCus = new SqlCommand();
                checkCus.Connection = con2;
                checkCus.CommandText = "cusExists";
                checkCus.CommandType = CommandType.StoredProcedure;
                checkCus.Parameters.AddWithValue("@cus_ID",cus_ID.Text);
                try
                {
                    con2.Open();
                    SqlDataReader sdr = checkCus.ExecuteReader();
                    //if the reader read a record that means that the custmer exists.
                    if (sdr.Read())
                    {

                        SqlCommand sCmd = new SqlCommand();
                        sCmd.Connection = con;
                        sCmd.CommandText = "addNewAcc";
                        sCmd.CommandType = CommandType.StoredProcedure;
                        sCmd.Parameters.AddWithValue("@CusID", cus_ID.Text);
                        sCmd.Parameters.AddWithValue("@Openbalance", int.Parse(OpenBalance.Text));
                        sCmd.Parameters.AddWithValue("@employeeID", login.userName);
                        try
                        {
                            con.Open();
                            //create new account
                            sCmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("account created succefully");
                            cus_ID.Text = "";
                            OpenBalance.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("this custmer ID is not in the database ..");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            con.Close();
            con2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool checkEmptyFields()
        {
            star1.Visible = false;
            star2.Visible = false;
            if (cus_ID.Text == "" || OpenBalance.Text == "")
            {
                if (cus_ID.Text == "")
                    star1.Visible = true;
                if (OpenBalance.Text == "")
                    star2.Visible = true;
                return false;
            }
            else
                return true;
        }
    }
}
