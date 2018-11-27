namespace MyCMDBApp
{
    partial class StartupForm
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
            this.btn_Manage_Alerts = new System.Windows.Forms.Button();
            this.btn_Open_Database = new System.Windows.Forms.Button();
            this.Btn_Create_Database = new System.Windows.Forms.Button();
            this.Rtb_Search = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Manage_Alerts
            // 
            this.btn_Manage_Alerts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Manage_Alerts.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manage_Alerts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Manage_Alerts.Location = new System.Drawing.Point(26, 289);
            this.btn_Manage_Alerts.Name = "btn_Manage_Alerts";
            this.btn_Manage_Alerts.Size = new System.Drawing.Size(184, 49);
            this.btn_Manage_Alerts.TabIndex = 3;
            this.btn_Manage_Alerts.Text = "Manage Alerts";
            this.btn_Manage_Alerts.UseVisualStyleBackColor = true;
            // 
            // btn_Open_Database
            // 
            this.btn_Open_Database.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Open_Database.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open_Database.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Open_Database.Location = new System.Drawing.Point(26, 214);
            this.btn_Open_Database.Name = "btn_Open_Database";
            this.btn_Open_Database.Size = new System.Drawing.Size(184, 49);
            this.btn_Open_Database.TabIndex = 2;
            this.btn_Open_Database.Text = "Open Database";
            this.btn_Open_Database.UseVisualStyleBackColor = true;
            this.btn_Open_Database.Click += new System.EventHandler(this.Btn_Open_Database_Click);
            // 
            // Btn_Create_Database
            // 
            this.Btn_Create_Database.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Create_Database.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_Database.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Create_Database.Location = new System.Drawing.Point(26, 138);
            this.Btn_Create_Database.Name = "Btn_Create_Database";
            this.Btn_Create_Database.Size = new System.Drawing.Size(184, 49);
            this.Btn_Create_Database.TabIndex = 1;
            this.Btn_Create_Database.Text = "CREATE DATABASE";
            this.Btn_Create_Database.UseVisualStyleBackColor = true;
            this.Btn_Create_Database.Click += new System.EventHandler(this.Btn_Create_Database_Click);
            // 
            // Rtb_Search
            // 
            this.Rtb_Search.Location = new System.Drawing.Point(298, 63);
            this.Rtb_Search.Name = "Rtb_Search";
            this.Rtb_Search.Size = new System.Drawing.Size(187, 26);
            this.Rtb_Search.TabIndex = 5;
            this.Rtb_Search.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "  Welcome to My Contact Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Search.Location = new System.Drawing.Point(491, 61);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(58, 28);
            this.Btn_Search.TabIndex = 7;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 372);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.btn_Manage_Alerts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Open_Database);
            this.Controls.Add(this.Rtb_Search);
            this.Controls.Add(this.Btn_Create_Database);
            this.Name = "StartupForm";
            this.Text = "My Contact Management";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Manage_Alerts;
        private System.Windows.Forms.Button btn_Open_Database;
        private System.Windows.Forms.Button Btn_Create_Database;
        private System.Windows.Forms.RichTextBox Rtb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Search;
    }
}

