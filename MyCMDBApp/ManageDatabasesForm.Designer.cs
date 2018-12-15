namespace MyCMDBApp
{
    partial class ManageDatabasesForm
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
            this.Btn_Home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Databases = new System.Windows.Forms.ComboBox();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moreInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrBox_ContactList = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Rtb_Search = new System.Windows.Forms.RichTextBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Add_New_Contact = new System.Windows.Forms.Button();
            this.Btn_Create_Alert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrBox_ContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "  Manage Databases";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Home
            // 
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Home.FlatAppearance.BorderSize = 0;
            this.Btn_Home.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Location = new System.Drawing.Point(768, 12);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(81, 31);
            this.Btn_Home.TabIndex = 31;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Choose db:";
            // 
            // ComboBox_Databases
            // 
            this.ComboBox_Databases.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Databases.FormattingEnabled = true;
            this.ComboBox_Databases.Location = new System.Drawing.Point(110, 73);
            this.ComboBox_Databases.Name = "ComboBox_Databases";
            this.ComboBox_Databases.Size = new System.Drawing.Size(174, 26);
            this.ComboBox_Databases.TabIndex = 33;
            // 
            // Btn_Display
            // 
            this.Btn_Display.Enabled = false;
            this.Btn_Display.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Display.Location = new System.Drawing.Point(410, 69);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(89, 32);
            this.Btn_Display.TabIndex = 34;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // Btn_Select
            // 
            this.Btn_Select.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Select.Location = new System.Drawing.Point(302, 69);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(89, 32);
            this.Btn_Select.TabIndex = 34;
            this.Btn_Select.Text = "Select";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.alternativeMobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.moreInfoDataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(831, 292);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewContacts_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 130;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeMobileDataGridViewTextBoxColumn
            // 
            this.alternativeMobileDataGridViewTextBoxColumn.HeaderText = "Alt. Mobile";
            this.alternativeMobileDataGridViewTextBoxColumn.Name = "alternativeMobileDataGridViewTextBoxColumn";
            this.alternativeMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moreInfoDataGridViewTextBoxColumn
            // 
            this.moreInfoDataGridViewTextBoxColumn.HeaderText = "More Info.";
            this.moreInfoDataGridViewTextBoxColumn.Name = "moreInfoDataGridViewTextBoxColumn";
            this.moreInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.moreInfoDataGridViewTextBoxColumn.Width = 130;
            // 
            // GrBox_ContactList
            // 
            this.GrBox_ContactList.Controls.Add(this.dataGridView1);
            this.GrBox_ContactList.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBox_ContactList.Location = new System.Drawing.Point(12, 119);
            this.GrBox_ContactList.Name = "GrBox_ContactList";
            this.GrBox_ContactList.Size = new System.Drawing.Size(837, 317);
            this.GrBox_ContactList.TabIndex = 36;
            this.GrBox_ContactList.TabStop = false;
            this.GrBox_ContactList.Text = "Contact Lists";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Search.Location = new System.Drawing.Point(762, 66);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(87, 34);
            this.Btn_Search.TabIndex = 38;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Rtb_Search
            // 
            this.Rtb_Search.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtb_Search.Location = new System.Drawing.Point(548, 69);
            this.Rtb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Rtb_Search.Name = "Rtb_Search";
            this.Rtb_Search.Size = new System.Drawing.Size(202, 31);
            this.Rtb_Search.TabIndex = 37;
            this.Rtb_Search.Text = "";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Clear.Location = new System.Drawing.Point(759, 446);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(87, 34);
            this.Btn_Clear.TabIndex = 38;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Add_New_Contact
            // 
            this.Btn_Add_New_Contact.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_New_Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_Add_New_Contact.Location = new System.Drawing.Point(583, 446);
            this.Btn_Add_New_Contact.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Add_New_Contact.Name = "Btn_Add_New_Contact";
            this.Btn_Add_New_Contact.Size = new System.Drawing.Size(143, 34);
            this.Btn_Add_New_Contact.TabIndex = 38;
            this.Btn_Add_New_Contact.Text = "Add New Contact";
            this.Btn_Add_New_Contact.UseVisualStyleBackColor = true;
            this.Btn_Add_New_Contact.Click += new System.EventHandler(this.Btn_Add_New_Contact_Click);
            // 
            // Btn_Create_Alert
            // 
            this.Btn_Create_Alert.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Create_Alert.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Btn_Create_Alert.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_Alert.ForeColor = System.Drawing.Color.Red;
            this.Btn_Create_Alert.Location = new System.Drawing.Point(15, 443);
            this.Btn_Create_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Create_Alert.Name = "Btn_Create_Alert";
            this.Btn_Create_Alert.Size = new System.Drawing.Size(125, 40);
            this.Btn_Create_Alert.TabIndex = 39;
            this.Btn_Create_Alert.Text = "Create Alert";
            this.Btn_Create_Alert.UseVisualStyleBackColor = false;
            this.Btn_Create_Alert.Click += new System.EventHandler(this.Btn_Create_Alert_Click);
            // 
            // ManageDatabasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 493);
            this.Controls.Add(this.Btn_Create_Alert);
            this.Controls.Add(this.Btn_Add_New_Contact);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Rtb_Search);
            this.Controls.Add(this.GrBox_ContactList);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.ComboBox_Databases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageDatabasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageDatabasesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrBox_ContactList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Databases;
        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GrBox_ContactList;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.RichTextBox Rtb_Search;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moreInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_Add_New_Contact;
        private System.Windows.Forms.Button Btn_Create_Alert;
    }
}