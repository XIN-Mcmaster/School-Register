namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.TextBox();
            this.studentFirstName = new System.Windows.Forms.TextBox();
            this.studentLastName = new System.Windows.Forms.TextBox();
            this.insertStudent = new System.Windows.Forms.Button();
            this.updateStudent = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.toProgram = new System.Windows.Forms.Button();
            this.toCourse = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updateDB = new System.Windows.Forms.Button();
            this.StudentInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(226, 100);
            this.studentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(194, 26);
            this.studentId.TabIndex = 3;
            this.studentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentId_KeyPress);
            // 
            // studentFirstName
            // 
            this.studentFirstName.Location = new System.Drawing.Point(227, 160);
            this.studentFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentFirstName.Name = "studentFirstName";
            this.studentFirstName.Size = new System.Drawing.Size(194, 26);
            this.studentFirstName.TabIndex = 4;
            this.studentFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentFirstName_KeyPress);
            // 
            // studentLastName
            // 
            this.studentLastName.Location = new System.Drawing.Point(226, 223);
            this.studentLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.Size = new System.Drawing.Size(194, 26);
            this.studentLastName.TabIndex = 5;
            this.studentLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentLastName_KeyPress);
            // 
            // insertStudent
            // 
            this.insertStudent.Location = new System.Drawing.Point(225, 262);
            this.insertStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertStudent.Name = "insertStudent";
            this.insertStudent.Size = new System.Drawing.Size(196, 35);
            this.insertStudent.TabIndex = 6;
            this.insertStudent.Text = "Insert Student";
            this.insertStudent.UseVisualStyleBackColor = true;
            this.insertStudent.Click += new System.EventHandler(this.insertStudent_Click);
            // 
            // updateStudent
            // 
            this.updateStudent.Enabled = false;
            this.updateStudent.Location = new System.Drawing.Point(225, 309);
            this.updateStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Size = new System.Drawing.Size(196, 35);
            this.updateStudent.TabIndex = 7;
            this.updateStudent.Text = "Update Student Info";
            this.updateStudent.UseVisualStyleBackColor = true;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Enabled = false;
            this.deleteStudent.Location = new System.Drawing.Point(226, 354);
            this.deleteStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(196, 35);
            this.deleteStudent.TabIndex = 8;
            this.deleteStudent.Text = "Delete Student Reocrd";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeColumns = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dg1.Location = new System.Drawing.Point(442, 79);
            this.dg1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(480, 288);
            this.dg1.TabIndex = 9;
            this.dg1.Click += new System.EventHandler(this.dg1_click);
            // 
            // toProgram
            // 
            this.toProgram.Enabled = false;
            this.toProgram.Location = new System.Drawing.Point(18, 159);
            this.toProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toProgram.Name = "toProgram";
            this.toProgram.Size = new System.Drawing.Size(190, 45);
            this.toProgram.TabIndex = 10;
            this.toProgram.Text = "Go To Program";
            this.toProgram.UseVisualStyleBackColor = true;
            this.toProgram.Click += new System.EventHandler(this.toProgram_Click);
            // 
            // toCourse
            // 
            this.toCourse.Enabled = false;
            this.toCourse.Location = new System.Drawing.Point(18, 102);
            this.toCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toCourse.Name = "toCourse";
            this.toCourse.Size = new System.Drawing.Size(190, 45);
            this.toCourse.TabIndex = 11;
            this.toCourse.Text = "Go To Course";
            this.toCourse.UseVisualStyleBackColor = true;
            this.toCourse.Click += new System.EventHandler(this.toCourse_Click);
            // 
            // updateDB
            // 
            this.updateDB.Enabled = false;
            this.updateDB.Location = new System.Drawing.Point(595, 377);
            this.updateDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateDB.Name = "updateDB";
            this.updateDB.Size = new System.Drawing.Size(191, 51);
            this.updateDB.TabIndex = 12;
            this.updateDB.Text = "Update Database";
            this.updateDB.UseVisualStyleBackColor = true;
            this.updateDB.Click += new System.EventHandler(this.updateDB_Click);
            // 
            // StudentInfo
            // 
            this.StudentInfo.Location = new System.Drawing.Point(18, 216);
            this.StudentInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.Size = new System.Drawing.Size(190, 45);
            this.StudentInfo.TabIndex = 14;
            this.StudentInfo.Text = "Info";
            this.StudentInfo.UseVisualStyleBackColor = true;
            this.StudentInfo.Click += new System.EventHandler(this.studentInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Register a Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 325);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 442);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.updateStudent);
            this.Controls.Add(this.insertStudent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentInfo);
            this.Controls.Add(this.updateDB);
            this.Controls.Add(this.toCourse);
            this.Controls.Add(this.toProgram);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.studentLastName);
            this.Controls.Add(this.studentFirstName);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.TextBox studentFirstName;
        private System.Windows.Forms.TextBox studentLastName;
        private System.Windows.Forms.Button insertStudent;
        private System.Windows.Forms.Button updateStudent;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button toProgram;
        private System.Windows.Forms.Button toCourse;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button updateDB;
        private System.Windows.Forms.Button StudentInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

