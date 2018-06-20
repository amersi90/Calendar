namespace Calendar
{
    partial class Form2
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.btnRedColor = new System.Windows.Forms.Button();
            this.btnGreenColor = new System.Windows.Forms.Button();
            this.btnBlueColor = new System.Windows.Forms.Button();
            this.btnYellowColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 70);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Description";
            // 
            // txtInformation
            // 
            this.txtInformation.Location = new System.Drawing.Point(82, 67);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(190, 20);
            this.txtInformation.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(197, 238);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Save";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "End date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtWorker
            // 
            this.txtWorker.Location = new System.Drawing.Point(82, 32);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(190, 20);
            this.txtWorker.TabIndex = 10;
            // 
            // btnRedColor
            // 
            this.btnRedColor.BackColor = System.Drawing.Color.Red;
            this.btnRedColor.Location = new System.Drawing.Point(82, 161);
            this.btnRedColor.Name = "btnRedColor";
            this.btnRedColor.Size = new System.Drawing.Size(43, 35);
            this.btnRedColor.TabIndex = 11;
            this.btnRedColor.UseVisualStyleBackColor = false;
            this.btnRedColor.Click += new System.EventHandler(this.BtnGetColor);
            // 
            // btnGreenColor
            // 
            this.btnGreenColor.BackColor = System.Drawing.Color.Green;
            this.btnGreenColor.Location = new System.Drawing.Point(131, 161);
            this.btnGreenColor.Name = "btnGreenColor";
            this.btnGreenColor.Size = new System.Drawing.Size(43, 35);
            this.btnGreenColor.TabIndex = 12;
            this.btnGreenColor.UseVisualStyleBackColor = false;
            this.btnGreenColor.Click += new System.EventHandler(this.BtnGetColor);
            // 
            // btnBlueColor
            // 
            this.btnBlueColor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBlueColor.Location = new System.Drawing.Point(180, 161);
            this.btnBlueColor.Name = "btnBlueColor";
            this.btnBlueColor.Size = new System.Drawing.Size(43, 35);
            this.btnBlueColor.TabIndex = 13;
            this.btnBlueColor.UseVisualStyleBackColor = false;
            this.btnBlueColor.Click += new System.EventHandler(this.BtnGetColor);
            // 
            // btnYellowColor
            // 
            this.btnYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.btnYellowColor.Location = new System.Drawing.Point(229, 161);
            this.btnYellowColor.Name = "btnYellowColor";
            this.btnYellowColor.Size = new System.Drawing.Size(43, 35);
            this.btnYellowColor.TabIndex = 14;
            this.btnYellowColor.UseVisualStyleBackColor = false;
            this.btnYellowColor.Click += new System.EventHandler(this.BtnGetColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Color";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYellowColor);
            this.Controls.Add(this.btnBlueColor);
            this.Controls.Add(this.btnGreenColor);
            this.Controls.Add(this.btnRedColor);
            this.Controls.Add(this.txtWorker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtInformation);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorker;
        private System.Windows.Forms.Button btnRedColor;
        private System.Windows.Forms.Button btnGreenColor;
        private System.Windows.Forms.Button btnBlueColor;
        private System.Windows.Forms.Button btnYellowColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}