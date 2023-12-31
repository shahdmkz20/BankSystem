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
    public partial class deleteAccount : Form
    {
        public deleteAccount()
        {
            InitializeComponent();
        }
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=employee;password=1234";
        SqlConnection con = new SqlConnection(conStr);
        SqlConnection con2 = new SqlConnection(conStr);
      
        private void deleteAcc_Click(object sender, EventArgs e)
        {
            if (accNo.Text == "") {
                star.Visible = true;
            }
            else
            {
                star.Visible = false;
              

                //check if account is deleted.
                //if the account is deleted the command will not read records. 
                //so the reader will return zero and will go to the else statment.
                SqlCommand checkStatuscmd = new SqlCommand();
                checkStatuscmd.CommandText = "checkAccStatus";
                checkStatuscmd.CommandType = CommandType.StoredProcedure;
                checkStatuscmd.Connection = con;
                checkStatuscmd.Parameters.AddWithValue("@AccNo", int.Parse(accNo.Text));

                try
                {
                        con.Open();
                        SqlDataReader sdr = checkStatuscmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            SqlCommand sCmd = new SqlCommand();
                            sCmd.Connection = con2;
                            sCmd.CommandText = "DELETEACC";
                            sCmd.CommandType = CommandType.StoredProcedure;
                            sCmd.Parameters.AddWithValue("@ACC_NO", int.Parse(accNo.Text));
                            con2.Open();
                            sCmd.ExecuteNonQuery();
                            MessageBox.Show("account deleted succefully");
                            accNo.Text = "";

                        }
                    else
                    {
                        MessageBox.Show("No account with this number");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                    con2.Close();
                  
                }
            }
           
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
