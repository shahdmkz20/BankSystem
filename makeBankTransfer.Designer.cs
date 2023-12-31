
namespace SDB_HW
{
    partial class makeBankTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(makeBankTransfer));
            this.from = new System.Windows.Forms.Label();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transferAmount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fromAcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toAcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(43, 96);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(45, 21);
            this.from.TabIndex = 16;
            this.from.Text = "from";
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.RestoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RestoreBtn.Location = new System.Drawing.Point(185, 260);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(166, 29);
            this.RestoreBtn.TabIndex = 22;
            this.RestoreBtn.Text = "Transfer";
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "to";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 29);
            this.panel1.TabIndex = 14;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::SDB_HW.Properties.Resources.icons8_multiply_16;
            this.closeBtn.Location = new System.Drawing.Point(431, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "amount";
            // 
            // transferAmount
            // 
            this.transferAmount.Location = new System.Drawing.Point(135, 212);
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.Size = new System.Drawing.Size(293, 20);
            this.transferAmount.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.fromAcc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(135, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 30);
            this.panel2.TabIndex = 35;
            // 
            // fromAcc
            // 
            this.fromAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromAcc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAcc.Location = new System.Drawing.Point(38, 6);
            this.fromAcc.Name = "fromAcc";
            this.fromAcc.Size = new System.Drawing.Size(241, 19);
            this.fromAcc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Image = global::SDB_HW.Properties.Resources.icons8_manager_16;
            this.label4.Location = new System.Drawing.Point(3, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 38);
            this.label4.TabIndex = 5;
            this.label4.Tag = "  ";
            this.label4.Text = "    \r\n\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.toAcc);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(135, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 30);
            this.panel3.TabIndex = 36;
            // 
            // toAcc
            // 
            this.toAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toAcc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAcc.Location = new System.Drawing.Point(38, 6);
            this.toAcc.Name = "toAcc";
            this.toAcc.Size = new System.Drawing.Size(241, 19);
            this.toAcc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Image = global::SDB_HW.Properties.Resources.icons8_manager_16;
            this.label5.Location = new System.Drawing.Point(3, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 38);
            this.label5.TabIndex = 5;
            this.label5.Tag = "  ";
            this.label5.Text = "    \r\n\r\n";
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.ForeColor = System.Drawing.Color.Red;
            this.star1.Location = new System.Drawing.Point(434, 96);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(13, 13);
            this.star1.TabIndex = 37;
            this.star1.Text = "*";
            this.star1.Visible = false;
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.ForeColor = System.Drawing.Color.Red;
            this.star2.Location = new System.Drawing.Point(434, 154);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(13, 13);
            this.star2.TabIndex = 38;
            this.star2.Text = "*";
            this.star2.Visible = false;
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.ForeColor = System.Drawing.Color.Red;
            this.star3.Location = new System.Drawing.Point(434, 212);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(13, 13);
            this.star3.TabIndex = 39;
            this.star3.Text = "*";
            this.star3.Visible = false;
            // 
            // makeBankTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 338);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.transferAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "makeBankTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "makeBankTransfer";
            this.Load += new System.EventHandler(this.makeBankTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transferAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fromAcc;
        private System.Windows.Forms.TextBox toAcc;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star3;
    }
}