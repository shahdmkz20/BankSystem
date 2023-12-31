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
    public partial class makeBankTransfer : Form
    {
        public makeBankTransfer()
        {
            InitializeComponent();
        }
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=employee;password=1234";
        SqlConnection con = new SqlConnection(conStr);
        SqlConnection con2 = new SqlConnection(conStr);
        SqlConnection con3 = new SqlConnection(conStr);
        SqlConnection con4 = new SqlConnection(conStr);

        private void makeBankTransfer_Load(object sender, EventArgs e)
        {
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
           
            
            if (checkEmptyFields())
            {

                int from = int.Parse(fromAcc.Text);
                int to = int.Parse(toAcc.Text);
                int b = int.Parse(transferAmount.Text);
                //to check if from-account is active
                SqlCommand accStatus = new SqlCommand();
                accStatus.CommandText = "checkAccStatus";
                accStatus.Parameters.AddWithValue("@AccNo", from);
                accStatus.CommandType = CommandType.StoredProcedure;
                accStatus.Connection = con3;
                //to check if to-account is active
                SqlCommand acc2Status = new SqlCommand();
                acc2Status.CommandText = "checkAccStatus";
                acc2Status.Parameters.AddWithValue("@AccNo", to);
                acc2Status.CommandType = CommandType.StoredProcedure;
                acc2Status.Connection = con4;
                //to check if the balance of the account is enough to transfer
                SqlCommand checkEnoughMoney = new SqlCommand();
                checkEnoughMoney.CommandText = "checkIfAccHaveEnoughMoney";
                checkEnoughMoney.Parameters.AddWithValue("@acc_no", from);
                checkEnoughMoney.Parameters.AddWithValue("@amount", b);
                checkEnoughMoney.CommandType = CommandType.StoredProcedure;
                checkEnoughMoney.Connection = con2;
                //make transfer 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "MAKETRANSFER";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@FROMACC", from);
                cmd.Parameters.AddWithValue("@TOACC", to);
                cmd.Parameters.AddWithValue("@Balance", b);
                try
                {
                    con3.Open();
                    SqlDataReader sd = accStatus.ExecuteReader();
                    //from account is active
                    if (sd.Read())
                    {
                        con4.Open();
                        SqlDataReader sd2 = acc2Status.ExecuteReader();
                        //to account is active
                        if (sd2.Read())
                        {
                            con2.Open();
                            SqlDataReader sdr = checkEnoughMoney.ExecuteReader();
                            if (sdr.Read())
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("suceess");
                                fromAcc.Text = "";
                                toAcc.Text = "";
                                transferAmount.Text = "";

                            }
                            else
                            {
                                MessageBox.Show("no enough money in " + from + " account");
                            }
                        }
                        else
                            MessageBox.Show("account: " + to + " is not active");
                    }
                    else
                    {

                        MessageBox.Show("account: " + from + " is not active");
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
                    con3.Close();
                    con4.Close();
                }
            }

        }
        private bool checkEmptyFields()
        {
            star1.Visible = false;
            star1.Visible = false;
            star3.Visible = false;
            if (fromAcc.Text == "" || toAcc.Text == "" || transferAmount.Text == "")
            {
                if (fromAcc.Text == "")
                    star1.Visible = true;
                if (toAcc.Text == "")
                    star2.Visible = true;
                if (transferAmount.Text == "")
                    star3.Visible = true;
                return false;
            }
            else
                return true;
        }
    }
}
