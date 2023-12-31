
namespace SDB_HW
{
    partial class employeePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeePanel));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.makeStatement = new System.Windows.Forms.Button();
            this.openNewAccount = new System.Windows.Forms.Button();
            this.closeAccBtn = new System.Windows.Forms.Button();
            this.makeTransferBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(193, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 60);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome USER!";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 446);
            this.panel2.TabIndex = 14;
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 446);
            this.panel1.TabIndex = 13;
            // 
            // makeStatement
            // 
            this.makeStatement.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.makeStatement.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.makeStatement.Enabled = false;
            this.makeStatement.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.makeStatement.FlatAppearance.BorderSize = 0;
            this.makeStatement.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.makeStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeStatement.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeStatement.ForeColor = System.Drawing.Color.LightCyan;
            this.makeStatement.Location = new System.Drawing.Point(228, 149);
            this.makeStatement.Name = "makeStatement";
            this.makeStatement.Size = new System.Drawing.Size(293, 53);
            this.makeStatement.TabIndex = 12;
            this.makeStatement.Text = "MAKE STATMENT";
            this.makeStatement.UseVisualStyleBackColor = false;
            this.makeStatement.Click += new System.EventHandler(this.makeStatement_Click);
            // 
            // openNewAccount
            // 
            this.openNewAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openNewAccount.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.openNewAccount.Enabled = false;
            this.openNewAccount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.openNewAccount.FlatAppearance.BorderSize = 0;
            this.openNewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.openNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openNewAccount.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openNewAccount.ForeColor = System.Drawing.Color.LightCyan;
            this.openNewAccount.Location = new System.Drawing.Point(228, 208);
            this.openNewAccount.Name = "openNewAccount";
            this.openNewAccount.Size = new System.Drawing.Size(293, 53);
            this.openNewAccount.TabIndex = 11;
            this.openNewAccount.Text = "OPEN NEW ACCOUNT";
            this.openNewAccount.UseVisualStyleBackColor = false;
            this.openNewAccount.Click += new System.EventHandler(this.openNewAccount_Click);
            // 
            // closeAccBtn
            // 
            this.closeAccBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeAccBtn.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.closeAccBtn.Enabled = false;
            this.closeAccBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.closeAccBtn.FlatAppearance.BorderSize = 0;
            this.closeAccBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.closeAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeAccBtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAccBtn.ForeColor = System.Drawing.Color.LightCyan;
            this.closeAccBtn.Location = new System.Drawing.Point(228, 326);
            this.closeAccBtn.Name = "closeAccBtn";
            this.closeAccBtn.Size = new System.Drawing.Size(293, 53);
            this.closeAccBtn.TabIndex = 10;
            this.closeAccBtn.Text = "CLOSE ACCOUNT";
            this.closeAccBtn.UseVisualStyleBackColor = false;
            this.closeAccBtn.Click += new System.EventHandler(this.closeAccBtn_Click);
            // 
            // makeTransferBtn
            // 
            this.makeTransferBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.makeTransferBtn.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.makeTransferBtn.Enabled = false;
            this.makeTransferBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.makeTransferBtn.FlatAppearance.BorderSize = 0;
            this.makeTransferBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.makeTransferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeTransferBtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTransferBtn.ForeColor = System.Drawing.Color.LightCyan;
            this.makeTransferBtn.Location = new System.Drawing.Point(228, 267);
            this.makeTransferBtn.Name = "makeTransferBtn";
            this.makeTransferBtn.Size = new System.Drawing.Size(293, 53);
            this.makeTransferBtn.TabIndex = 9;
            this.makeTransferBtn.Text = "MAKE TRANSFER";
            this.makeTransferBtn.UseVisualStyleBackColor = false;
            this.makeTransferBtn.Click += new System.EventHandler(this.makeTransferBtn_Click);
            // 
            // employeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.makeStatement);
            this.Controls.Add(this.openNewAccount);
            this.Controls.Add(this.closeAccBtn);
            this.Controls.Add(this.makeTransferBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "employeePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userPanel";
            this.Load += new System.EventHandler(this.userPanel_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button makeStatement;
        private System.Windows.Forms.Button openNewAccount;
        private System.Windows.Forms.Button closeAccBtn;
        private System.Windows.Forms.Button makeTransferBtn;
    }
}