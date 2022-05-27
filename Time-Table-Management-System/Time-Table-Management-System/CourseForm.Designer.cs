
namespace Time_Table_Management_System
{
    partial class CourseForm
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
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BatchCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pnlCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCourse
            // 
            this.pnlCourse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCourse.Controls.Add(this.txtCourseName);
            this.pnlCourse.Controls.Add(this.label3);
            this.pnlCourse.Controls.Add(this.label2);
            this.pnlCourse.Controls.Add(this.txtCourseCode);
            this.pnlCourse.Controls.Add(this.button2);
            this.pnlCourse.Controls.Add(this.btnAdd);
            this.pnlCourse.Controls.Add(this.label1);
            this.pnlCourse.Controls.Add(this.BatchCheckedListBox1);
            this.pnlCourse.Location = new System.Drawing.Point(0, 0);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(786, 500);
            this.pnlCourse.TabIndex = 0;
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(458, 236);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(301, 23);
            this.txtCourseName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Number:";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseCode.Location = new System.Drawing.Point(458, 171);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(301, 23);
            this.txtCourseCode.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(233, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(543, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 27);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Courses";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BatchCheckedListBox1
            // 
            this.BatchCheckedListBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BatchCheckedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchCheckedListBox1.FormattingEnabled = true;
            this.BatchCheckedListBox1.Location = new System.Drawing.Point(12, 46);
            this.BatchCheckedListBox1.Name = "BatchCheckedListBox1";
            this.BatchCheckedListBox1.Size = new System.Drawing.Size(354, 409);
            this.BatchCheckedListBox1.TabIndex = 21;
            this.BatchCheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.BatchCheckedListBox1_SelectedIndexChanged);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 500);
            this.Controls.Add(this.pnlCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.pnlCourse.ResumeLayout(false);
            this.pnlCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox BatchCheckedListBox1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseCode;
        public System.Windows.Forms.Panel pnlCourse;
    }
}