﻿namespace MyCMDBApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.LbL_User_Directory = new System.Windows.Forms.Label();
            this.Rtb_User_Directory = new System.Windows.Forms.RichTextBox();
            this.Btn_Sign_In = new System.Windows.Forms.Button();
            this.GrB_Register_Form = new System.Windows.Forms.GroupBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Lbl_Repeat_Password = new System.Windows.Forms.Label();
            this.Txt_Repeat_Password = new System.Windows.Forms.TextBox();
            this.GrB_Sign_In_Form = new System.Windows.Forms.GroupBox();
            this.Lbl_User_ID = new System.Windows.Forms.Label();
            this.Txt_User_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Access_Code = new System.Windows.Forms.Label();
            this.Txt_Access_Code = new System.Windows.Forms.TextBox();
            this.RadioBtn_New_User = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Returning_User = new System.Windows.Forms.RadioButton();
            this.Panel_User_Type = new System.Windows.Forms.Panel();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.GrB_Register_Form.SuspendLayout();
            this.GrB_Sign_In_Form.SuspendLayout();
            this.Panel_User_Type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(808, 76);
            this.label1.TabIndex = 13;
            this.label1.Text = "   Contact Management Application (CMA)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Location = new System.Drawing.Point(48, 44);
            this.Lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(78, 18);
            this.Lbl_Username.TabIndex = 14;
            this.Lbl_Username.Text = "Username:";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(133, 41);
            this.Txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(221, 26);
            this.Txt_Username.TabIndex = 1;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(133, 86);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(221, 26);
            this.Txt_Password.TabIndex = 2;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(48, 90);
            this.Lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(74, 18);
            this.Lbl_Password.TabIndex = 16;
            this.Lbl_Password.Text = "Password:";
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Location = new System.Drawing.Point(137, 182);
            this.Btn_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(84, 32);
            this.Btn_Browse.TabIndex = 4;
            this.Btn_Browse.Text = "Select...";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // LbL_User_Directory
            // 
            this.LbL_User_Directory.AutoSize = true;
            this.LbL_User_Directory.Location = new System.Drawing.Point(9, 189);
            this.LbL_User_Directory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbL_User_Directory.Name = "LbL_User_Directory";
            this.LbL_User_Directory.Size = new System.Drawing.Size(125, 18);
            this.LbL_User_Directory.TabIndex = 19;
            this.LbL_User_Directory.Text = "Choose Directory:";
            // 
            // Rtb_User_Directory
            // 
            this.Rtb_User_Directory.BackColor = System.Drawing.SystemColors.Control;
            this.Rtb_User_Directory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtb_User_Directory.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb_User_Directory.Location = new System.Drawing.Point(24, 225);
            this.Rtb_User_Directory.Margin = new System.Windows.Forms.Padding(4);
            this.Rtb_User_Directory.Name = "Rtb_User_Directory";
            this.Rtb_User_Directory.ReadOnly = true;
            this.Rtb_User_Directory.Size = new System.Drawing.Size(354, 33);
            this.Rtb_User_Directory.TabIndex = 20;
            this.Rtb_User_Directory.Text = "";
            // 
            // Btn_Sign_In
            // 
            this.Btn_Sign_In.Location = new System.Drawing.Point(221, 151);
            this.Btn_Sign_In.Name = "Btn_Sign_In";
            this.Btn_Sign_In.Size = new System.Drawing.Size(90, 54);
            this.Btn_Sign_In.TabIndex = 3;
            this.Btn_Sign_In.Text = "Sign In";
            this.Btn_Sign_In.UseVisualStyleBackColor = true;
            this.Btn_Sign_In.Click += new System.EventHandler(this.Btn_Sign_In_Click);
            // 
            // GrB_Register_Form
            // 
            this.GrB_Register_Form.BackColor = System.Drawing.SystemColors.Control;
            this.GrB_Register_Form.Controls.Add(this.Btn_Register);
            this.GrB_Register_Form.Controls.Add(this.Lbl_Repeat_Password);
            this.GrB_Register_Form.Controls.Add(this.Txt_Repeat_Password);
            this.GrB_Register_Form.Controls.Add(this.Btn_Browse);
            this.GrB_Register_Form.Controls.Add(this.Lbl_Username);
            this.GrB_Register_Form.Controls.Add(this.Rtb_User_Directory);
            this.GrB_Register_Form.Controls.Add(this.Txt_Username);
            this.GrB_Register_Form.Controls.Add(this.LbL_User_Directory);
            this.GrB_Register_Form.Controls.Add(this.Lbl_Password);
            this.GrB_Register_Form.Controls.Add(this.Txt_Password);
            this.GrB_Register_Form.Enabled = false;
            this.GrB_Register_Form.Location = new System.Drawing.Point(413, 96);
            this.GrB_Register_Form.Name = "GrB_Register_Form";
            this.GrB_Register_Form.Size = new System.Drawing.Size(390, 357);
            this.GrB_Register_Form.TabIndex = 21;
            this.GrB_Register_Form.TabStop = false;
            this.GrB_Register_Form.Text = "New User";
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(252, 280);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(102, 40);
            this.Btn_Register.TabIndex = 5;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Lbl_Repeat_Password
            // 
            this.Lbl_Repeat_Password.AutoSize = true;
            this.Lbl_Repeat_Password.Location = new System.Drawing.Point(5, 139);
            this.Lbl_Repeat_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Repeat_Password.Name = "Lbl_Repeat_Password";
            this.Lbl_Repeat_Password.Size = new System.Drawing.Size(121, 18);
            this.Lbl_Repeat_Password.TabIndex = 22;
            this.Lbl_Repeat_Password.Text = "Repeat Password:";
            // 
            // Txt_Repeat_Password
            // 
            this.Txt_Repeat_Password.Location = new System.Drawing.Point(133, 136);
            this.Txt_Repeat_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Repeat_Password.Name = "Txt_Repeat_Password";
            this.Txt_Repeat_Password.PasswordChar = '*';
            this.Txt_Repeat_Password.Size = new System.Drawing.Size(221, 26);
            this.Txt_Repeat_Password.TabIndex = 3;
            // 
            // GrB_Sign_In_Form
            // 
            this.GrB_Sign_In_Form.BackColor = System.Drawing.SystemColors.Control;
            this.GrB_Sign_In_Form.Controls.Add(this.Btn_Sign_In);
            this.GrB_Sign_In_Form.Controls.Add(this.Lbl_User_ID);
            this.GrB_Sign_In_Form.Controls.Add(this.Txt_User_ID);
            this.GrB_Sign_In_Form.Controls.Add(this.Lbl_Access_Code);
            this.GrB_Sign_In_Form.Controls.Add(this.Txt_Access_Code);
            this.GrB_Sign_In_Form.Location = new System.Drawing.Point(29, 160);
            this.GrB_Sign_In_Form.Name = "GrB_Sign_In_Form";
            this.GrB_Sign_In_Form.Size = new System.Drawing.Size(359, 293);
            this.GrB_Sign_In_Form.TabIndex = 22;
            this.GrB_Sign_In_Form.TabStop = false;
            this.GrB_Sign_In_Form.Text = "Login to your Account";
            // 
            // Lbl_User_ID
            // 
            this.Lbl_User_ID.AutoSize = true;
            this.Lbl_User_ID.Location = new System.Drawing.Point(11, 52);
            this.Lbl_User_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_User_ID.Name = "Lbl_User_ID";
            this.Lbl_User_ID.Size = new System.Drawing.Size(61, 18);
            this.Lbl_User_ID.TabIndex = 14;
            this.Lbl_User_ID.Text = "User ID:";
            // 
            // Txt_User_ID
            // 
            this.Txt_User_ID.Location = new System.Drawing.Point(110, 49);
            this.Txt_User_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_User_ID.Name = "Txt_User_ID";
            this.Txt_User_ID.Size = new System.Drawing.Size(221, 26);
            this.Txt_User_ID.TabIndex = 1;
            // 
            // Lbl_Access_Code
            // 
            this.Lbl_Access_Code.AutoSize = true;
            this.Lbl_Access_Code.Location = new System.Drawing.Point(11, 98);
            this.Lbl_Access_Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Access_Code.Name = "Lbl_Access_Code";
            this.Lbl_Access_Code.Size = new System.Drawing.Size(93, 18);
            this.Lbl_Access_Code.TabIndex = 16;
            this.Lbl_Access_Code.Text = "Access Code:";
            // 
            // Txt_Access_Code
            // 
            this.Txt_Access_Code.Location = new System.Drawing.Point(110, 94);
            this.Txt_Access_Code.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Access_Code.Name = "Txt_Access_Code";
            this.Txt_Access_Code.PasswordChar = '*';
            this.Txt_Access_Code.Size = new System.Drawing.Size(221, 26);
            this.Txt_Access_Code.TabIndex = 2;
            // 
            // RadioBtn_New_User
            // 
            this.RadioBtn_New_User.AutoSize = true;
            this.RadioBtn_New_User.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioBtn_New_User.Location = new System.Drawing.Point(165, 8);
            this.RadioBtn_New_User.Name = "RadioBtn_New_User";
            this.RadioBtn_New_User.Size = new System.Drawing.Size(89, 22);
            this.RadioBtn_New_User.TabIndex = 2;
            this.RadioBtn_New_User.Text = "New User";
            this.RadioBtn_New_User.UseVisualStyleBackColor = true;
            this.RadioBtn_New_User.CheckedChanged += new System.EventHandler(this.RadioBtn_New_User_CheckedChanged);
            // 
            // RadioBtn_Returning_User
            // 
            this.RadioBtn_Returning_User.AutoSize = true;
            this.RadioBtn_Returning_User.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioBtn_Returning_User.Checked = true;
            this.RadioBtn_Returning_User.Location = new System.Drawing.Point(5, 8);
            this.RadioBtn_Returning_User.Name = "RadioBtn_Returning_User";
            this.RadioBtn_Returning_User.Size = new System.Drawing.Size(126, 22);
            this.RadioBtn_Returning_User.TabIndex = 1;
            this.RadioBtn_Returning_User.TabStop = true;
            this.RadioBtn_Returning_User.Text = "Returning User";
            this.RadioBtn_Returning_User.UseVisualStyleBackColor = true;
            this.RadioBtn_Returning_User.CheckedChanged += new System.EventHandler(this.RadioBtn_Returning_User_CheckedChanged);
            // 
            // Panel_User_Type
            // 
            this.Panel_User_Type.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_User_Type.Controls.Add(this.RadioBtn_Returning_User);
            this.Panel_User_Type.Controls.Add(this.RadioBtn_New_User);
            this.Panel_User_Type.Location = new System.Drawing.Point(28, 96);
            this.Panel_User_Type.Name = "Panel_User_Type";
            this.Panel_User_Type.Size = new System.Drawing.Size(268, 40);
            this.Panel_User_Type.TabIndex = 1;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(320, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Created by Icardi © 2018";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(808, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Panel_User_Type);
            this.Controls.Add(this.GrB_Sign_In_Form);
            this.Controls.Add(this.GrB_Register_Form);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignInForm_FormClosed);
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.GrB_Register_Form.ResumeLayout(false);
            this.GrB_Register_Form.PerformLayout();
            this.GrB_Sign_In_Form.ResumeLayout(false);
            this.GrB_Sign_In_Form.PerformLayout();
            this.Panel_User_Type.ResumeLayout(false);
            this.Panel_User_Type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
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
        private System.Windows.Forms.GroupBox GrB_Register_Form;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label Lbl_Repeat_Password;
        private System.Windows.Forms.TextBox Txt_Repeat_Password;
        private System.Windows.Forms.GroupBox GrB_Sign_In_Form;
        private System.Windows.Forms.Label Lbl_User_ID;
        private System.Windows.Forms.TextBox Txt_User_ID;
        private System.Windows.Forms.Label Lbl_Access_Code;
        private System.Windows.Forms.TextBox Txt_Access_Code;
        private System.Windows.Forms.RadioButton RadioBtn_New_User;
        private System.Windows.Forms.RadioButton RadioBtn_Returning_User;
        private System.Windows.Forms.Panel Panel_User_Type;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.Label label4;
    }
}