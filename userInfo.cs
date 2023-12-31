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
    public partial class userInfo : Form
    {
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=manager;password=1234";
        SqlConnection sqlCon = new SqlConnection(conStr);
        SqlConnection sqlCon2 = new SqlConnection(conStr);
        string empUserName;
        public userInfo()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeUserPermissions_Load(object sender, EventArgs e)
        {
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            SqlConnection sqlCon = new SqlConnection(conStr);
            sqlCon.Open();
            insertDataToBranchList();
            insertDataToManagerList();
            sqlCon.Close();
        }

        private void Search_Click(object sender, EventArgs e)

        {
            string empID = emp_ID.Text;
            empUserName = emp_ID.Text;
            sqlCon.Open();
            string checkUser = "SELECT [employee_name] FROM employee WHERE  [employee_ID] ='" + empID + "'";
            SqlCommand checkCommand = new SqlCommand(checkUser, sqlCon);
            SqlDataAdapter sqd = new SqlDataAdapter(checkCommand);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("no user with this ID");
                sqlCon.Close();

            }
            else
            {

                string searchCommand = "SELECT [employee_name] , [phone] , [Branch_ID] ,[manager_ID], [password] , [isManager], [LogAccess], [stateAccess] ,[openAccess] ,[closeAccess] ,[transferAccess] FROM [employee] WHERE [employee_ID] = '" + empID + "'";
                SqlCommand cmd = new SqlCommand(searchCommand, sqlCon);
                SqlDataReader sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    emp_name.Text = sqlReader[0].ToString();
                    emp_phone.Text = sqlReader[1].ToString();
                    branch_list.SelectedValue = sqlReader.GetValue(2);
                    managerList.SelectedValue = sqlReader.GetValue(3);
                    emp_pass.Text = sqlReader.GetValue(4).ToString();
                    is_Manager.Checked = Convert.ToBoolean(sqlReader[5]);
                    bool l;
                    bool.TryParse(sqlReader[6].ToString(), out l);
                    log_Access.Checked = l;
                    bool m;
                    bool.TryParse(sqlReader.GetValue(7).ToString(), out m);
                    MakeState_Access.Checked = m;
                    bool o;
                    bool.TryParse(sqlReader.GetValue(8).ToString(), out o);
                    Open_Access.Checked = o;

                    bool c;
                    bool.TryParse(sqlReader.GetValue(9).ToString(), out c);
                    Close_Access.Checked = c;

                    bool t;
                    bool.TryParse(sqlReader.GetValue(10).ToString(), out t);
                    transfer_Access.Checked = t;

                }

                sqlCon.Close();
            }



        }
        
        private void update_Click(object sender, EventArgs e)
        {
            string changedUserName = emp_ID.Text;
            String empName = emp_name.Text;
            String empPhone = emp_phone.Text;
            String br = branch_list.SelectedValue.ToString();
            String mn = managerList.SelectedValue.ToString();
            String password = emp_pass.Text;
            bool isManager = (is_Manager.Checked);
            bool OpenAccess = Open_Access.Checked;
            bool closeAccess = Close_Access.Checked;
            bool logAccess = log_Access.Checked;
            bool transferAccess = transfer_Access.Checked;
            bool stateAccess = MakeState_Access.Checked;
            if (changedUserName != empUserName)
            {
                MessageBox.Show("You can't change user ID");
                emp_ID.Text = empUserName;
            }
            else
            {
                sqlCon.Open();
                string u = "UPDATE employee SET employee_name = '" + empName + "' , phone = '" + empPhone + "', " +
                           "Branch_ID ='" + br + "',manager_ID ='" + mn + "'," + "password='" + password + "',isManager=@is_manager" +
                           ",LogAccess=@log_Access, stateAccess=@state_Access ,openAccess= @open_Access , closeAccess =@close_Access" +
                           ",transferAccess = @transfer_Access  WHERE employee_ID =@emp_ID";
                SqlCommand updateCmd = new SqlCommand(u, sqlCon);
                updateCmd.Parameters.AddWithValue("@is_manager", isManager);
                updateCmd.Parameters.AddWithValue("@log_Access", logAccess);
                updateCmd.Parameters.AddWithValue("@state_Access", stateAccess);
                updateCmd.Parameters.AddWithValue("@open_Access", OpenAccess);
                updateCmd.Parameters.AddWithValue("@close_Access", closeAccess);
                updateCmd.Parameters.AddWithValue("@transfer_Access", transferAccess);
                updateCmd.Parameters.AddWithValue("@emp_ID", empUserName);
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("user infomration updated succefully!!");

                //re-Assign managers in manager list
                insertDataToManagerList();

                sqlCon.Close();
            }

        }

        private void emp_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
        private bool checkEmptyFields()
        {
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;


            if ((emp_ID.Text == "") || (emp_name.Text == "") || (emp_phone.Text == "") || (emp_pass.Text == ""))
            {
                if ((emp_ID.Text == ""))
                    star1.Visible = true;
                if ((emp_name.Text == ""))
                    star2.Visible = true;
                if (emp_phone.Text == "")
                    star3.Visible = true;
                if (emp_pass.Text == "")
                    star4.Visible = true;

                return false;
            }
            else
            {
                return true;
            }


        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            String empID = emp_ID.Text;
            star1.Visible = false;
            sqlCon.Open();
            string checkUser = "SELECT [employee_name] FROM employee WHERE  [employee_ID] ='" + empID + "'";
            SqlCommand checkCommand = new SqlCommand(checkUser, sqlCon);
            SqlDataAdapter sqd = new SqlDataAdapter(checkCommand);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No user with this ID");
                sqlCon.Close();

            }
            else
            {
                sqlCon.Close();
                if (empID != "")
                {
                    sqlCon.Open();
                    string deleteString = "DELETE FROM employee WHERE employee_ID = " + emp_ID.Text;
                    SqlCommand delCmd = new SqlCommand(deleteString, sqlCon);
                    delCmd.ExecuteNonQuery();
                    MessageBox.Show("user deleted succefuly");
                    ClearTextBoxes();
                    insertDataToManagerList();
                    sqlCon.Close();
                }
                else
                {
                    star1.Visible = true;
                    MessageBox.Show("please enter employee ID");
                }
            }
        }
        public void ClearTextBoxes()
        {

            emp_ID.Text = "";
            emp_name.Text = "";
            emp_pass.Text = "";
            emp_phone.Text = "";
            is_Manager.Checked = false;
            branch_list.SelectedIndex = 0;
            managerList.SelectedIndex = 0;
            Open_Access.Checked = false;
            Close_Access.Checked = false;
            log_Access.Checked = false;
            MakeState_Access.Checked = false;
            transfer_Access.Checked = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string empID = emp_ID.Text;
            string empName = emp_name.Text;
            string empPhone = emp_phone.Text;
            string br = branch_list.SelectedValue.ToString();
            string mn = managerList.SelectedValue.ToString();
            string password = emp_pass.Text;
            bool isManager = (is_Manager.Checked);
            bool OpenAccess = Open_Access.Checked;
            bool closeAccess = Close_Access.Checked;
            bool logAccess = log_Access.Checked;
            bool transferAccess = transfer_Access.Checked;
            bool stateAccess = MakeState_Access.Checked;



            if (checkEmptyFields())
            {

                sqlCon.Open();
                SqlCommand checkCommand = new SqlCommand();
                checkCommand.Connection = sqlCon;
                checkCommand.CommandText = "checkUserExists";
                checkCommand.CommandType = CommandType.StoredProcedure;
                checkCommand.Parameters.AddWithValue("@empID", empID);
                SqlDataReader sdr = checkCommand.ExecuteReader();
                //there is user with this ID
                if (sdr.Read())
                {
                    MessageBox.Show("user already exists ... please check the ID");
                    sqlCon.Close();
                }
                //no user with this ID , then add new user
                else
                {
                    sqlCon.Close();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandText = "INSERTUSER";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userName", empName);
                    cmd.Parameters.AddWithValue("@userID", empID);
                    cmd.Parameters.AddWithValue("@userPhone", empPhone);
                    cmd.Parameters.AddWithValue("@userBranch", br);
                    cmd.Parameters.AddWithValue("@userManager", mn);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@UserisManager", isManager);
                    cmd.Parameters.AddWithValue("@UseropenAccess", OpenAccess);
                    cmd.Parameters.AddWithValue("@UsercloseAccess", closeAccess);
                    cmd.Parameters.AddWithValue("@UserLogAccess", logAccess);
                    cmd.Parameters.AddWithValue("@UsertransferAccess", transferAccess);
                    cmd.Parameters.AddWithValue("@UserstateAccess", stateAccess);
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                   
                    MessageBox.Show("User added succesfully");
                    ClearTextBoxes();
                    sqlCon.Open();
                    insertDataToManagerList();
                    sqlCon.Close();

                }
            }

        }
        //to insert data in manager list , it'
        public void insertDataToManagerList()
        {
            String MN_query = "Select [employee_name] , [employee_ID] From employee WHERE [isManager] = " + 1;
            SqlCommand MN_cmd = new SqlCommand(MN_query, sqlCon);
            SqlDataAdapter MN_Ad = new SqlDataAdapter();

            MN_Ad.SelectCommand = MN_cmd;
            DataTable MN_dt = new DataTable();

            MN_Ad.Fill(MN_dt);
            managerList.DataSource = MN_dt;
            managerList.DisplayMember = "employee_name";
            managerList.ValueMember = "employee_ID";
         
        }
        public void insertDataToBranchList()
        {
        
            String BR_query = "Select [Branch_name] , [Branch_ID] From Branch";
            SqlCommand cmd = new SqlCommand(BR_query, sqlCon);
            SqlDataAdapter sqlAd = new SqlDataAdapter();
            sqlAd.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqlAd.Fill(dt);
            branch_list.DataSource = dt;
            branch_list.DisplayMember = "Branch_name";
            branch_list.ValueMember = "Branch_ID";
     
        }
        public void getDataFromTextBoxes()
        {
            string changedUserName = emp_ID.Text;
            String empName = emp_name.Text;
            String empPhone = emp_phone.Text;
            String br = branch_list.SelectedValue.ToString();
            String mn = managerList.SelectedValue.ToString();
            String password = emp_pass.Text;
            bool isManager = (is_Manager.Checked);
            bool OpenAccess = Open_Access.Checked;
            bool closeAccess = Close_Access.Checked;
            bool logAccess = log_Access.Checked;
            bool transferAccess = transfer_Access.Checked;
            bool stateAccess = MakeState_Access.Checked;
        }
    }
}
