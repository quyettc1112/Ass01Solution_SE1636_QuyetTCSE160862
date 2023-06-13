namespace ProjectManagementWinApp_TRANCUONGQUYET
{
    partial class frmProjectDetail
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tbProjectID = new System.Windows.Forms.TextBox();
            tbProjectName = new System.Windows.Forms.TextBox();
            tbProjectDes = new System.Windows.Forms.TextBox();
            tbProjectAddress = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            mEStartDate = new System.Windows.Forms.MaskedTextBox();
            mEEndDate = new System.Windows.Forms.MaskedTextBox();
            tbProjectCTy = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Project ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Project Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(32, 178);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Project Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(32, 298);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Estimate End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(32, 242);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Estimate Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(32, 429);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Project Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(32, 366);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(68, 15);
            label7.TabIndex = 6;
            label7.Text = "Project City";
            // 
            // tbProjectID
            // 
            tbProjectID.Location = new System.Drawing.Point(196, 54);
            tbProjectID.Name = "tbProjectID";
            tbProjectID.Size = new System.Drawing.Size(267, 23);
            tbProjectID.TabIndex = 7;
            // 
            // tbProjectName
            // 
            tbProjectName.Location = new System.Drawing.Point(196, 119);
            tbProjectName.Name = "tbProjectName";
            tbProjectName.Size = new System.Drawing.Size(267, 23);
            tbProjectName.TabIndex = 8;
            // 
            // tbProjectDes
            // 
            tbProjectDes.Location = new System.Drawing.Point(196, 175);
            tbProjectDes.Name = "tbProjectDes";
            tbProjectDes.Size = new System.Drawing.Size(267, 23);
            tbProjectDes.TabIndex = 9;
            // 
            // tbProjectAddress
            // 
            tbProjectAddress.Location = new System.Drawing.Point(196, 426);
            tbProjectAddress.Name = "tbProjectAddress";
            tbProjectAddress.Size = new System.Drawing.Size(267, 23);
            tbProjectAddress.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(196, 477);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "&Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(388, 477);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "&Close";
            button2.UseVisualStyleBackColor = true;
            // 
            // mEStartDate
            // 
            mEStartDate.Location = new System.Drawing.Point(196, 242);
            mEStartDate.Mask = "00/00/0000";
            mEStartDate.Name = "mEStartDate";
            mEStartDate.Size = new System.Drawing.Size(267, 23);
            mEStartDate.TabIndex = 16;
            mEStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // mEEndDate
            // 
            mEEndDate.Location = new System.Drawing.Point(196, 295);
            mEEndDate.Mask = "00/00/0000";
            mEEndDate.Name = "mEEndDate";
            mEEndDate.Size = new System.Drawing.Size(267, 23);
            mEEndDate.TabIndex = 17;
            mEEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbProjectCTy
            // 
            tbProjectCTy.Location = new System.Drawing.Point(196, 363);
            tbProjectCTy.Name = "tbProjectCTy";
            tbProjectCTy.Size = new System.Drawing.Size(267, 23);
            tbProjectCTy.TabIndex = 18;
            // 
            // frmProjectDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(554, 521);
            Controls.Add(tbProjectCTy);
            Controls.Add(mEEndDate);
            Controls.Add(mEStartDate);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbProjectAddress);
            Controls.Add(tbProjectDes);
            Controls.Add(tbProjectName);
            Controls.Add(tbProjectID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProjectDetail";
            Text = "frmProjectDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProjectID;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbProjectDes;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbProjectAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mEStartDate;
        private System.Windows.Forms.MaskedTextBox mEEndDate;
        private System.Windows.Forms.TextBox tbProjectCTy;
    }
}