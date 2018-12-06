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
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Txt_Alert_Title = new System.Windows.Forms.TextBox();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.Btn_Cancel_Alert = new System.Windows.Forms.Button();
            this.Btn_Save_Alert = new System.Windows.Forms.Button();
            this.Dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Reminder = new System.Windows.Forms.Label();
            this.Timer_Reminder = new System.Windows.Forms.Timer(this.components);
            this.Tag_Label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Alert_Title
            // 
            this.Lbl_Alert_Title.AutoSize = true;
            this.Lbl_Alert_Title.Location = new System.Drawing.Point(40, 113);
            this.Lbl_Alert_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Alert_Title.Name = "Lbl_Alert_Title";
            this.Lbl_Alert_Title.Size = new System.Drawing.Size(41, 18);
            this.Lbl_Alert_Title.TabIndex = 1;
            this.Lbl_Alert_Title.Text = "Title:";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(40, 160);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(42, 18);
            this.Lbl_Date.TabIndex = 1;
            this.Lbl_Date.Text = "Date:";
            // 
            // Txt_Alert_Title
            // 
            this.Txt_Alert_Title.Location = new System.Drawing.Point(147, 109);
            this.Txt_Alert_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Alert_Title.Name = "Txt_Alert_Title";
            this.Txt_Alert_Title.Size = new System.Drawing.Size(278, 26);
            this.Txt_Alert_Title.TabIndex = 2;
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Date.Location = new System.Drawing.Point(147, 154);
            this.Dtp_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_Date.MinDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(278, 26);
            this.Dtp_Date.TabIndex = 3;
            // 
            // Btn_Cancel_Alert
            // 
            this.Btn_Cancel_Alert.Location = new System.Drawing.Point(136, 306);
            this.Btn_Cancel_Alert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cancel_Alert.Name = "Btn_Cancel_Alert";
            this.Btn_Cancel_Alert.Size = new System.Drawing.Size(99, 54);
            this.Btn_Cancel_Alert.TabIndex = 4;
            this.Btn_Cancel_Alert.Text = "Cancel";
            this.Btn_Cancel_Alert.UseVisualStyleBackColor = true;
            // 
            // Btn_Save_Alert
            // 
            this.Btn_Save_Alert.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save_Alert.Location = new System.Drawing.Point(258, 306);
            this.Btn_Save_Alert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Save_Alert.Name = "Btn_Save_Alert";
            this.Btn_Save_Alert.Size = new System.Drawing.Size(92, 54);
            this.Btn_Save_Alert.TabIndex = 4;
            this.Btn_Save_Alert.Text = "Save";
            this.Btn_Save_Alert.UseVisualStyleBackColor = true;
            this.Btn_Save_Alert.Click += new System.EventHandler(this.Btn_Save_Alert_Click);
            // 
            // Dtp_Time
            // 
            this.Dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Time.Location = new System.Drawing.Point(147, 203);
            this.Dtp_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_Time.Name = "Dtp_Time";
            this.Dtp_Time.Size = new System.Drawing.Size(166, 26);
            this.Dtp_Time.TabIndex = 6;
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(40, 207);
            this.Lbl_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(45, 18);
            this.Lbl_Time.TabIndex = 5;
            this.Lbl_Time.Text = "Time:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "  Create Alert";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Reminder
            // 
            this.Lbl_Reminder.AutoSize = true;
            this.Lbl_Reminder.Location = new System.Drawing.Point(10, 253);
            this.Lbl_Reminder.Name = "Lbl_Reminder";
            this.Lbl_Reminder.Size = new System.Drawing.Size(129, 18);
            this.Lbl_Reminder.TabIndex = 16;
            this.Lbl_Reminder.Text = "Reminder (hours):";
            // 
            // Tag_Label
            // 
            this.Tag_Label.AutoSize = true;
            this.Tag_Label.Location = new System.Drawing.Point(39, 69);
            this.Tag_Label.Name = "Tag_Label";
            this.Tag_Label.Size = new System.Drawing.Size(77, 18);
            this.Tag_Label.TabIndex = 18;
            this.Tag_Label.Text = "\"Alert Tag\"";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(150, 251);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown1.TabIndex = 19;
            // 
            // NewAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 373);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Tag_Label);
            this.Controls.Add(this.Lbl_Reminder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Time);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.Btn_Save_Alert);
            this.Controls.Add(this.Btn_Cancel_Alert);
            this.Controls.Add(this.Dtp_Date);
            this.Controls.Add(this.Txt_Alert_Title);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_Alert_Title);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewAlertForm";
            this.Text = "NewAlertForm";
            this.Load += new System.EventHandler(this.NewAlertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Alert_Title;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.TextBox Txt_Alert_Title;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Button Btn_Cancel_Alert;
        private System.Windows.Forms.Button Btn_Save_Alert;
        private System.Windows.Forms.DateTimePicker Dtp_Time;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Reminder;
        private System.Windows.Forms.Timer Timer_Reminder;
        private System.Windows.Forms.Label Tag_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}