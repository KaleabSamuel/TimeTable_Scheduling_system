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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            FromDatabase f = new FromDatabase();
            BatchCheckedListBox1.Items.Clear();
            string[] course = f.GetCourses();
            foreach (string c in course)
            {
                BatchCheckedListBox1.Items.Add(c);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BatchCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FromDatabase f = new FromDatabase();
            for (int i = 0; i < BatchCheckedListBox1.Items.Count; i++)
            {
                if (BatchCheckedListBox1.GetItemChecked(i))
                {
                    f.DeleteCourse(BatchCheckedListBox1.Items[i].ToString());
                    BatchCheckedListBox1.Items.RemoveAt(i);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FromDatabase f = new FromDatabase();
            if (!(txtCourseCode.Text.Equals("") || txtCourseName.Text.Equals("")))
            {
                f.AddCourse(txtCourseCode.Text, txtCourseName.Text);
            }
            else
            {
                MessageBox.Show("You Did Not Fill All the Fields!!");
            }
            BatchCheckedListBox1.Items.Clear();
            string[] course = f.GetCourses();
            foreach (string c in course)
            {
                BatchCheckedListBox1.Items.Add(c);
            }
        }
    }
}
