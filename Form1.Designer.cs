namespace Calendar
{
    partial class Form1
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
            this.btnPrevYear = new System.Windows.Forms.Button();
            this.btnNextYear = new System.Windows.Forms.Button();
            this.lblStaticYearSelection = new System.Windows.Forms.Label();
            this.lblSelectedYear = new System.Windows.Forms.Label();
            this.lblSelectedMonth = new System.Windows.Forms.Label();
            this.lblStaticMonthSelection = new System.Windows.Forms.Label();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrevYear
            // 
            this.btnPrevYear.Location = new System.Drawing.Point(233, 52);
            this.btnPrevYear.Name = "btnPrevYear";
            this.btnPrevYear.Size = new System.Drawing.Size(34, 23);
            this.btnPrevYear.TabIndex = 3;
            this.btnPrevYear.Text = "<";
            this.btnPrevYear.UseVisualStyleBackColor = true;
            this.btnPrevYear.Click += new System.EventHandler(this.YearAndMonthControl);
            // 
            // btnNextYear
            // 
            this.btnNextYear.Location = new System.Drawing.Point(316, 52);
            this.btnNextYear.Name = "btnNextYear";
            this.btnNextYear.Size = new System.Drawing.Size(34, 23);
            this.btnNextYear.TabIndex = 4;
            this.btnNextYear.Text = ">";
            this.btnNextYear.UseVisualStyleBackColor = true;
            this.btnNextYear.Click += new System.EventHandler(this.YearAndMonthControl);
            // 
            // lblStaticYearSelection
            // 
            this.lblStaticYearSelection.AutoSize = true;
            this.lblStaticYearSelection.Location = new System.Drawing.Point(232, 26);
            this.lblStaticYearSelection.Name = "lblStaticYearSelection";
            this.lblStaticYearSelection.Size = new System.Drawing.Size(65, 13);
            this.lblStaticYearSelection.TabIndex = 5;
            this.lblStaticYearSelection.Text = "Select Year:";
            // 
            // lblSelectedYear
            // 
            this.lblSelectedYear.AutoSize = true;
            this.lblSelectedYear.Location = new System.Drawing.Point(273, 57);
            this.lblSelectedYear.Name = "lblSelectedYear";
            this.lblSelectedYear.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedYear.TabIndex = 6;
            // 
            // lblSelectedMonth
            // 
            this.lblSelectedMonth.AutoSize = true;
            this.lblSelectedMonth.Location = new System.Drawing.Point(417, 57);
            this.lblSelectedMonth.Name = "lblSelectedMonth";
            this.lblSelectedMonth.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedMonth.TabIndex = 10;
            // 
            // lblStaticMonthSelection
            // 
            this.lblStaticMonthSelection.AutoSize = true;
            this.lblStaticMonthSelection.Location = new System.Drawing.Point(376, 26);
            this.lblStaticMonthSelection.Name = "lblStaticMonthSelection";
            this.lblStaticMonthSelection.Size = new System.Drawing.Size(70, 13);
            this.lblStaticMonthSelection.TabIndex = 9;
            this.lblStaticMonthSelection.Text = "Select Month";
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(460, 52);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(34, 23);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.YearAndMonthControl);
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Location = new System.Drawing.Point(377, 52);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(34, 23);
            this.btnPrevMonth.TabIndex = 7;
            this.btnPrevMonth.Text = "<";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.YearAndMonthControl);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 531);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 12;
            // 
            // chkBoxAdmin
            // 
            this.chkBoxAdmin.AutoSize = true;
            this.chkBoxAdmin.Location = new System.Drawing.Point(18, 31);
            this.chkBoxAdmin.Name = "chkBoxAdmin";
            this.chkBoxAdmin.Size = new System.Drawing.Size(55, 17);
            this.chkBoxAdmin.TabIndex = 13;
            this.chkBoxAdmin.Text = "Admin";
            this.chkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Location = new System.Drawing.Point(133, 31);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(72, 44);
            this.btnSelectUser.TabIndex = 14;
            this.btnSelectUser.Text = "Switch user";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.BtnSelectUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 638);
            this.Controls.Add(this.btnSelectUser);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chkBoxAdmin);
            this.Controls.Add(this.btnPrevMonth);
            this.Controls.Add(this.btnPrevYear);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblStaticMonthSelection);
            this.Controls.Add(this.btnNextYear);
            this.Controls.Add(this.lblSelectedYear);
            this.Controls.Add(this.lblStaticYearSelection);
            this.Controls.Add(this.lblSelectedMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrevYear;
        private System.Windows.Forms.Button btnNextYear;
        private System.Windows.Forms.Label lblStaticYearSelection;
        private System.Windows.Forms.Label lblSelectedYear;
        private System.Windows.Forms.Label lblSelectedMonth;
        private System.Windows.Forms.Label lblStaticMonthSelection;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkBoxAdmin;
        private System.Windows.Forms.Button btnSelectUser;
    }
}

