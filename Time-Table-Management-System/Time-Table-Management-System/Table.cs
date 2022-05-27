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
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Display(Class classes)
        {
            int column = int.Parse(classes.Schedule[0].ToString()) -1;
            int row = int.Parse(classes.Schedule[1].ToString()) -1;
            Panel p = new Panel();
            Label l = new Label();
            l.AutoSize = false;
            l.Font = new Font("", 11);
            p.Dock = DockStyle.Fill;
            l.Dock = DockStyle.Fill;
            p.AutoSize = false;
            l.Text = classes.Course + "\n" + classes.Room;
            l.TextAlign = ContentAlignment.MiddleCenter;
            p.Controls.Add(l);
            //Console.WriteLine(column + " " + row);
            tableLayoutPanel1.GetControlFromPosition(column, row).Controls.Add(p);

            
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }
    }
}
