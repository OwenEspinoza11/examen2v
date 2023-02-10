using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen2V
{
    public partial class MDI : Form
    {
        Form1 ut = new Form1();

        public MDI()
        {
            InitializeComponent();
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ut.MdiParent = this;
            ut.Show();
        }
    }
}
