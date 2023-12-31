
namespace SDB_HW
{
    partial class deleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.deleteAcc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.accNo = new System.Windows.Forms.TextBox();
            this.star = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "account number";
            // 
            // deleteAcc
            // 
            this.deleteAcc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAcc.Location = new System.Drawing.Point(213, 112);
            this.deleteAcc.Name = "deleteAcc";
            this.deleteAcc.Size = new System.Drawing.Size(77, 29);
            this.deleteAcc.TabIndex = 15;
            this.deleteAcc.Text = "DELETE";
            this.deleteAcc.UseVisualStyleBackColor = true;
            this.deleteAcc.Click += new System.EventHandler(this.deleteAcc_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 32);
            this.panel1.TabIndex = 14;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::SDB_HW.Properties.Resources.icons8_multiply_16;
            this.closeBtn.Location = new System.Drawing.Point(435, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // accNo
            // 
            this.accNo.Location = new System.Drawing.Point(138, 67);
            this.accNo.Name = "accNo";
            this.accNo.Size = new System.Drawing.Size(249, 20);
            this.accNo.TabIndex = 17;
            // 
            // star
            // 
            this.star.AutoSize = true;
            this.star.ForeColor = System.Drawing.Color.Red;
            this.star.Location = new System.Drawing.Point(394, 73);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(13, 13);
            this.star.TabIndex = 18;
            this.star.Text = "*";
            this.star.Visible = false;
            // 
            // deleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 183);
            this.Controls.Add(this.star);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteAcc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleteAccount";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox accNo;
        private System.Windows.Forms.Label star;
    }
}