namespace MyCMDBApp
{
    partial class ContactsViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeMobileViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = " Contact List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameViewDataGridViewTextBoxColumn,
            this.emailViewDataGridViewTextBoxColumn,
            this.mobileViewDataGridViewTextBoxColumn,
            this.alternativeMobileViewDataGridViewTextBoxColumn,
            this.addressViewDataGridViewTextBoxColumn,
            this.noteViewDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactInfoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(675, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // contactInfoBindingSource
            // 
            this.contactInfoBindingSource.DataSource = typeof(CMEntities.ContactInfo);
            // 
            // nameViewDataGridViewTextBoxColumn
            // 
            this.nameViewDataGridViewTextBoxColumn.DataPropertyName = "Name_View";
            this.nameViewDataGridViewTextBoxColumn.HeaderText = "Name_View";
            this.nameViewDataGridViewTextBoxColumn.Name = "nameViewDataGridViewTextBoxColumn";
            this.nameViewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailViewDataGridViewTextBoxColumn
            // 
            this.emailViewDataGridViewTextBoxColumn.DataPropertyName = "Email_View";
            this.emailViewDataGridViewTextBoxColumn.HeaderText = "Email_View";
            this.emailViewDataGridViewTextBoxColumn.Name = "emailViewDataGridViewTextBoxColumn";
            this.emailViewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileViewDataGridViewTextBoxColumn
            // 
            this.mobileViewDataGridViewTextBoxColumn.DataPropertyName = "Mobile_View";
            this.mobileViewDataGridViewTextBoxColumn.HeaderText = "Mobile_View";
            this.mobileViewDataGridViewTextBoxColumn.Name = "mobileViewDataGridViewTextBoxColumn";
            this.mobileViewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeMobileViewDataGridViewTextBoxColumn
            // 
            this.alternativeMobileViewDataGridViewTextBoxColumn.DataPropertyName = "Alternative_Mobile_View";
            this.alternativeMobileViewDataGridViewTextBoxColumn.HeaderText = "Alternative_Mobile_View";
            this.alternativeMobileViewDataGridViewTextBoxColumn.Name = "alternativeMobileViewDataGridViewTextBoxColumn";
            this.alternativeMobileViewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressViewDataGridViewTextBoxColumn
            // 
            this.addressViewDataGridViewTextBoxColumn.DataPropertyName = "Address_View";
            this.addressViewDataGridViewTextBoxColumn.HeaderText = "Address_View";
            this.addressViewDataGridViewTextBoxColumn.Name = "addressViewDataGridViewTextBoxColumn";
            this.addressViewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteViewDataGridViewTextBoxColumn
            // 
            this.noteViewDataGridViewTextBoxColumn.DataPropertyName = "Note_View";
            this.noteViewDataGridViewTextBoxColumn.HeaderText = "Note_View";
            this.noteViewDataGridViewTextBoxColumn.Name = "noteViewDataGridViewTextBoxColumn";
            this.noteViewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ContactsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContactsViewForm";
            this.Text = "ContactsViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameViewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailViewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileViewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeMobileViewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressViewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteViewDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactInfoBindingSource;
    }
}