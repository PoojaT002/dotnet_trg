namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbnpassword = new System.Windows.Forms.Label();
            this.Lbnloginform = new System.Windows.Forms.Label();
            this.lbnusername = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbnpassword
            // 
            this.lbnpassword.AutoSize = true;
            this.lbnpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnpassword.Location = new System.Drawing.Point(75, 182);
            this.lbnpassword.Name = "lbnpassword";
            this.lbnpassword.Size = new System.Drawing.Size(220, 32);
            this.lbnpassword.TabIndex = 0;
            this.lbnpassword.Text = "Enter  Password";
            // 
            // Lbnloginform
            // 
            this.Lbnloginform.AutoSize = true;
            this.Lbnloginform.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbnloginform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbnloginform.Location = new System.Drawing.Point(276, 27);
            this.Lbnloginform.Name = "Lbnloginform";
            this.Lbnloginform.Size = new System.Drawing.Size(222, 46);
            this.Lbnloginform.TabIndex = 1;
            this.Lbnloginform.Text = "Login Form";
            // 
            // lbnusername
            // 
            this.lbnusername.AutoSize = true;
            this.lbnusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnusername.Location = new System.Drawing.Point(75, 124);
            this.lbnusername.Name = "lbnusername";
            this.lbnusername.Size = new System.Drawing.Size(226, 32);
            this.lbnusername.TabIndex = 2;
            this.lbnusername.Text = "Enter  Username";
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.Location = new System.Drawing.Point(407, 271);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(129, 48);
            this.btncancle.TabIndex = 3;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(178, 271);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(117, 48);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(407, 130);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(251, 26);
            this.txtusername.TabIndex = 5;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(407, 182);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(251, 26);
            this.txtpassword.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.lbnusername);
            this.Controls.Add(this.Lbnloginform);
            this.Controls.Add(this.lbnpassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnpassword;
        private System.Windows.Forms.Label Lbnloginform;
        private System.Windows.Forms.Label lbnusername;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
    }
}

