
namespace Time_Table_Management_System
{
    partial class TeacherForm
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
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BatchCheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.BatchCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.pnlTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTeacher.Controls.Add(this.btnAddTeacher);
            this.pnlTeacher.Controls.Add(this.cmbTeacher);
            this.pnlTeacher.Controls.Add(this.button2);
            this.pnlTeacher.Controls.Add(this.btnAdd);
            this.pnlTeacher.Controls.Add(this.label2);
            this.pnlTeacher.Controls.Add(this.label1);
            this.pnlTeacher.Controls.Add(this.BatchCheckedListBox2);
            this.pnlTeacher.Controls.Add(this.BatchCheckedListBox1);
            this.pnlTeacher.Controls.Add(this.lblTeacher);
            this.pnlTeacher.Location = new System.Drawing.Point(0, 0);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(786, 500);
            this.pnlTeacher.TabIndex = 0;
            this.pnlTeacher.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTeacher_Paint);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Location = new System.Drawing.Point(641, 12);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(133, 27);
            this.btnAddTeacher.TabIndex = 19;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(12, 23);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(190, 21);
            this.cmbTeacher.TabIndex = 18;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(396, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(233, 461);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 27);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Teaches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "All";
            // 
            // BatchCheckedListBox2
            // 
            this.BatchCheckedListBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BatchCheckedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchCheckedListBox2.FormattingEnabled = true;
            this.BatchCheckedListBox2.Location = new System.Drawing.Point(396, 106);
            this.BatchCheckedListBox2.Name = "BatchCheckedListBox2";
            this.BatchCheckedListBox2.Size = new System.Drawing.Size(378, 349);
            this.BatchCheckedListBox2.TabIndex = 13;
            // 
            // BatchCheckedListBox1
            // 
            this.BatchCheckedListBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BatchCheckedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchCheckedListBox1.FormattingEnabled = true;
            this.BatchCheckedListBox1.Location = new System.Drawing.Point(12, 106);
            this.BatchCheckedListBox1.Name = "BatchCheckedListBox1";
            this.BatchCheckedListBox1.Size = new System.Drawing.Size(354, 349);
            this.BatchCheckedListBox1.TabIndex = 12;
            // 
            // lblTeacher
            // 
            this.lblTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(340, 56);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(90, 26);
            this.lblTeacher.TabIndex = 11;
            this.lblTeacher.Text = "Teacher";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 500);
            this.Controls.Add(this.pnlTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox BatchCheckedListBox2;
        private System.Windows.Forms.CheckedListBox BatchCheckedListBox1;
        private System.Windows.Forms.Label lblTeacher;
        public System.Windows.Forms.Panel pnlTeacher;
    }
}