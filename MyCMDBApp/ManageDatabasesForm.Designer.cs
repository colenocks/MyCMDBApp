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
            this.GrBox_ContactList = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Rtb_Search = new System.Windows.Forms.RichTextBox();
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
            this.label1.Size = new System.Drawing.Size(763, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "  Manage Databases";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Home
            // 
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Home.FlatAppearance.BorderSize = 0;
            this.Btn_Home.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Location = new System.Drawing.Point(669, 12);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(81, 28);
            this.Btn_Home.TabIndex = 31;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Choose db:";
            // 
            // ComboBox_Databases
            // 
            this.ComboBox_Databases.FormattingEnabled = true;
            this.ComboBox_Databases.Location = new System.Drawing.Point(110, 73);
            this.ComboBox_Databases.Name = "ComboBox_Databases";
            this.ComboBox_Databases.Size = new System.Drawing.Size(174, 23);
            this.ComboBox_Databases.TabIndex = 33;
            this.ComboBox_Databases.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Databases_SelectedIndexChanged);
            // 
            // Btn_Display
            // 
            this.Btn_Display.Location = new System.Drawing.Point(320, 68);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(89, 32);
            this.Btn_Display.TabIndex = 34;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = true;
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(415, 67);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(89, 32);
            this.Btn_Select.TabIndex = 34;
            this.Btn_Select.Text = "Select";
            this.Btn_Select.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 305);
            this.dataGridView1.TabIndex = 35;
            // 
            // GrBox_ContactList
            // 
            this.GrBox_ContactList.Controls.Add(this.dataGridView1);
            this.GrBox_ContactList.Location = new System.Drawing.Point(30, 119);
            this.GrBox_ContactList.Name = "GrBox_ContactList";
            this.GrBox_ContactList.Size = new System.Drawing.Size(617, 327);
            this.GrBox_ContactList.TabIndex = 36;
            this.GrBox_ContactList.TabStop = false;
            this.GrBox_ContactList.Text = "Contact Lists";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Search.Location = new System.Drawing.Point(673, 106);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(77, 34);
            this.Btn_Search.TabIndex = 38;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Rtb_Search
            // 
            this.Rtb_Search.Location = new System.Drawing.Point(548, 67);
            this.Rtb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Rtb_Search.Name = "Rtb_Search";
            this.Rtb_Search.Size = new System.Drawing.Size(202, 31);
            this.Rtb_Search.TabIndex = 37;
            this.Rtb_Search.Text = "";
            // 
            // ManageDatabasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 484);
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
    }
}