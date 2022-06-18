namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.toStudent = new System.Windows.Forms.Button();
            this.toProgram = new System.Windows.Forms.Button();
            this.dg3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNum = new System.Windows.Forms.TextBox();
            this.courseName = new System.Windows.Forms.TextBox();
            this.credit = new System.Windows.Forms.TextBox();
            this.dg4 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addCourse = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // toStudent
            // 
            this.toStudent.Location = new System.Drawing.Point(18, 163);
            this.toStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStudent.Name = "toStudent";
            this.toStudent.Size = new System.Drawing.Size(190, 35);
            this.toStudent.TabIndex = 0;
            this.toStudent.Text = "Go To Student";
            this.toStudent.UseVisualStyleBackColor = true;
            this.toStudent.Click += new System.EventHandler(this.toStudent_Click);
            // 
            // toProgram
            // 
            this.toProgram.Location = new System.Drawing.Point(18, 118);
            this.toProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toProgram.Name = "toProgram";
            this.toProgram.Size = new System.Drawing.Size(190, 35);
            this.toProgram.TabIndex = 1;
            this.toProgram.Text = "Go To Program";
            this.toProgram.UseVisualStyleBackColor = true;
            this.toProgram.Click += new System.EventHandler(this.toProgram_Click);
            // 
            // dg3
            // 
            this.dg3.AllowUserToAddRows = false;
            this.dg3.AllowUserToDeleteRows = false;
            this.dg3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg3.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg3.Location = new System.Drawing.Point(436, 89);
            this.dg3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg3.MultiSelect = false;
            this.dg3.Name = "dg3";
            this.dg3.ReadOnly = true;
            this.dg3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg3.Size = new System.Drawing.Size(305, 285);
            this.dg3.TabIndex = 2;
            this.dg3.Click += new System.EventHandler(this.dg3_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Credit:";
            // 
            // courseNum
            // 
            this.courseNum.Enabled = false;
            this.courseNum.Location = new System.Drawing.Point(224, 105);
            this.courseNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseNum.Name = "courseNum";
            this.courseNum.Size = new System.Drawing.Size(194, 26);
            this.courseNum.TabIndex = 6;
            // 
            // courseName
            // 
            this.courseName.Enabled = false;
            this.courseName.Location = new System.Drawing.Point(224, 165);
            this.courseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(194, 26);
            this.courseName.TabIndex = 7;
            // 
            // credit
            // 
            this.credit.Enabled = false;
            this.credit.Location = new System.Drawing.Point(224, 225);
            this.credit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(194, 26);
            this.credit.TabIndex = 8;
            // 
            // dg4
            // 
            this.dg4.AllowUserToAddRows = false;
            this.dg4.AllowUserToDeleteRows = false;
            this.dg4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg4.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg4.Location = new System.Drawing.Point(750, 89);
            this.dg4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg4.MultiSelect = false;
            this.dg4.Name = "dg4";
            this.dg4.ReadOnly = true;
            this.dg4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg4.Size = new System.Drawing.Size(336, 285);
            this.dg4.TabIndex = 9;
            this.dg4.Click += new System.EventHandler(this.dg4_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Course Table:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Students Courses:";
            // 
            // addCourse
            // 
            this.addCourse.Location = new System.Drawing.Point(222, 275);
            this.addCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(196, 45);
            this.addCourse.TabIndex = 12;
            this.addCourse.Text = "Add Course";
            this.addCourse.UseVisualStyleBackColor = true;
            this.addCourse.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add a Course";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 277);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1099, 414);
            this.Controls.Add(this.addCourse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dg4);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg3);
            this.Controls.Add(this.toProgram);
            this.Controls.Add(this.toStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cousre Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toStudent;
        private System.Windows.Forms.DataGridView dg3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseNum;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.DataGridView dg4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.Button toProgram;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}