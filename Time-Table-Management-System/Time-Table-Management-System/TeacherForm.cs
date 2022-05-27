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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            FromDatabase f = new FromDatabase();
            string[] teacher = f.GetTeacher();
            cmbTeacher.Items.Clear();
            BatchCheckedListBox1.Items.Clear();
            foreach (string t in teacher)
            {
                cmbTeacher.Items.Add(t);
            }
            string[] course = f.GetCourses();
            foreach (string c in course)
            {
                BatchCheckedListBox1.Items.Add(c);
            }
        }

        private void pnlTeacher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTeacher.Text = cmbTeacher.Text;
            FromDatabase f = new FromDatabase();
            string[] course = f.GetTeacherCourses(cmbTeacher.Text);
            BatchCheckedListBox2.Items.Clear();
            foreach (string c in course)
            {
                BatchCheckedListBox2.Items.Add(c);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FromDatabase f = new FromDatabase();
            for (int i = 0; i < BatchCheckedListBox1.Items.Count; i++)
            {
                if (BatchCheckedListBox1.GetItemChecked(i))
                {
                    BatchCheckedListBox2.Items.Add(BatchCheckedListBox1.Items[i].ToString());
                    BatchCheckedListBox1.SetItemChecked(i, false);
                }
            }
            f.DeleteTeacherCourse(cmbTeacher.Text);
            for (int i = 0; i < BatchCheckedListBox2.Items.Count; i++)
            {
                f.AddTeacherCourse(BatchCheckedListBox2.Items[i].ToString(), cmbTeacher.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FromDatabase f = new FromDatabase();
            f.DeleteTeacherCourse(cmbTeacher.Text);
            for (int i = 0; i < BatchCheckedListBox2.Items.Count; i++)
            {
                if (!BatchCheckedListBox2.GetItemChecked(i))
                {
                    f.AddTeacherCourse(BatchCheckedListBox2.Items[i].ToString(), cmbTeacher.Text);
                }
                else
                {
                    BatchCheckedListBox2.Items.RemoveAt(i);
                }
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {

        }
    }
}
