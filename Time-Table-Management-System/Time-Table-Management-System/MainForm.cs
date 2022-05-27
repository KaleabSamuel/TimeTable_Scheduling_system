using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCurrent.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlCurrent.Visible = true;
            pnlCurrent.Location = new Point(0, 80);
            BatchForm b = new BatchForm();
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(b.pnlBatch);

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlCurrent.Visible = true;
            pnlCurrent.Location = new Point(0, 115);
            TeacherForm b = new TeacherForm();
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(b.pnlTeacher);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            pnlCurrent.Visible = true;
            pnlCurrent.Location = new Point(0, 151);
            CourseForm b = new CourseForm();
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(b.pnlCourse);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            GeneticAlgorithm a = new GeneticAlgorithm();
            Schedule s = a.test();
            TableForm tf = new TableForm();
            Table t = new Table();
            tf.flowLayoutPanel1.Controls.Clear();
            t.BatchName.Text = s.Classes[0].Batch;
            tf.flowLayoutPanel1.Controls.Add(t);
            int i = 0;
            do
            {
                t.Display(s.Classes[i]);
                if(i != 0 && s.Classes[i - 1].Batch != s.Classes[i].Batch)
                {
                    t = new Table();
                    t.BatchName.Text = s.Classes[i].Batch;
                    tf.flowLayoutPanel1.Controls.Add(t);
                }
                i++;
            } while (i < s.Classes.Count);
            pnlCurrent.Visible = true;
            pnlCurrent.Location = new Point(0, 427);
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(tf.pnlTable);
        }
    }
}
