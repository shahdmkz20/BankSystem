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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        public static string empName;
        public static string userName;
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=admin;password=1234";
        SqlConnection con = new SqlConnection(conStr);
        SqlConnection con1 = new SqlConnection(conStr);
   
        public static string employeeName;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        { 
            empName = name.Text;
            userName = name.Text;
            string pass = password.Text;
            SqlCommand checkUser = new SqlCommand();
            checkUser.CommandText = "checkUser";
            checkUser.CommandType = CommandType.StoredProcedure;
            checkUser.Parameters.AddWithValue("@empID", userName);
            checkUser.Parameters.AddWithValue("@empPass", pass);
            checkUser.Connection = con;
            try
            {
                con.Open();
                SqlDataReader sdr = checkUser.ExecuteReader();
                //to check if user exists.
                if (sdr.Read())
                {
                    empName = sdr[0].ToString();
                    //gets the status of the account if 1 then it's active
                    if (Convert.ToBoolean(sdr[2]))
                    {
                        //gets the (isManager) value if 1 then he's manager.
                        if (Convert.ToBoolean(sdr[1]))
                        {
                            adminPanel adminForm = new adminPanel();
                            adminForm.Show();
                        }
                        //isManager = 0 then he's employee
                        else if (!Convert.ToBoolean(sdr[1]))
                        {
                            SqlCommand LogPerm = new SqlCommand();
                            LogPerm.CommandText = "checkLogInPerm";
                            LogPerm.CommandType = CommandType.StoredProcedure;
                            LogPerm.Parameters.AddWithValue("@empID",userName);
                            LogPerm.Connection = con1;
                            con1.Open();
                            SqlDataReader sd = LogPerm.ExecuteReader();
                            if(sd.Read())
                            {
                                //get's the login perm if 1 then logIn.
                                if (Convert.ToBoolean(sd[0]))
                                {
                                    employeePanel employeeForm = new employeePanel();
                                    employeeForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("you are not allowed to logIn");
                                }
                            }
                            con1.Close();
                         
                        }
                    }
                    else
                    {
                        MessageBox.Show("your account is de-activated , please check your manager ...");
                    }
                }
                else
                {
                    MessageBox.Show("wrong user name or password");
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
    }
}
