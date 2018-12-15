namespace MyCMDBApp
{
    partial class ContactDetailForm
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
            this.GrBox_Contact_Form = new System.Windows.Forms.GroupBox();
            this.Btn_Add_Event = new System.Windows.Forms.Button();
            this.Lbl_Alert_Status = new System.Windows.Forms.Label();
            this.listBox_Alerts = new System.Windows.Forms.ListBox();
            this.alertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_Alerts = new System.Windows.Forms.Label();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Btn_Edit_Alert = new System.Windows.Forms.Button();
            this.Btn_Delete_Alert = new System.Windows.Forms.Button();
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
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrBox_Contact_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // GrBox_Contact_Form
            // 
            this.GrBox_Contact_Form.Controls.Add(this.Btn_Add_Event);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Alert_Status);
            this.GrBox_Contact_Form.Controls.Add(this.listBox_Alerts);
            this.GrBox_Contact_Form.Controls.Add(this.Lbl_Alerts);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Notes);
            this.GrBox_Contact_Form.Controls.Add(this.Txt_Address);
            this.GrBox_Contact_Form.Controls.Add(this.Btn_Edit_Alert);
            this.GrBox_Contact_Form.Controls.Add(this.Btn_Delete_Alert);
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
            this.GrBox_Contact_Form.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBox_Contact_Form.Location = new System.Drawing.Point(20, 67);
            this.GrBox_Contact_Form.Margin = new System.Windows.Forms.Padding(4);
            this.GrBox_Contact_Form.Name = "GrBox_Contact_Form";
            this.GrBox_Contact_Form.Padding = new System.Windows.Forms.Padding(4);
            this.GrBox_Contact_Form.Size = new System.Drawing.Size(462, 397);
            this.GrBox_Contact_Form.TabIndex = 12;
            this.GrBox_Contact_Form.TabStop = false;
            this.GrBox_Contact_Form.Text = "Contact Form";
            // 
            // Btn_Add_Event
            // 
            this.Btn_Add_Event.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Add_Event.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Add_Event.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Event.ForeColor = System.Drawing.Color.Peru;
            this.Btn_Add_Event.Location = new System.Drawing.Point(334, 312);
            this.Btn_Add_Event.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Add_Event.Name = "Btn_Add_Event";
            this.Btn_Add_Event.Size = new System.Drawing.Size(93, 31);
            this.Btn_Add_Event.TabIndex = 29;
            this.Btn_Add_Event.Text = "Add Event";
            this.Btn_Add_Event.UseVisualStyleBackColor = false;
            this.Btn_Add_Event.Click += new System.EventHandler(this.Btn_Add_Event_Click);
            // 
            // Lbl_Alert_Status
            // 
            this.Lbl_Alert_Status.AutoSize = true;
            this.Lbl_Alert_Status.Location = new System.Drawing.Point(344, 282);
            this.Lbl_Alert_Status.Name = "Lbl_Alert_Status";
            this.Lbl_Alert_Status.Size = new System.Drawing.Size(74, 15);
            this.Lbl_Alert_Status.TabIndex = 28;
            this.Lbl_Alert_Status.Text = "Alert Status";
            // 
            // listBox_Alerts
            // 
            this.listBox_Alerts.DataSource = this.alertBindingSource;
            this.listBox_Alerts.DisplayMember = "Title";
            this.listBox_Alerts.FormattingEnabled = true;
            this.listBox_Alerts.ItemHeight = 15;
            this.listBox_Alerts.Location = new System.Drawing.Point(152, 282);
            this.listBox_Alerts.Name = "listBox_Alerts";
            this.listBox_Alerts.Size = new System.Drawing.Size(133, 79);
            this.listBox_Alerts.TabIndex = 24;
            this.listBox_Alerts.SelectedIndexChanged += new System.EventHandler(this.ListBox_Alerts_SelectedIndexChanged);
            // 
            // alertBindingSource
            // 
            this.alertBindingSource.DataSource = typeof(CMEntities.Alert);
            // 
            // Lbl_Alerts
            // 
            this.Lbl_Alerts.AutoSize = true;
            this.Lbl_Alerts.Location = new System.Drawing.Point(28, 282);
            this.Lbl_Alerts.Name = "Lbl_Alerts";
            this.Lbl_Alerts.Size = new System.Drawing.Size(43, 15);
            this.Lbl_Alerts.TabIndex = 23;
            this.Lbl_Alerts.Text = "Event:";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Notes.Location = new System.Drawing.Point(152, 222);
            this.Txt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(275, 43);
            this.Txt_Notes.TabIndex = 22;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Address.Location = new System.Drawing.Point(152, 154);
            this.Txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Address.Multiline = true;
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(275, 58);
            this.Txt_Address.TabIndex = 21;
            // 
            // Btn_Edit_Alert
            // 
            this.Btn_Edit_Alert.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_Alert.ForeColor = System.Drawing.Color.Blue;
            this.Btn_Edit_Alert.Location = new System.Drawing.Point(152, 367);
            this.Btn_Edit_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Edit_Alert.Name = "Btn_Edit_Alert";
            this.Btn_Edit_Alert.Size = new System.Drawing.Size(62, 22);
            this.Btn_Edit_Alert.TabIndex = 25;
            this.Btn_Edit_Alert.Text = "Modify";
            this.Btn_Edit_Alert.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete_Alert
            // 
            this.Btn_Delete_Alert.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete_Alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Delete_Alert.Location = new System.Drawing.Point(222, 367);
            this.Btn_Delete_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Delete_Alert.Name = "Btn_Delete_Alert";
            this.Btn_Delete_Alert.Size = new System.Drawing.Size(63, 22);
            this.Btn_Delete_Alert.TabIndex = 25;
            this.Btn_Delete_Alert.Text = "Remove";
            this.Btn_Delete_Alert.UseVisualStyleBackColor = true;
            this.Btn_Delete_Alert.Click += new System.EventHandler(this.Btn_Delete_Alert_Click);
            // 
            // Txt_Alt_Mobile
            // 
            this.Txt_Alt_Mobile.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Alt_Mobile.Location = new System.Drawing.Point(152, 119);
            this.Txt_Alt_Mobile.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Alt_Mobile.Name = "Txt_Alt_Mobile";
            this.Txt_Alt_Mobile.Size = new System.Drawing.Size(275, 23);
            this.Txt_Alt_Mobile.TabIndex = 20;
            this.Txt_Alt_Mobile.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Alt_Mobile_Validating);
            // 
            // Txt_Mobile
            // 
            this.Txt_Mobile.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mobile.Location = new System.Drawing.Point(152, 89);
            this.Txt_Mobile.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Mobile.Name = "Txt_Mobile";
            this.Txt_Mobile.Size = new System.Drawing.Size(275, 23);
            this.Txt_Mobile.TabIndex = 19;
            this.Txt_Mobile.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Mobile_Validating);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(152, 60);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(275, 23);
            this.Txt_Email.TabIndex = 11;
            this.Txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Email_Validating);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.Location = new System.Drawing.Point(152, 30);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(275, 23);
            this.Txt_Name.TabIndex = 10;
            this.Txt_Name.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Name_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 12;
            // 
            // Lbl_Notes
            // 
            this.Lbl_Notes.AutoSize = true;
            this.Lbl_Notes.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Notes.Location = new System.Drawing.Point(22, 226);
            this.Lbl_Notes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Notes.Name = "Lbl_Notes";
            this.Lbl_Notes.Size = new System.Drawing.Size(79, 30);
            this.Lbl_Notes.TabIndex = 13;
            this.Lbl_Notes.Text = "Additional \r\nInformation:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Address.Location = new System.Drawing.Point(22, 155);
            this.Lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(54, 15);
            this.Lbl_Address.TabIndex = 14;
            this.Lbl_Address.Text = "Address:";
            // 
            // Lbl_Alt_Mobile
            // 
            this.Lbl_Alt_Mobile.AutoSize = true;
            this.Lbl_Alt_Mobile.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Alt_Mobile.Location = new System.Drawing.Point(22, 119);
            this.Lbl_Alt_Mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Alt_Mobile.Name = "Lbl_Alt_Mobile";
            this.Lbl_Alt_Mobile.Size = new System.Drawing.Size(117, 15);
            this.Lbl_Alt_Mobile.TabIndex = 15;
            this.Lbl_Alt_Mobile.Text = "Alternative Mobile:";
            // 
            // Lbl_Mobile
            // 
            this.Lbl_Mobile.AutoSize = true;
            this.Lbl_Mobile.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mobile.Location = new System.Drawing.Point(22, 92);
            this.Lbl_Mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Mobile.Name = "Lbl_Mobile";
            this.Lbl_Mobile.Size = new System.Drawing.Size(50, 15);
            this.Lbl_Mobile.TabIndex = 16;
            this.Lbl_Mobile.Text = "Mobile:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(22, 63);
            this.Lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(90, 15);
            this.Lbl_Email.TabIndex = 17;
            this.Lbl_Email.Text = "Email Address:";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(22, 36);
            this.Lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(43, 15);
            this.Lbl_Name.TabIndex = 18;
            this.Lbl_Name.Text = "Name:";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.Btn_Delete.Location = new System.Drawing.Point(20, 477);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(110, 35);
            this.Btn_Delete.TabIndex = 25;
            this.Btn_Delete.Text = "Delete Contact";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.Green;
            this.Btn_Save.Location = new System.Drawing.Point(386, 478);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(96, 36);
            this.Btn_Save.TabIndex = 24;
            this.Btn_Save.Text = "Save Changes";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 55);
            this.label1.TabIndex = 26;
            this.label1.Text = "  Contact Detail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Edit.Location = new System.Drawing.Point(277, 478);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(85, 35);
            this.Btn_Edit.TabIndex = 27;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Back.Location = new System.Drawing.Point(432, 13);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(85, 33);
            this.Btn_Back.TabIndex = 27;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ContactDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(542, 525);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.GrBox_Contact_Form);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GrBox_Contact_Form.ResumeLayout(false);
            this.GrBox_Contact_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBox_Contact_Form;
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
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Alerts;
        private System.Windows.Forms.Label Lbl_Alerts;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Edit_Alert;
        private System.Windows.Forms.Button Btn_Delete_Alert;
        private System.Windows.Forms.BindingSource alertBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label Lbl_Alert_Status;
        private System.Windows.Forms.Button Btn_Add_Event;
    }
}