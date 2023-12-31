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
    public partial class backUp_restoreData : Form
    {
        public backUp_restoreData()
        {
            InitializeComponent();
        }
        static string conStr = @"Data Source=192.168.1.103,1433;Initial Catalog=BankSystem;User ID=manager;password=1234";
        SqlConnection con = new SqlConnection(conStr);

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void browseBakBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                backUpDir.Text = fbd.SelectedPath;
                backUpBtn.Enabled = true;
            }
        }

        private void backUpBtn_Click(object sender, EventArgs e)
        {
            string databaseName = con.Database.ToString();
            if (backUpDir.Text == "")
            {
                MessageBox.Show("please enter backup file location");
            }
            else
            {
               //sqlcommand to make backup
                string bakStr = "BACKUP DATABASE [" + databaseName + "] TO DISK='" + backUpDir.Text + "\\" +
                    "Database_Shahd_122257" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                con.Open();
                SqlCommand bakCmd = new SqlCommand(bakStr, con);
                bakCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("database backup succefully");
            }
        }

        private void browseRestoreDir_Click(object sender, EventArgs e)
        {
            //filter the files to get .bak only
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                restoreDir.Text = ofd.FileName;
                RestoreBtn.Enabled = true;
            }
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            String database = con.Database.ToString();
            try
            {
                //restore cmd
                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + restoreDir.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Database Restored successfully");
               
                RestoreBtn.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void restoreDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }   
    }
}
