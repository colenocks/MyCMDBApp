namespace MyCMDBApp
{
    partial class SignInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.LbL_User_Directory = new System.Windows.Forms.Label();
            this.Rtb_User_Directory = new System.Windows.Forms.RichTextBox();
            this.Btn_Sign_In = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 76);
            this.label1.TabIndex = 13;
            this.label1.Text = " Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Location = new System.Drawing.Point(58, 110);
            this.Lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(78, 18);
            this.Lbl_Username.TabIndex = 14;
            this.Lbl_Username.Text = "Username:";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(213, 106);
            this.Txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(229, 26);
            this.Txt_Username.TabIndex = 1;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(213, 157);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(229, 26);
            this.Txt_Password.TabIndex = 2;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(58, 161);
            this.Lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(74, 18);
            this.Lbl_Password.TabIndex = 16;
            this.Lbl_Password.Text = "Password:";
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Location = new System.Drawing.Point(213, 208);
            this.Btn_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(104, 32);
            this.Btn_Browse.TabIndex = 3;
            this.Btn_Browse.Text = "Browse...";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // LbL_User_Directory
            // 
            this.LbL_User_Directory.AutoSize = true;
            this.LbL_User_Directory.Location = new System.Drawing.Point(58, 215);
            this.LbL_User_Directory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbL_User_Directory.Name = "LbL_User_Directory";
            this.LbL_User_Directory.Size = new System.Drawing.Size(125, 18);
            this.LbL_User_Directory.TabIndex = 19;
            this.LbL_User_Directory.Text = "Choose Directory:";
            // 
            // Rtb_User_Directory
            // 
            this.Rtb_User_Directory.Location = new System.Drawing.Point(61, 254);
            this.Rtb_User_Directory.Margin = new System.Windows.Forms.Padding(4);
            this.Rtb_User_Directory.Name = "Rtb_User_Directory";
            this.Rtb_User_Directory.ReadOnly = true;
            this.Rtb_User_Directory.Size = new System.Drawing.Size(381, 33);
            this.Rtb_User_Directory.TabIndex = 20;
            this.Rtb_User_Directory.Text = "";
            // 
            // Btn_Sign_In
            // 
            this.Btn_Sign_In.Location = new System.Drawing.Point(340, 321);
            this.Btn_Sign_In.Name = "Btn_Sign_In";
            this.Btn_Sign_In.Size = new System.Drawing.Size(102, 34);
            this.Btn_Sign_In.TabIndex = 4;
            this.Btn_Sign_In.Text = "Sign In";
            this.Btn_Sign_In.UseVisualStyleBackColor = true;
            this.Btn_Sign_In.Click += new System.EventHandler(this.Btn_Sign_In_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 482);
            this.Controls.Add(this.Btn_Sign_In);
            this.Controls.Add(this.Rtb_User_Directory);
            this.Controls.Add(this.LbL_User_Directory);
            this.Controls.Add(this.Btn_Browse);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Lbl_Username);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Button Btn_Browse;
        private System.Windows.Forms.Label LbL_User_Directory;
        private System.Windows.Forms.RichTextBox Rtb_User_Directory;
        private System.Windows.Forms.Button Btn_Sign_In;
    }
}