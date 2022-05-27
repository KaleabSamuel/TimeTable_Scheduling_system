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
    public partial class AddBatch : Form
    {
        public AddBatch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FromDatabase f = new FromDatabase();
            if (!(txtName.Text.Equals("") || txtNo.Text.Equals("")))
            {
                f.AddBatch(txtName.Text, int.Parse(txtNo.Text));
            }
            else
            {
                MessageBox.Show("You Did Not Fill All the Fields!!");
            }
            this.Close();
        }
    }
}
