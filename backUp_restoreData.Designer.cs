
namespace SDB_HW
{
    partial class backUp_restoreData
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
            this.browseBakBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backUpBtn = new System.Windows.Forms.Button();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.restoreDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseRestoreDir = new System.Windows.Forms.Button();
            this.backUpDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseBakBtn
            // 
            this.browseBakBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBakBtn.Location = new System.Drawing.Point(359, 93);
            this.browseBakBtn.Name = "browseBakBtn";
            this.browseBakBtn.Size = new System.Drawing.Size(77, 29);
            this.browseBakBtn.TabIndex = 1;
            this.browseBakBtn.Text = "BROWSE";
            this.browseBakBtn.UseVisualStyleBackColor = true;
            this.browseBakBtn.Click += new System.EventHandler(this.browseBakBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "location";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(-16, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 29);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // backUpBtn
            // 
            this.backUpBtn.Enabled = false;
            this.backUpBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backUpBtn.Location = new System.Drawing.Point(359, 128);
            this.backUpBtn.Name = "backUpBtn";
            this.backUpBtn.Size = new System.Drawing.Size(77, 29);
            this.backUpBtn.TabIndex = 5;
            this.backUpBtn.Text = "BackUp";
            this.backUpBtn.UseVisualStyleBackColor = true;
            this.backUpBtn.Click += new System.EventHandler(this.backUpBtn_Click);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.Enabled = false;
            this.RestoreBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreBtn.Location = new System.Drawing.Point(359, 295);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(77, 29);
            this.RestoreBtn.TabIndex = 9;
            this.RestoreBtn.Text = "Restore";
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // restoreDir
            // 
            this.restoreDir.Location = new System.Drawing.Point(104, 263);
            this.restoreDir.Name = "restoreDir";
            this.restoreDir.Size = new System.Drawing.Size(249, 20);
            this.restoreDir.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "location";
            // 
            // browseRestoreDir
            // 
            this.browseRestoreDir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseRestoreDir.Location = new System.Drawing.Point(359, 260);
            this.browseRestoreDir.Name = "browseRestoreDir";
            this.browseRestoreDir.Size = new System.Drawing.Size(77, 29);
            this.browseRestoreDir.TabIndex = 6;
            this.browseRestoreDir.Text = "BROWSE";
            this.browseRestoreDir.UseVisualStyleBackColor = true;
            this.browseRestoreDir.Click += new System.EventHandler(this.browseRestoreDir_Click);
            // 
            // backUpDir
            // 
            this.backUpDir.Location = new System.Drawing.Point(104, 96);
            this.backUpDir.Name = "backUpDir";
            this.backUpDir.Size = new System.Drawing.Size(249, 20);
            this.backUpDir.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "BackUp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Restore";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BackgroundImage = global::SDB_HW.Properties.Resources.Rectangle_1;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 15);
            this.panel2.TabIndex = 13;
            // 
            // backUp_restoreData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.restoreDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseRestoreDir);
            this.Controls.Add(this.backUpBtn);
            this.Controls.Add(this.backUpDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBakBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "backUp_restoreData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dataBackUp";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button browseBakBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backUpBtn;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.TextBox restoreDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseRestoreDir;
        private System.Windows.Forms.TextBox backUpDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}