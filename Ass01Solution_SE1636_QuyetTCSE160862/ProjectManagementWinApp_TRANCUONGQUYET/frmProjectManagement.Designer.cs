namespace ProjectManagementWinApp_TRANCUONGQUYET
{
    partial class frmProjectManagement
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
            label8 = new System.Windows.Forms.Label();
            tbProjectID = new System.Windows.Forms.TextBox();
            tbProjectDes = new System.Windows.Forms.TextBox();
            tbProjectAddress = new System.Windows.Forms.TextBox();
            tbProjectName = new System.Windows.Forms.TextBox();
            tbProjectCity = new System.Windows.Forms.TextBox();
            dgvProjectList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            dtEEndDAte = new System.Windows.Forms.DateTimePicker();
            dtEStartDate = new System.Windows.Forms.DateTimePicker();
            entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(197, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(300, 34);
            label1.TabIndex = 0;
            label1.Text = "PROJECT MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Project ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(378, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Project Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(33, 216);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = " ProjectAddress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(33, 159);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "EstimatedStartDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(378, 162);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(106, 15);
            label6.TabIndex = 5;
            label6.Text = "EstimatedEndDate ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(378, 219);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 15);
            label7.TabIndex = 6;
            label7.Text = "ProjectCity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(35, 275);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(104, 15);
            label8.TabIndex = 7;
            label8.Text = "ProjectDescription";
            // 
            // tbProjectID
            // 
            tbProjectID.Enabled = false;
            tbProjectID.Location = new System.Drawing.Point(155, 108);
            tbProjectID.Name = "tbProjectID";
            tbProjectID.ReadOnly = true;
            tbProjectID.Size = new System.Drawing.Size(213, 23);
            tbProjectID.TabIndex = 8;
            // 
            // tbProjectDes
            // 
            tbProjectDes.Location = new System.Drawing.Point(155, 272);
            tbProjectDes.Name = "tbProjectDes";
            tbProjectDes.ReadOnly = true;
            tbProjectDes.Size = new System.Drawing.Size(555, 23);
            tbProjectDes.TabIndex = 10;
            // 
            // tbProjectAddress
            // 
            tbProjectAddress.Location = new System.Drawing.Point(155, 213);
            tbProjectAddress.Name = "tbProjectAddress";
            tbProjectAddress.ReadOnly = true;
            tbProjectAddress.Size = new System.Drawing.Size(213, 23);
            tbProjectAddress.TabIndex = 13;
            // 
            // tbProjectName
            // 
            tbProjectName.Location = new System.Drawing.Point(498, 109);
            tbProjectName.Name = "tbProjectName";
            tbProjectName.ReadOnly = true;
            tbProjectName.Size = new System.Drawing.Size(212, 23);
            tbProjectName.TabIndex = 14;
            // 
            // tbProjectCity
            // 
            tbProjectCity.Location = new System.Drawing.Point(498, 213);
            tbProjectCity.Name = "tbProjectCity";
            tbProjectCity.ReadOnly = true;
            tbProjectCity.Size = new System.Drawing.Size(212, 23);
            tbProjectCity.TabIndex = 16;
            // 
            // dgvProjectList
            // 
            dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectList.Location = new System.Drawing.Point(35, 369);
            dgvProjectList.Name = "dgvProjectList";
            dgvProjectList.RowTemplate.Height = 25;
            dgvProjectList.Size = new System.Drawing.Size(675, 206);
            dgvProjectList.TabIndex = 17;
            dgvProjectList.CellContentClick += dgvProjectList_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(83, 324);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(75, 23);
            btnLoad.TabIndex = 18;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(332, 324);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(602, 324);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(332, 593);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(75, 23);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtEEndDAte
            // 
            dtEEndDAte.Enabled = false;
            dtEEndDAte.Location = new System.Drawing.Point(498, 156);
            dtEEndDAte.Name = "dtEEndDAte";
            dtEEndDAte.Size = new System.Drawing.Size(212, 23);
            dtEEndDAte.TabIndex = 22;
            // 
            // dtEStartDate
            // 
            dtEStartDate.Enabled = false;
            dtEStartDate.Location = new System.Drawing.Point(155, 156);
            dtEStartDate.Name = "dtEStartDate";
            dtEStartDate.Size = new System.Drawing.Size(212, 23);
            dtEStartDate.TabIndex = 23;
            // 
            // frmProjectManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(753, 639);
            Controls.Add(dtEStartDate);
            Controls.Add(dtEEndDAte);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(dgvProjectList);
            Controls.Add(tbProjectCity);
            Controls.Add(tbProjectName);
            Controls.Add(tbProjectAddress);
            Controls.Add(tbProjectDes);
            Controls.Add(tbProjectID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProjectManagement";
            Text = "frmProjectManagement";
            Load += frmProjectManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbProjectID;
        private System.Windows.Forms.TextBox tbProjectDes;
        private System.Windows.Forms.TextBox tbProjectAddress;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbProjectCity;
        private System.Windows.Forms.DataGridView dgvProjectList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtEEndDAte;
        private System.Windows.Forms.DateTimePicker dtEStartDate;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
    }
}