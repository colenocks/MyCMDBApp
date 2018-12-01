namespace MyCMDBApp
{
    partial class NewDatabaseForm
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
            this.Lbl_Database_Name = new System.Windows.Forms.Label();
            this.Btn_Create_Alert = new System.Windows.Forms.Button();
            this.Txt_Database_Name = new System.Windows.Forms.TextBox();
            this.Rtb_Database_Directory = new System.Windows.Forms.RichTextBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Add_Contacts = new System.Windows.Forms.Button();
            this.Lbl_Directory = new System.Windows.Forms.Label();
            this.GrBox_Contact_Form = new System.Windows.Forms.GroupBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_New_Database = new System.Windows.Forms.Button();
            this.Btn_View_Contacts = new System.Windows.Forms.Button();
            this.Btn_Finish = new System.Windows.Forms.Button();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Txt_Alt_Mobile = new System.Windows.Forms.TextBox();
            this.Txt_Mobile = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_Notes = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Lbl_Alt_Mobile = new System.Windows.Forms.Label();
            this.Lbl_Mobile = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GrBox_Contact_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Database_Name
            // 
            this.Lbl_Database_Name.AutoSize = true;
            this.Lbl_Database_Name.Location = new System.Drawing.Point(16, 67);
            this.Lbl_Database_Name.Name = "Lbl_Database_Name";
            this.Lbl_Database_Name.Size = new System.Drawing.Size(110, 17);
            this.Lbl_Database_Name.TabIndex = 8;
            this.Lbl_Database_Name.Text = "Database Name:";
            // 
            // Btn_Create_Alert
            // 
            this.Btn_Create_Alert.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Create_Alert.Enabled = false;
            this.Btn_Create_Alert.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Btn_Create_Alert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Create_Alert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Create_Alert.Location = new System.Drawing.Point(467, 100);
            this.Btn_Create_Alert.Name = "Btn_Create_Alert";
            this.Btn_Create_Alert.Size = new System.Drawing.Size(89, 35);
            this.Btn_Create_Alert.TabIndex = 4;
            this.Btn_Create_Alert.Text = "Create Alert";
            this.Btn_Create_Alert.UseVisualStyleBackColor = false;
            this.Btn_Create_Alert.Click += new System.EventHandler(this.Btn_Create_Alert_Click);
            // 
            // Txt_Database_Name
            // 
            this.Txt_Database_Name.Location = new System.Drawing.Point(131, 64);
            this.Txt_Database_Name.MaxLength = 16;
            this.Txt_Database_Name.Name = "Txt_Database_Name";
            this.Txt_Database_Name.Size = new System.Drawing.Size(199, 24);
            this.Txt_Database_Name.TabIndex = 1;
            // 
            // Rtb_Database_Directory
            // 
            this.Rtb_Database_Directory.AutoWordSelection = true;
            this.Rtb_Database_Directory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtb_Database_Directory.Location = new System.Drawing.Point(91, 100);
            this.Rtb_Database_Directory.Multiline = false;
            this.Rtb_Database_Directory.Name = "Rtb_Database_Directory";
            this.Rtb_Database_Directory.ReadOnly = true;
            this.Rtb_Database_Directory.Size = new System.Drawing.Size(336, 35);
            this.Rtb_Database_Directory.TabIndex = 6;
            this.Rtb_Database_Directory.Text = "";
            this.Rtb_Database_Directory.WordWrap = false;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(346, 61);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(85, 33);
            this.Btn_Create.TabIndex = 2;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Btn_Add_Contacts
            // 
            this.Btn_Add_Contacts.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Add_Contacts.Enabled = false;
            this.Btn_Add_Contacts.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Btn_Add_Contacts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Add_Contacts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Add_Contacts.Location = new System.Drawing.Point(463, 62);
            this.Btn_Add_Contacts.Name = "Btn_Add_Contacts";
            this.Btn_Add_Contacts.Size = new System.Drawing.Size(98, 32);
            this.Btn_Add_Contacts.TabIndex = 3;
            this.Btn_Add_Contacts.Text = "Add Contacts";
            this.Btn_Add_Contacts.UseVisualStyleBackColor = false;
            this.Btn_Add_Contacts.Click += new System.EventHandler(this.Btn_Add_Contacts_Click);
            // 
            // Lbl_Directory
            // 
            this.Lbl_Directory.AutoSize = true;
            this.Lbl_Directory.Location = new System.Drawing.Point(19, 100);
            this.Lbl_Directory.Name = "Lbl_Directory";
            this.Lbl_Directory.Size = new System.Drawing.Size(70, 17);
            this.Lbl_Directory.TabIndex = 10;
            this.Lbl_Directory.Text = "Directory:";
            // 
            // GrBox_Contact_Form
            // 
            this.GrBox_Contact_Form.Controls.Add(this.Btn_Add);
            this.GrBox_Contact_Form.Controls.Add(this.Btn_New_Database);
            this.GrBox_Contact_Form.Controls.Add(this.Btn_View_Contacts);
            this.GrBox_Contact_Form.Controls.Add(this.Btn_Finish);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Notes);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Address);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Alt_Mobile);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Mobile);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Email);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Name);
            this.GrBox_Contact_Form.Controls.Add(this.label7);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Notes);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Address);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Alt_Mobile);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Mobile);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Email);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Name);
            this.GrBox_Contact_Form.Enabled = false;
            this.GrBox_Contact_Form.Location = new System.Drawing.Point(18, 137);
            this.GrBox_Contact_Form.Name = "GrBox_Contact_Form";
            this.GrBox_Contact_Form.Size = new System.Drawing.Size(459, 402);
            this.GrBox_Contact_Form.TabIndex = 11;
            this.GrBox_Contact_Form.TabStop = false;
            this.GrBox_Contact_Form.Text = "Contact Form";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(353, 300);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(82, 38);
            this.Btn_Add.TabIndex = 23;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_New_Database
            // 
            this.Btn_New_Database.Enabled = false;
            this.Btn_New_Database.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New_Database.Location = new System.Drawing.Point(12, 349);
            this.Btn_New_Database.Name = "Btn_New_Database";
            this.Btn_New_Database.Size = new System.Drawing.Size(125, 38);
            this.Btn_New_Database.TabIndex = 25;
            this.Btn_New_Database.Text = "New Database";
            this.Btn_New_Database.UseVisualStyleBackColor = true;
            this.Btn_New_Database.Click += new System.EventHandler(this.Btn_New_Database_Click);
            // 
            // Btn_View_Contacts
            // 
            this.Btn_View_Contacts.Enabled = false;
            this.Btn_View_Contacts.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_View_Contacts.Location = new System.Drawing.Point(310, 349);
            this.Btn_View_Contacts.Name = "Btn_View_Contacts";
            this.Btn_View_Contacts.Size = new System.Drawing.Size(125, 38);
            this.Btn_View_Contacts.TabIndex = 25;
            this.Btn_View_Contacts.Text = "View Contacts";
            this.Btn_View_Contacts.UseVisualStyleBackColor = true;
            this.Btn_View_Contacts.Click += new System.EventHandler(this.Btn_View_Contacts_Click);
            // 
            // Btn_Finish
            // 
            this.Btn_Finish.Enabled = false;
            this.Btn_Finish.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finish.Location = new System.Drawing.Point(169, 348);
            this.Btn_Finish.Name = "Btn_Finish";
            this.Btn_Finish.Size = new System.Drawing.Size(92, 39);
            this.Btn_Finish.TabIndex = 24;
            this.Btn_Finish.Text = "Finish";
            this.Btn_Finish.UseVisualStyleBackColor = true;
            this.Btn_Finish.Click += new System.EventHandler(this.Btn_Finish_Click);
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Notes.Location = new System.Drawing.Point(154, 221);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(281, 73);
            this.Txt_Notes.TabIndex = 22;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Address.Location = new System.Drawing.Point(154, 158);
            this.Txt_Address.Multiline = true;
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(281, 49);
            this.Txt_Address.TabIndex = 21;
            // 
            // Txt_Alt_Mobile
            // 
            this.Txt_Alt_Mobile.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Alt_Mobile.Location = new System.Drawing.Point(154, 124);
            this.Txt_Alt_Mobile.Name = "Txt_Alt_Mobile";
            this.Txt_Alt_Mobile.Size = new System.Drawing.Size(281, 24);
            this.Txt_Alt_Mobile.TabIndex = 20;
            // 
            // Txt_Mobile
            // 
            this.Txt_Mobile.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mobile.Location = new System.Drawing.Point(154, 91);
            this.Txt_Mobile.Name = "Txt_Mobile";
            this.Txt_Mobile.Size = new System.Drawing.Size(281, 24);
            this.Txt_Mobile.TabIndex = 19;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(154, 55);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(281, 24);
            this.Txt_Email.TabIndex = 11;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.Location = new System.Drawing.Point(154, 22);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(281, 24);
            this.Txt_Name.TabIndex = 10;
            this.Txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Name_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 12;
            // 
            // Lbl_Notes
            // 
            this.Lbl_Notes.AutoSize = true;
            this.Lbl_Notes.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Notes.Location = new System.Drawing.Point(9, 221);
            this.Lbl_Notes.Name = "Lbl_Notes";
            this.Lbl_Notes.Size = new System.Drawing.Size(86, 34);
            this.Lbl_Notes.TabIndex = 13;
            this.Lbl_Notes.Text = "Additional \r\nInformation:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Address.Location = new System.Drawing.Point(9, 158);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(61, 17);
            this.Lbl_Address.TabIndex = 14;
            this.Lbl_Address.Text = "Address:";
            // 
            // Lbl_Alt_Mobile
            // 
            this.Lbl_Alt_Mobile.AutoSize = true;
            this.Lbl_Alt_Mobile.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Alt_Mobile.Location = new System.Drawing.Point(9, 127);
            this.Lbl_Alt_Mobile.Name = "Lbl_Alt_Mobile";
            this.Lbl_Alt_Mobile.Size = new System.Drawing.Size(128, 17);
            this.Lbl_Alt_Mobile.TabIndex = 15;
            this.Lbl_Alt_Mobile.Text = "Alternative Mobile:";
            // 
            // Lbl_Mobile
            // 
            this.Lbl_Mobile.AutoSize = true;
            this.Lbl_Mobile.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mobile.Location = new System.Drawing.Point(9, 93);
            this.Lbl_Mobile.Name = "Lbl_Mobile";
            this.Lbl_Mobile.Size = new System.Drawing.Size(56, 17);
            this.Lbl_Mobile.TabIndex = 16;
            this.Lbl_Mobile.Text = "Mobile:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(9, 60);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(100, 17);
            this.Lbl_Email.TabIndex = 17;
            this.Lbl_Email.Text = "Email Address:";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(9, 25);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(48, 17);
            this.Lbl_Name.TabIndex = 18;
            this.Lbl_Name.Text = "Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "  Create a New Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Home
            // 
            this.Btn_Home.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Location = new System.Drawing.Point(480, 12);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(81, 28);
            this.Btn_Home.TabIndex = 30;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(99, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Note: Click on finish so you can add new database";
            // 
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrBox_Contact_Form);
            this.Controls.Add(this.Lbl_Directory);
            this.Controls.Add(this.Rtb_Database_Directory);
            this.Controls.Add(this.Txt_Database_Name);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.Btn_Add_Contacts);
            this.Controls.Add(this.Btn_Create_Alert);
            this.Controls.Add(this.Lbl_Database_Name);
            this.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Database";
            this.Load += new System.EventHandler(this.NewDatabaseForm_Load);
            this.GrBox_Contact_Form.ResumeLayout(false);
            this.GrBox_Contact_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Database_Name;
        private System.Windows.Forms.Button Btn_Create_Alert;
        private System.Windows.Forms.TextBox Txt_Database_Name;
        private System.Windows.Forms.RichTextBox Rtb_Database_Directory;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Add_Contacts;
        private System.Windows.Forms.Label Lbl_Directory;
        private System.Windows.Forms.GroupBox GrBox_Contact_Form;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_View_Contacts;
        private System.Windows.Forms.Button Btn_Finish;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.TextBox Txt_Alt_Mobile;
        private System.Windows.Forms.TextBox Txt_Mobile;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_Notes;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label Lbl_Alt_Mobile;
        private System.Windows.Forms.Label Lbl_Mobile;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_New_Database;
        private System.Windows.Forms.Label label2;
    }
}