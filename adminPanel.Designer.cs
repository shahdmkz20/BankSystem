
namespace SDB_HW
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataBackUpBtn = new System.Windows.Forms.Button();
            this.adddbUserBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(192, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome ADMIN!";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.user.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.user.FlatAppearance.BorderSize = 0;
            this.user.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.user.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.LightCyan;
            this.user.Location = new System.Drawing.Point(228, 293);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(293, 53);
            this.user.TabIndex = 8;
            this.user.Text = "Employees";
            this.user.UseVisualStyleBackColor = false;
            this.user.Click += new System.EventHandler(this.chUsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Location = new System.Drawing.Point(699, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 446);
            this.panel2.TabIndex = 6;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::SDB_HW.Properties.Resources.icons8_multiply_16;
            this.closeBtn.Location = new System.Drawing.Point(9, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 446);
            this.panel1.TabIndex = 5;
            // 
            // dataBackUpBtn
            // 
            this.dataBackUpBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataBackUpBtn.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.dataBackUpBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.dataBackUpBtn.FlatAppearance.BorderSize = 0;
            this.dataBackUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataBackUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataBackUpBtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBackUpBtn.ForeColor = System.Drawing.Color.LightCyan;
            this.dataBackUpBtn.Location = new System.Drawing.Point(227, 173);
            this.dataBackUpBtn.Name = "dataBackUpBtn";
            this.dataBackUpBtn.Size = new System.Drawing.Size(293, 53);
            this.dataBackUpBtn.TabIndex = 4;
            this.dataBackUpBtn.Text = "BACKUP/RESTORE DATA";
            this.dataBackUpBtn.UseVisualStyleBackColor = false;
            this.dataBackUpBtn.Click += new System.EventHandler(this.dataBackUpBtn_Click);
            // 
            // adddbUserBtn
            // 
            this.adddbUserBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adddbUserBtn.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.adddbUserBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.adddbUserBtn.FlatAppearance.BorderSize = 0;
            this.adddbUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.adddbUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adddbUserBtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddbUserBtn.ForeColor = System.Drawing.Color.LightCyan;
            this.adddbUserBtn.Location = new System.Drawing.Point(228, 233);
            this.adddbUserBtn.Name = "adddbUserBtn";
            this.adddbUserBtn.Size = new System.Drawing.Size(293, 53);
            this.adddbUserBtn.TabIndex = 9;
            this.adddbUserBtn.Text = "ADD DB USER";
            this.adddbUserBtn.UseVisualStyleBackColor = false;
            this.adddbUserBtn.Click += new System.EventHandler(this.adddbUserBtn_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 444);
            this.ControlBox = false;
            this.Controls.Add(this.adddbUserBtn);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataBackUpBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPanel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dataBackUpBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button adddbUserBtn;
    }
}