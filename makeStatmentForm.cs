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
    public partial class makeStatmentForm : Form
    {
        public makeStatmentForm()
        {
            InitializeComponent();
        }
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=employee;password=1234";
        SqlConnection con = new SqlConnection(conStr);
        SqlConnection con2 = new SqlConnection(conStr);
        SqlConnection con3 = new SqlConnection(conStr);
        public string cus_accNo;

        private void makeStatmentForm_Load(object sender, EventArgs e)
        {
            //check if the account exists.
            SqlCommand checkAcc = new SqlCommand();
            checkAcc.Connection = con3;
            checkAcc.CommandText = "checkAcc";
            checkAcc.CommandType = CommandType.StoredProcedure;
            checkAcc.Parameters.AddWithValue("@acc_no", enterAccNo.accNo);
            
            try
            {
                con3.Open();
                SqlDataReader sdd = checkAcc.ExecuteReader();
                //if the reader read a column then an account with this number exists.
                if (sdd.Read())
                {
                    SqlCommand sCmd = new SqlCommand();
                    sCmd.Connection = con;
                    sCmd.CommandText = "makeStatement";
                    sCmd.CommandType = CommandType.StoredProcedure;
                    sCmd.Parameters.AddWithValue("@acc_no", enterAccNo.accNo);
                    con.Open();
                    try
                    {
                        
                        SqlDataReader sdr = sCmd.ExecuteReader();
                        //get the information from the record.
                        while (sdr.Read())
                        {
                            cusName.Text = sdr[0].ToString();
                            branch.Text = sdr[1].ToString();
                            openBalance.Text = sdr[2].ToString();
                            openDate.Text = sdr[3].ToString();
                            accNo.Text = sdr[4].ToString();
                            currentBalance.Text = sdr[5].ToString();
                            stateDate.Text = DateTime.Now.ToShortDateString();
                            empName.Text = sdr[7].ToString();
                            if (Convert.ToBoolean(sdr[6]))
                                accStatus.Text = "active";
                            else
                                accStatus.Text = "not active";

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                    //create command the get transfer details by specified date.
                    SqlCommand sf = new SqlCommand();
                    sf.CommandText = "getTransByDate";
                    sf.Connection = con2;
                    sf.CommandType = CommandType.StoredProcedure;
                    sf.Parameters.AddWithValue("@ACC", enterAccNo.accNo);
                    sf.Parameters.AddWithValue("@beginDate", enterAccNo.fromDate);
                    sf.Parameters.AddWithValue("@endDate", enterAccNo.toDate);
                    int x = 0;
                    con2.Open();
                    try
                    {
                        SqlDataReader sfr = sf.ExecuteReader();
                        //count rows to know how many transaction we have.
                        while (sfr.Read())
                        {
                            x++;
                        }
                        transNo.Text = x.ToString() + " transactions";
                        con2.Close();
                        //fill data in the grid view.
                        SqlDataAdapter f = new SqlDataAdapter(sf);
                        DataSet d = new DataSet();
                        f.Fill(d);
                        dataGridView1.DataSource = d.Tables[0];
                        dataGridView1.Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con3.Close();
                    }
                }
                else
                {
                    MessageBox.Show("no account with this number");
                }
             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
            

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
