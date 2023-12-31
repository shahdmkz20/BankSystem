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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=manager;password=1234";
        SqlConnection sCon = new SqlConnection(conStr);
        SqlConnection sCon2 = new SqlConnection(conStr);
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            string name = textBox1.Text;
            string pass = textBox2.Text;
            bool db_writer = dbWriter.Checked;
            bool db_reader = dbReader.Checked;
            bool db_accessadmin = dbAccessAdmin.Checked;
            bool db_owner = dbOwner.Checked;
            bool db_ddl = dbDDL.Checked;
            bool db_securityadmin = dbSecurityAdmin.Checked;
            bool db_backupoperator = dbBackUpOperator.Checked;

            //check if user exists or no
            SqlCommand searchForUser = new SqlCommand();
            searchForUser.CommandText = "searchForDBuser";
            searchForUser.CommandType = CommandType.StoredProcedure;
            searchForUser.Parameters.AddWithValue("@username",name);
            searchForUser.Connection = sCon2;

            //create new user
            SqlCommand cmd = new SqlCommand();
            //i couldn't use stored proc here beacuse i need to use [use master]
            string cmdText = "USE [master]" +
                             "CREATE LOGIN[" + name + "] WITH PASSWORD = '" + pass + "'," +
                             " DEFAULT_DATABASE =[BankSystem], CHECK_EXPIRATION = OFF, CHECK_POLICY = ON" +
                             " USE[BankSystem]" +
                             " CREATE USER[" + name + "]FOR LOGIN[" + name + "]";
           
            //append new line in the sqlCmd according to the permessions
            if (db_writer)
            {
                cmdText += " USE[BankSystem]" +
                " ALTER ROLE[db_datawriter] ADD MEMBER[" + name + "]" ;
            }
            if (db_reader)
            {
                cmdText += " USE[BankSystem]" +
               " ALTER ROLE[db_datareader] ADD MEMBER[" + name + "]";
            }
            if (db_backupoperator)
            {
                cmdText += " USE [BankSystem]" +
                          " ALTER ROLE[db_backupoperator] ADD MEMBER[" + name + "]";
            }
            if (db_accessadmin)
            {
                cmdText += "USE[BankSystem]" +
                    " ALTER ROLE[db_accessadmin] ADD MEMBER[" + name + "]";
            }
            if (db_owner)
            {
                cmdText += "USE [BankSystem]" +
                            "ALTER ROLE[db_owner] ADD MEMBER[" + name + "]";
            }
            if (db_ddl)
            {
                cmdText += "USE [BankSystem]" +
                            "ALTER ROLE [db_ddladmin] ADD MEMBER [" + name + "]";
            }
            if (db_securityadmin)
            {
                cmdText += "USE [BankSystem]" +
                           "ALTER ROLE [db_securityadmin] ADD MEMBER [" + name + "]";
            }
            
            cmd.CommandText = cmdText;
            searchForUser.Connection = sCon2;
            cmd.Connection = sCon;
            sCon2.Open();
            sCon.Open();
            try
                {
                SqlDataReader sdr = searchForUser.ExecuteReader();
                if (sdr.Read())
                {
                    MessageBox.Show("user already exists!!");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("user added succefully!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sCon.Close();
                sCon2.Close();
            }
           
                

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            bool db_writer = dbWriter.Checked;
            bool db_reader = dbReader.Checked;
            bool db_accessadmin = dbAccessAdmin.Checked;
            bool db_owner = dbOwner.Checked;
            bool db_ddl = dbDDL.Checked;
            bool db_securityadmin = dbSecurityAdmin.Checked;
            bool db_backupoperator = dbBackUpOperator.Checked;
            SqlCommand searchForUser = new SqlCommand();
            searchForUser.CommandText = "searchForDBuser";
            searchForUser.CommandType = CommandType.StoredProcedure;
            searchForUser.Parameters.AddWithValue("@username", name);
            searchForUser.Connection = sCon2;

            SqlCommand alterUser = new SqlCommand();
            string cmdText = "USE [master]"+
           " ALTER LOGIN["+name+"] WITH PASSWORD = '" + pass + "'";
            if (db_writer)
            {
                cmdText += " USE[BankSystem]" +
                " ALTER ROLE[db_datawriter] ADD MEMBER[" + name + "]";
            }
            if (!db_writer)
            {
                cmdText += " USE[BankSystem]" +
                " ALTER ROLE[db_datawriter] DROP MEMBER[" + name + "]";
            }
            if (db_reader)
            {
                cmdText += " USE[BankSystem]" +
               " ALTER ROLE[db_datareader] ADD MEMBER[" + name + "]";
            }
            if (!db_reader)
            {
                cmdText += " USE[BankSystem]" +
               " ALTER ROLE[db_datareader] DROP MEMBER[" + name + "]";
            }
            if (db_owner)
            {
                cmdText += " USE[BankSystem]" +
                " ALTER ROLE[db_owner] ADD MEMBER[" + name + "]";
            }
            if (!db_owner)
            {
                cmdText += " USE[BankSystem]" +
                " ALTER ROLE[db_owner] DROP MEMBER[" + name + "]";
            }
            if (db_backupoperator)
            {
                cmdText += " USE [BankSystem]" +
                          " ALTER ROLE[db_backupoperator] ADD MEMBER[" + name + "]";
            }
            if (!db_backupoperator)
            {
                cmdText += " USE [BankSystem]" +
                          " ALTER ROLE[db_backupoperator] DROP MEMBER[" + name + "]";
            }
            if (db_accessadmin)
            {
                cmdText += "USE[BankSystem]" +
                    " ALTER ROLE[db_accessadmin] ADD MEMBER[" + name + "]";
            }
            if (!db_accessadmin)
            {
                cmdText += "USE[BankSystem]" +
                    " ALTER ROLE[db_accessadmin] DROP MEMBER[" + name + "]";
            }
            if (db_ddl)
            {
                cmdText += "USE [BankSystem]" +
                            "ALTER ROLE [db_ddladmin] ADD MEMBER [" + name + "]";
            }
            if (!db_ddl)
            {
                cmdText += "USE [BankSystem]" +
                            "ALTER ROLE [db_ddladmin] DROP MEMBER [" + name + "]";
            }
            if (db_securityadmin)
            {
                cmdText += "USE [BankSystem]" +
                           "ALTER ROLE [db_securityadmin] ADD MEMBER [" + name + "]";
            }
            if (!db_securityadmin)
            {
                cmdText += "USE [BankSystem]" +
                           "ALTER ROLE [db_securityadmin] DROP MEMBER [" + name + "]";
            }

            alterUser.Connection= sCon;
            alterUser.CommandText = cmdText;
           
            try
            {
                sCon2.Open();
                SqlDataReader sd = searchForUser.ExecuteReader();
                if (sd.Read() )
                {
                    sCon.Open();
                    alterUser.ExecuteNonQuery();
                    MessageBox.Show("user permessions changed succefully");
                }
                else
                {
                    MessageBox.Show("No user found with this name ....");
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sCon.Close();
                sCon2.Close();
            }


        }
    }
}
