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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FromDatabase f = new FromDatabase();
            if (!(txtId.Text.Equals("") || txtName.Text.Equals("")))
            {
                f.AddTeacher(txtName.Text, int.Parse(txtId.Text));
            }
            else
            {
                MessageBox.Show("You Did Not Fill All the Fields!!");
            }
            this.Close();
        }
    }
}
