namespace MyCMDBApp
{
    partial class NewAlertForm
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
            this.Lbl_Alert_Title = new System.Windows.Forms.Label();
            this.Txt_Alert_Title = new System.Windows.Forms.TextBox();
            this.Btn_Add_Alert = new System.Windows.Forms.Button();
            this.Btn_Save_Alert = new System.Windows.Forms.Button();
            this.Dtp_DateTime = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Reminder = new System.Windows.Forms.Label();
            this.Timer_Reminder = new System.Windows.Forms.Timer(this.components);
            this.Tag_Label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.GrBox_AlertBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GrBox_AlertBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Alert_Title
            // 
            this.Lbl_Alert_Title.AutoSize = true;
            this.Lbl_Alert_Title.Location = new System.Drawing.Point(22, 36);
            this.Lbl_Alert_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Alert_Title.Name = "Lbl_Alert_Title";
            this.Lbl_Alert_Title.Size = new System.Drawing.Size(41, 18);
            this.Lbl_Alert_Title.TabIndex = 1;
            this.Lbl_Alert_Title.Text = "Title:";
            // 
            // Txt_Alert_Title
            // 
            this.Txt_Alert_Title.Location = new System.Drawing.Point(129, 32);
            this.Txt_Alert_Title.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Alert_Title.Name = "Txt_Alert_Title";
            this.Txt_Alert_Title.Size = new System.Drawing.Size(254, 26);
            this.Txt_Alert_Title.TabIndex = 2;
            // 
            // Btn_Add_Alert
            // 
            this.Btn_Add_Alert.Enabled = false;
            this.Btn_Add_Alert.Location = new System.Drawing.Point(97, 306);
            this.Btn_Add_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Add_Alert.Name = "Btn_Add_Alert";
            this.Btn_Add_Alert.Size = new System.Drawing.Size(99, 45);
            this.Btn_Add_Alert.TabIndex = 4;
            this.Btn_Add_Alert.Text = "Add";
            this.Btn_Add_Alert.UseVisualStyleBackColor = true;
            this.Btn_Add_Alert.Click += new System.EventHandler(this.Btn_Add_Alert_Click);
            // 
            // Btn_Save_Alert
            // 
            this.Btn_Save_Alert.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save_Alert.Location = new System.Drawing.Point(254, 306);
            this.Btn_Save_Alert.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save_Alert.Name = "Btn_Save_Alert";
            this.Btn_Save_Alert.Size = new System.Drawing.Size(92, 45);
            this.Btn_Save_Alert.TabIndex = 4;
            this.Btn_Save_Alert.Text = "Save";
            this.Btn_Save_Alert.UseVisualStyleBackColor = true;
            this.Btn_Save_Alert.Click += new System.EventHandler(this.Btn_Save_Alert_Click);
            // 
            // Dtp_DateTime
            // 
            this.Dtp_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_DateTime.Location = new System.Drawing.Point(129, 83);
            this.Dtp_DateTime.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_DateTime.Name = "Dtp_DateTime";
            this.Dtp_DateTime.Size = new System.Drawing.Size(133, 26);
            this.Dtp_DateTime.TabIndex = 6;
            // 
            // Lbl_DateTime
            // 
            this.Lbl_DateTime.AutoSize = true;
            this.Lbl_DateTime.Location = new System.Drawing.Point(19, 87);
            this.Lbl_DateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DateTime.Name = "Lbl_DateTime";
            this.Lbl_DateTime.Size = new System.Drawing.Size(81, 18);
            this.Lbl_DateTime.TabIndex = 5;
            this.Lbl_DateTime.Text = "Date/Time:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "  Create Alert";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Reminder
            // 
            this.Lbl_Reminder.AutoSize = true;
            this.Lbl_Reminder.Location = new System.Drawing.Point(19, 135);
            this.Lbl_Reminder.Name = "Lbl_Reminder";
            this.Lbl_Reminder.Size = new System.Drawing.Size(129, 18);
            this.Lbl_Reminder.TabIndex = 16;
            this.Lbl_Reminder.Text = "Reminder (hours):";
            // 
            // Tag_Label
            // 
            this.Tag_Label.AutoSize = true;
            this.Tag_Label.Location = new System.Drawing.Point(147, 68);
            this.Tag_Label.Name = "Tag_Label";
            this.Tag_Label.Size = new System.Drawing.Size(77, 18);
            this.Tag_Label.TabIndex = 18;
            this.Tag_Label.Text = "\"Alert Tag\"";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 133);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown1.TabIndex = 19;
            // 
            // Btn_Home
            // 
            this.Btn_Home.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Location = new System.Drawing.Point(346, 13);
            this.Btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(78, 34);
            this.Btn_Home.TabIndex = 32;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // GrBox_AlertBox
            // 
            this.GrBox_AlertBox.Controls.Add(this.Lbl_DateTime);
            this.GrBox_AlertBox.Controls.Add(this.Lbl_Alert_Title);
            this.GrBox_AlertBox.Controls.Add(this.numericUpDown1);
            this.GrBox_AlertBox.Controls.Add(this.Txt_Alert_Title);
            this.GrBox_AlertBox.Controls.Add(this.Dtp_DateTime);
            this.GrBox_AlertBox.Controls.Add(this.Lbl_Reminder);
            this.GrBox_AlertBox.Location = new System.Drawing.Point(23, 96);
            this.GrBox_AlertBox.Name = "GrBox_AlertBox";
            this.GrBox_AlertBox.Size = new System.Drawing.Size(401, 192);
            this.GrBox_AlertBox.TabIndex = 33;
            this.GrBox_AlertBox.TabStop = false;
            this.GrBox_AlertBox.Text = "Event Box";
            // 
            // NewAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 373);
            this.Controls.Add(this.GrBox_AlertBox);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Tag_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Save_Alert);
            this.Controls.Add(this.Btn_Add_Alert);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewAlertForm";
            this.Text = "NewAlertForm";
            this.Load += new System.EventHandler(this.NewAlertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GrBox_AlertBox.ResumeLayout(false);
            this.GrBox_AlertBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Alert_Title;
        private System.Windows.Forms.TextBox Txt_Alert_Title;
        private System.Windows.Forms.Button Btn_Add_Alert;
        private System.Windows.Forms.Button Btn_Save_Alert;
        private System.Windows.Forms.DateTimePicker Dtp_DateTime;
        private System.Windows.Forms.Label Lbl_DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Reminder;
        private System.Windows.Forms.Timer Timer_Reminder;
        private System.Windows.Forms.Label Tag_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.GroupBox GrBox_AlertBox;
    }
}