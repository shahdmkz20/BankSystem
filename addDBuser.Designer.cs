
namespace SDB_HW
{
    partial class add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dbWriter = new System.Windows.Forms.CheckBox();
            this.dbReader = new System.Windows.Forms.CheckBox();
            this.dbOwner = new System.Windows.Forms.CheckBox();
            this.dbAccessAdmin = new System.Windows.Forms.CheckBox();
            this.dbDDL = new System.Windows.Forms.CheckBox();
            this.dbSecurityAdmin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbBackUpOperator = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changePermBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(118, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 21);
            this.textBox2.TabIndex = 1;
            // 
            // addUser
            // 
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addUser.Image = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.addUser.Location = new System.Drawing.Point(299, 245);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(115, 42);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 28);
            this.panel2.TabIndex = 15;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::SDB_HW.Properties.Resources.icons8_multiply_16;
            this.closeBtn.Location = new System.Drawing.Point(426, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dbWriter
            // 
            this.dbWriter.AutoSize = true;
            this.dbWriter.Location = new System.Drawing.Point(4, 4);
            this.dbWriter.Name = "dbWriter";
            this.dbWriter.Size = new System.Drawing.Size(72, 17);
            this.dbWriter.TabIndex = 0;
            this.dbWriter.Text = "db_writer";
            this.dbWriter.UseVisualStyleBackColor = true;
            // 
            // dbReader
            // 
            this.dbReader.AutoSize = true;
            this.dbReader.Location = new System.Drawing.Point(4, 26);
            this.dbReader.Name = "dbReader";
            this.dbReader.Size = new System.Drawing.Size(76, 17);
            this.dbReader.TabIndex = 1;
            this.dbReader.Text = "db_reader";
            this.dbReader.UseVisualStyleBackColor = true;
            // 
            // dbOwner
            // 
            this.dbOwner.AutoSize = true;
            this.dbOwner.Location = new System.Drawing.Point(4, 48);
            this.dbOwner.Name = "dbOwner";
            this.dbOwner.Size = new System.Drawing.Size(74, 17);
            this.dbOwner.TabIndex = 2;
            this.dbOwner.Text = "db_owner";
            this.dbOwner.UseVisualStyleBackColor = true;
            // 
            // dbAccessAdmin
            // 
            this.dbAccessAdmin.AutoSize = true;
            this.dbAccessAdmin.Location = new System.Drawing.Point(4, 70);
            this.dbAccessAdmin.Name = "dbAccessAdmin";
            this.dbAccessAdmin.Size = new System.Drawing.Size(104, 17);
            this.dbAccessAdmin.TabIndex = 3;
            this.dbAccessAdmin.Text = "db_accessadmin";
            this.dbAccessAdmin.UseVisualStyleBackColor = true;
            // 
            // dbDDL
            // 
            this.dbDDL.AutoSize = true;
            this.dbDDL.Location = new System.Drawing.Point(4, 92);
            this.dbDDL.Name = "dbDDL";
            this.dbDDL.Size = new System.Drawing.Size(86, 17);
            this.dbDDL.TabIndex = 4;
            this.dbDDL.Text = "db_ddladmin";
            this.dbDDL.UseVisualStyleBackColor = true;
            // 
            // dbSecurityAdmin
            // 
            this.dbSecurityAdmin.AutoSize = true;
            this.dbSecurityAdmin.Location = new System.Drawing.Point(4, 114);
            this.dbSecurityAdmin.Name = "dbSecurityAdmin";
            this.dbSecurityAdmin.Size = new System.Drawing.Size(110, 17);
            this.dbSecurityAdmin.TabIndex = 5;
            this.dbSecurityAdmin.Text = "db_securityadmin";
            this.dbSecurityAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dbBackUpOperator);
            this.panel1.Controls.Add(this.dbSecurityAdmin);
            this.panel1.Controls.Add(this.dbDDL);
            this.panel1.Controls.Add(this.dbAccessAdmin);
            this.panel1.Controls.Add(this.dbOwner);
            this.panel1.Controls.Add(this.dbReader);
            this.panel1.Controls.Add(this.dbWriter);
            this.panel1.Location = new System.Drawing.Point(40, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 174);
            this.panel1.TabIndex = 3;
            // 
            // dbBackUpOperator
            // 
            this.dbBackUpOperator.AutoSize = true;
            this.dbBackUpOperator.Location = new System.Drawing.Point(4, 136);
            this.dbBackUpOperator.Name = "dbBackUpOperator";
            this.dbBackUpOperator.Size = new System.Drawing.Size(120, 17);
            this.dbBackUpOperator.TabIndex = 6;
            this.dbBackUpOperator.Text = "db_backupoperator";
            this.dbBackUpOperator.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "user:";
            // 
            // changePermBtn
            // 
            this.changePermBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePermBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePermBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePermBtn.Image = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.changePermBtn.Location = new System.Drawing.Point(299, 197);
            this.changePermBtn.Name = "changePermBtn";
            this.changePermBtn.Size = new System.Drawing.Size(115, 42);
            this.changePermBtn.TabIndex = 19;
            this.changePermBtn.Text = "change Perm";
            this.changePermBtn.UseVisualStyleBackColor = true;
            this.changePermBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 318);
            this.Controls.Add(this.changePermBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.CheckBox dbWriter;
        private System.Windows.Forms.CheckBox dbReader;
        private System.Windows.Forms.CheckBox dbOwner;
        private System.Windows.Forms.CheckBox dbAccessAdmin;
        private System.Windows.Forms.CheckBox dbDDL;
        private System.Windows.Forms.CheckBox dbSecurityAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox dbBackUpOperator;
        private System.Windows.Forms.Button changePermBtn;
    }
}