namespace StudentClass
{
    partial class FrmStudent
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.NudGrade = new System.Windows.Forms.NumericUpDown();
            this.LblGrade = new System.Windows.Forms.Label();
            this.LblGPA = new System.Windows.Forms.Label();
            this.TxtGPA = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblMajor = new System.Windows.Forms.Label();
            this.CbxMajor = new System.Windows.Forms.ComboBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.LblStudentID = new System.Windows.Forms.Label();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LbxStudents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(49, 3);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(375, 65);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Student Class Exercise\r\n- July 2020 -";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(49, 138);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(86, 20);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(49, 161);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(162, 29);
            this.TxtFirstName.TabIndex = 2;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(236, 161);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(188, 29);
            this.TxtLastName.TabIndex = 4;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(236, 138);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(86, 20);
            this.LblLastName.TabIndex = 3;
            this.LblLastName.Text = "Last Name";
            // 
            // NudGrade
            // 
            this.NudGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudGrade.Location = new System.Drawing.Point(108, 215);
            this.NudGrade.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NudGrade.Minimum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.NudGrade.Name = "NudGrade";
            this.NudGrade.Size = new System.Drawing.Size(59, 29);
            this.NudGrade.TabIndex = 5;
            this.NudGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudGrade.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // LblGrade
            // 
            this.LblGrade.AutoSize = true;
            this.LblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrade.Location = new System.Drawing.Point(49, 219);
            this.LblGrade.Name = "LblGrade";
            this.LblGrade.Size = new System.Drawing.Size(54, 20);
            this.LblGrade.TabIndex = 6;
            this.LblGrade.Text = "Grade";
            // 
            // LblGPA
            // 
            this.LblGPA.AutoSize = true;
            this.LblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGPA.Location = new System.Drawing.Point(298, 219);
            this.LblGPA.Name = "LblGPA";
            this.LblGPA.Size = new System.Drawing.Size(43, 20);
            this.LblGPA.TabIndex = 7;
            this.LblGPA.Text = "GPA";
            // 
            // TxtGPA
            // 
            this.TxtGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGPA.Location = new System.Drawing.Point(341, 215);
            this.TxtGPA.Name = "TxtGPA";
            this.TxtGPA.Size = new System.Drawing.Size(83, 29);
            this.TxtGPA.TabIndex = 10;
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(226, 215);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(59, 29);
            this.TxtAge.TabIndex = 8;
            this.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.Location = new System.Drawing.Point(185, 219);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(38, 20);
            this.LblAge.TabIndex = 9;
            this.LblAge.Text = "Age";
            // 
            // LblMajor
            // 
            this.LblMajor.AutoSize = true;
            this.LblMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMajor.Location = new System.Drawing.Point(49, 277);
            this.LblMajor.Name = "LblMajor";
            this.LblMajor.Size = new System.Drawing.Size(48, 20);
            this.LblMajor.TabIndex = 11;
            this.LblMajor.Text = "Major";
            this.LblMajor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CbxMajor
            // 
            this.CbxMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMajor.FormattingEnabled = true;
            this.CbxMajor.Items.AddRange(new object[] {
            "Actuarial Mathematics",
            "Aeronautics & Astronautics",
            "Applied Economics and Management",
            "Business Analysis",
            "Electrical Engineering & Computer Science",
            "Electrical Power Engineering",
            "Operations Research",
            "Petroleum Engineering",
            "Pharmacy",
            "Political Economy"});
            this.CbxMajor.Location = new System.Drawing.Point(108, 273);
            this.CbxMajor.Name = "CbxMajor";
            this.CbxMajor.Size = new System.Drawing.Size(316, 28);
            this.CbxMajor.TabIndex = 12;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(49, 333);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(81, 36);
            this.BtnCreate.TabIndex = 13;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(127, 103);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(87, 20);
            this.LblID.TabIndex = 14;
            this.LblID.Text = "Student ID";
            // 
            // LblStudentID
            // 
            this.LblStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStudentID.Location = new System.Drawing.Point(236, 98);
            this.LblStudentID.Name = "LblStudentID";
            this.LblStudentID.Size = new System.Drawing.Size(105, 29);
            this.LblStudentID.TabIndex = 15;
            this.LblStudentID.Text = "12345";
            this.LblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRead
            // 
            this.BtnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRead.Location = new System.Drawing.Point(147, 333);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(81, 36);
            this.BtnRead.TabIndex = 16;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(245, 333);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(81, 36);
            this.BtnUpdate.TabIndex = 17;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(343, 333);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(81, 36);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // LbxStudents
            // 
            this.LbxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxStudents.FormattingEnabled = true;
            this.LbxStudents.ItemHeight = 20;
            this.LbxStudents.Location = new System.Drawing.Point(12, 395);
            this.LbxStudents.Name = "LbxStudents";
            this.LbxStudents.Size = new System.Drawing.Size(456, 204);
            this.LbxStudents.TabIndex = 19;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 617);
            this.Controls.Add(this.LbxStudents);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.LblStudentID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.CbxMajor);
            this.Controls.Add(this.LblMajor);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.TxtGPA);
            this.Controls.Add(this.LblGPA);
            this.Controls.Add(this.LblGrade);
            this.Controls.Add(this.NudGrade);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmStudent";
            this.Text = "Student Class by Joseph Fischetti";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.NumericUpDown NudGrade;
        private System.Windows.Forms.Label LblGrade;
        private System.Windows.Forms.Label LblGPA;
        private System.Windows.Forms.TextBox TxtGPA;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblMajor;
        private System.Windows.Forms.ComboBox CbxMajor;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblStudentID;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ListBox LbxStudents;
    }
}

