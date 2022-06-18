namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.programNum = new System.Windows.Forms.TextBox();
            this.programName = new System.Windows.Forms.TextBox();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.toStudent = new System.Windows.Forms.Button();
            this.toCourse = new System.Windows.Forms.Button();
            this.enrollButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.myProg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(250, 72);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "ProgramId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program Name:";
            // 
            // programNum
            // 
            this.programNum.Enabled = false;
            this.programNum.Location = new System.Drawing.Point(254, 97);
            this.programNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programNum.Name = "programNum";
            this.programNum.Size = new System.Drawing.Size(216, 26);
            this.programNum.TabIndex = 2;
            // 
            // programName
            // 
            this.programName.Enabled = false;
            this.programName.Location = new System.Drawing.Point(254, 163);
            this.programName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(216, 26);
            this.programName.TabIndex = 3;
            // 
            // dg2
            // 
            this.dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(522, 90);
            this.dg2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg2.MultiSelect = false;
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg2.Size = new System.Drawing.Size(452, 282);
            this.dg2.TabIndex = 4;
            this.dg2.Click += new System.EventHandler(this.dg2_click);
            // 
            // toStudent
            // 
            this.toStudent.Location = new System.Drawing.Point(14, 156);
            this.toStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStudent.Name = "toStudent";
            this.toStudent.Size = new System.Drawing.Size(190, 45);
            this.toStudent.TabIndex = 5;
            this.toStudent.Text = "Go To Student";
            this.toStudent.UseVisualStyleBackColor = true;
            this.toStudent.Click += new System.EventHandler(this.toStudent_Click);
            // 
            // toCourse
            // 
            this.toCourse.Location = new System.Drawing.Point(14, 103);
            this.toCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toCourse.Name = "toCourse";
            this.toCourse.Size = new System.Drawing.Size(190, 45);
            this.toCourse.TabIndex = 6;
            this.toCourse.Text = "Go To Course";
            this.toCourse.UseVisualStyleBackColor = true;
            this.toCourse.Click += new System.EventHandler(this.toCourse_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(254, 273);
            this.enrollButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(216, 91);
            this.enrollButton.TabIndex = 7;
            this.enrollButton.Text = "Enroll/Switch";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "My Current Program";
            // 
            // myProg
            // 
            this.myProg.Enabled = false;
            this.myProg.Location = new System.Drawing.Point(254, 222);
            this.myProg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myProg.Name = "myProg";
            this.myProg.Size = new System.Drawing.Size(216, 26);
            this.myProg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Program Table:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Assign Program";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 414);
            this.Controls.Add(this.myProg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.programName);
            this.Controls.Add(this.programNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toCourse);
            this.Controls.Add(this.toStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progarm Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox programNum;
        private System.Windows.Forms.TextBox programName;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Button toStudent;
        private System.Windows.Forms.Button toCourse;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox myProg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}