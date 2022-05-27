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
    public partial class BatchForm : Form
    {
        public BatchForm()
        {
            InitializeComponent();
            FromDatabase f = new FromDatabase();
            string[] batch = f.GetBatch();
            cmbBatch.Items.Clear();
            BatchCheckedListBox1.Items.Clear();
            foreach (string b in batch)
            {
                cmbBatch.Items.Add(b);
            }
            string[] course = f.GetCourses();
            foreach(string c in course)
            {
                BatchCheckedListBox1.Items.Add(c);
            }
        }

        private void pnlBatch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBatch.Text = cmbBatch.Text;
            FromDatabase f = new FromDatabase();
            string[] course = f.GetBatchCourses(cmbBatch.Text);
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
            f.DeleteCoursesTaken(cmbBatch.Text);
            for(int i = 0; i < BatchCheckedListBox2.Items.Count; i++)
            {
                f.AddCourseTaken(BatchCheckedListBox2.Items[i].ToString(), cmbBatch.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FromDatabase f = new FromDatabase();
            f.DeleteCoursesTaken(cmbBatch.Text);
            for (int i = 0; i < BatchCheckedListBox2.Items.Count; i++)
            {
                if (!BatchCheckedListBox2.GetItemChecked(i))
                {
                    f.AddCourseTaken(BatchCheckedListBox2.Items[i].ToString(), cmbBatch.Text);
                }
                else
                {
                    BatchCheckedListBox2.Items.RemoveAt(i);
                }
            }
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            AddBatch ad = new AddBatch();
            ad.Show();
        }
    }
}
