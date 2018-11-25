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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Manage_Alerts = new System.Windows.Forms.Button();
            this.btn_Open_Database = new System.Windows.Forms.Button();
            this.Btn_Create_Database = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_Manage_Alerts);
            this.panel1.Controls.Add(this.btn_Open_Database);
            this.panel1.Controls.Add(this.Btn_Create_Database);
            this.panel1.Location = new System.Drawing.Point(91, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 334);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(45, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(307, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Welcome to My Contact Management";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_Manage_Alerts
            // 
            this.btn_Manage_Alerts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Manage_Alerts.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manage_Alerts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Manage_Alerts.Location = new System.Drawing.Point(179, 244);
            this.btn_Manage_Alerts.Name = "btn_Manage_Alerts";
            this.btn_Manage_Alerts.Size = new System.Drawing.Size(182, 49);
            this.btn_Manage_Alerts.TabIndex = 3;
            this.btn_Manage_Alerts.Text = "Manage Alerts";
            this.btn_Manage_Alerts.UseVisualStyleBackColor = true;
            // 
            // btn_Open_Database
            // 
            this.btn_Open_Database.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Open_Database.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open_Database.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Open_Database.Location = new System.Drawing.Point(102, 173);
            this.btn_Open_Database.Name = "btn_Open_Database";
            this.btn_Open_Database.Size = new System.Drawing.Size(182, 49);
            this.btn_Open_Database.TabIndex = 2;
            this.btn_Open_Database.Text = "Open Database";
            this.btn_Open_Database.UseVisualStyleBackColor = true;
            // 
            // Btn_Create_Database
            // 
            this.Btn_Create_Database.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Create_Database.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_Database.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Create_Database.Location = new System.Drawing.Point(13, 104);
            this.Btn_Create_Database.Name = "Btn_Create_Database";
            this.Btn_Create_Database.Size = new System.Drawing.Size(182, 49);
            this.Btn_Create_Database.TabIndex = 1;
            this.Btn_Create_Database.Text = "CREATE DATABASE";
            this.Btn_Create_Database.UseVisualStyleBackColor = true;
            this.Btn_Create_Database.Click += new System.EventHandler(this.Btn_Create_Database_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 351);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "StartupForm";
            this.Text = "My Contact Management";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Manage_Alerts;
        private System.Windows.Forms.Button btn_Open_Database;
        private System.Windows.Forms.Button Btn_Create_Database;
    }
}

