
namespace Time_Table_Management_System
{
    partial class BatchForm
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
            this.pnlBatch = new System.Windows.Forms.Panel();
            this.lblBatch = new System.Windows.Forms.Label();
            this.BatchCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BatchCheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.pnlBatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBatch
            // 
            this.pnlBatch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBatch.Controls.Add(this.btnAddBatch);
            this.pnlBatch.Controls.Add(this.cmbBatch);
            this.pnlBatch.Controls.Add(this.button2);
            this.pnlBatch.Controls.Add(this.btnAdd);
            this.pnlBatch.Controls.Add(this.label2);
            this.pnlBatch.Controls.Add(this.label1);
            this.pnlBatch.Controls.Add(this.BatchCheckedListBox2);
            this.pnlBatch.Controls.Add(this.BatchCheckedListBox1);
            this.pnlBatch.Controls.Add(this.lblBatch);
            this.pnlBatch.Location = new System.Drawing.Point(0, 0);
            this.pnlBatch.Name = "pnlBatch";
            this.pnlBatch.Size = new System.Drawing.Size(786, 500);
            this.pnlBatch.TabIndex = 0;
            this.pnlBatch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBatch_Paint);
            // 
            // lblBatch
            // 
            this.lblBatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(326, 54);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(68, 26);
            this.lblBatch.TabIndex = 2;
            this.lblBatch.Text = "Batch";
            // 
            // BatchCheckedListBox1
            // 
            this.BatchCheckedListBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BatchCheckedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchCheckedListBox1.FormattingEnabled = true;
            this.BatchCheckedListBox1.Location = new System.Drawing.Point(12, 106);
            this.BatchCheckedListBox1.Name = "BatchCheckedListBox1";
            this.BatchCheckedListBox1.Size = new System.Drawing.Size(354, 349);
            this.BatchCheckedListBox1.TabIndex = 3;
            // 
            // BatchCheckedListBox2
            // 
            this.BatchCheckedListBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BatchCheckedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchCheckedListBox2.FormattingEnabled = true;
            this.BatchCheckedListBox2.Location = new System.Drawing.Point(396, 106);
            this.BatchCheckedListBox2.Name = "BatchCheckedListBox2";
            this.BatchCheckedListBox2.Size = new System.Drawing.Size(378, 349);
            this.BatchCheckedListBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Takes";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(233, 461);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 27);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(396, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbBatch
            // 
            this.cmbBatch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(12, 23);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(190, 21);
            this.cmbBatch.TabIndex = 9;
            this.cmbBatch.SelectedIndexChanged += new System.EventHandler(this.cmbBatch_SelectedIndexChanged);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnAddBatch.FlatAppearance.BorderSize = 0;
            this.btnAddBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBatch.Location = new System.Drawing.Point(641, 12);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(133, 27);
            this.btnAddBatch.TabIndex = 10;
            this.btnAddBatch.Text = "Add Batch";
            this.btnAddBatch.UseVisualStyleBackColor = false;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // BatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 500);
            this.Controls.Add(this.pnlBatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatchForm";
            this.Text = "BatchForm";
            this.pnlBatch.ResumeLayout(false);
            this.pnlBatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlBatch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox BatchCheckedListBox2;
        private System.Windows.Forms.CheckedListBox BatchCheckedListBox1;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.ComboBox cmbBatch;
    }
}