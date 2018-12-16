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
            this.Btn_Open_Database = new System.Windows.Forms.Button();
            this.Btn_Create_Database = new System.Windows.Forms.Button();
            this.Top_Label = new System.Windows.Forms.Label();
            this.Btn_SignOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_View_Alerts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Open_Database
            // 
            this.Btn_Open_Database.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Open_Database.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Open_Database.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Open_Database.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Open_Database.Location = new System.Drawing.Point(405, 149);
            this.Btn_Open_Database.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Open_Database.Name = "Btn_Open_Database";
            this.Btn_Open_Database.Size = new System.Drawing.Size(280, 73);
            this.Btn_Open_Database.TabIndex = 2;
            this.Btn_Open_Database.Text = "Manage Databases";
            this.Btn_Open_Database.UseVisualStyleBackColor = false;
            this.Btn_Open_Database.Click += new System.EventHandler(this.Btn_Open_Database_Click);
            // 
            // Btn_Create_Database
            // 
            this.Btn_Create_Database.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Create_Database.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Create_Database.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_Database.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Create_Database.Location = new System.Drawing.Point(32, 149);
            this.Btn_Create_Database.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Create_Database.Name = "Btn_Create_Database";
            this.Btn_Create_Database.Size = new System.Drawing.Size(283, 73);
            this.Btn_Create_Database.TabIndex = 1;
            this.Btn_Create_Database.Text = "NEW DATABASE";
            this.Btn_Create_Database.UseVisualStyleBackColor = false;
            this.Btn_Create_Database.Click += new System.EventHandler(this.Btn_Create_Database_Click);
            // 
            // Top_Label
            // 
            this.Top_Label.BackColor = System.Drawing.SystemColors.ControlText;
            this.Top_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Label.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_Label.ForeColor = System.Drawing.Color.White;
            this.Top_Label.Location = new System.Drawing.Point(0, 0);
            this.Top_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Top_Label.Name = "Top_Label";
            this.Top_Label.Size = new System.Drawing.Size(712, 68);
            this.Top_Label.TabIndex = 6;
            this.Top_Label.Text = "  Welcome to My Contact Management";
            this.Top_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SignOut
            // 
            this.Btn_SignOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_SignOut.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_SignOut.Location = new System.Drawing.Point(405, 248);
            this.Btn_SignOut.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SignOut.Name = "Btn_SignOut";
            this.Btn_SignOut.Size = new System.Drawing.Size(250, 73);
            this.Btn_SignOut.TabIndex = 3;
            this.Btn_SignOut.Text = "sign out";
            this.Btn_SignOut.UseVisualStyleBackColor = false;
            this.Btn_SignOut.Click += new System.EventHandler(this.Btn_SignOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(274, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Created by Icardi © 2018";
            // 
            // Btn_View_Alerts
            // 
            this.Btn_View_Alerts.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_View_Alerts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_View_Alerts.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_View_Alerts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_View_Alerts.Location = new System.Drawing.Point(58, 248);
            this.Btn_View_Alerts.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_View_Alerts.Name = "Btn_View_Alerts";
            this.Btn_View_Alerts.Size = new System.Drawing.Size(257, 73);
            this.Btn_View_Alerts.TabIndex = 1;
            this.Btn_View_Alerts.Text = "VIEW ALERTS";
            this.Btn_View_Alerts.UseVisualStyleBackColor = false;
            this.Btn_View_Alerts.Click += new System.EventHandler(this.Btn_View_Alerts_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyCMDBApp.Properties.Resources.images7;
            this.ClientSize = new System.Drawing.Size(712, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_SignOut);
            this.Controls.Add(this.Top_Label);
            this.Controls.Add(this.Btn_Open_Database);
            this.Controls.Add(this.Btn_View_Alerts);
            this.Controls.Add(this.Btn_Create_Database);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to My Contact Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Open_Database;
        private System.Windows.Forms.Button Btn_Create_Database;
        private System.Windows.Forms.Label Top_Label;
        private System.Windows.Forms.Button Btn_SignOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_View_Alerts;
    }
}

