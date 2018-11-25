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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Alert_Label = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Txt_Alert_Title = new System.Windows.Forms.TextBox();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.Btn_Cancel_Alert = new System.Windows.Forms.Button();
            this.Btn_Save_Alert = new System.Windows.Forms.Button();
            this.Dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 86);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Alert_Label
            // 
            this.Lbl_Alert_Label.AutoSize = true;
            this.Lbl_Alert_Label.Location = new System.Drawing.Point(46, 124);
            this.Lbl_Alert_Label.Name = "Lbl_Alert_Label";
            this.Lbl_Alert_Label.Size = new System.Drawing.Size(30, 13);
            this.Lbl_Alert_Label.TabIndex = 1;
            this.Lbl_Alert_Label.Text = "Title:";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(46, 158);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(33, 13);
            this.Lbl_Date.TabIndex = 1;
            this.Lbl_Date.Text = "Date:";
            // 
            // Txt_Alert_Title
            // 
            this.Txt_Alert_Title.Location = new System.Drawing.Point(117, 121);
            this.Txt_Alert_Title.Name = "Txt_Alert_Title";
            this.Txt_Alert_Title.Size = new System.Drawing.Size(207, 20);
            this.Txt_Alert_Title.TabIndex = 2;
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Date.Location = new System.Drawing.Point(117, 152);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(187, 20);
            this.Dtp_Date.TabIndex = 3;
            // 
            // Btn_Cancel_Alert
            // 
            this.Btn_Cancel_Alert.Location = new System.Drawing.Point(101, 223);
            this.Btn_Cancel_Alert.Name = "Btn_Cancel_Alert";
            this.Btn_Cancel_Alert.Size = new System.Drawing.Size(115, 39);
            this.Btn_Cancel_Alert.TabIndex = 4;
            this.Btn_Cancel_Alert.Text = "Cancel";
            this.Btn_Cancel_Alert.UseVisualStyleBackColor = true;
            // 
            // Btn_Save_Alert
            // 
            this.Btn_Save_Alert.Location = new System.Drawing.Point(241, 223);
            this.Btn_Save_Alert.Name = "Btn_Save_Alert";
            this.Btn_Save_Alert.Size = new System.Drawing.Size(111, 39);
            this.Btn_Save_Alert.TabIndex = 4;
            this.Btn_Save_Alert.Text = "Save";
            this.Btn_Save_Alert.UseVisualStyleBackColor = true;
            // 
            // Dtp_Time
            // 
            this.Dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Time.Location = new System.Drawing.Point(117, 189);
            this.Dtp_Time.Name = "Dtp_Time";
            this.Dtp_Time.Size = new System.Drawing.Size(112, 20);
            this.Dtp_Time.TabIndex = 6;
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(46, 192);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(33, 13);
            this.Lbl_Time.TabIndex = 5;
            this.Lbl_Time.Text = "Time:";
            // 
            // NewAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 284);
            this.Controls.Add(this.Dtp_Time);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.Btn_Save_Alert);
            this.Controls.Add(this.Btn_Cancel_Alert);
            this.Controls.Add(this.Dtp_Date);
            this.Controls.Add(this.Txt_Alert_Title);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_Alert_Label);
            this.Controls.Add(this.panel1);
            this.Name = "NewAlertForm";
            this.Text = "NewAlertForm";
            this.Load += new System.EventHandler(this.NewAlertForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Alert_Label;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.TextBox Txt_Alert_Title;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Button Btn_Cancel_Alert;
        private System.Windows.Forms.Button Btn_Save_Alert;
        private System.Windows.Forms.DateTimePicker Dtp_Time;
        private System.Windows.Forms.Label Lbl_Time;
    }
}