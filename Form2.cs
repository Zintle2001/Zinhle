using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical_one
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sale1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmsale1 = new Form2();
            PrepareForm(frmsale1);
        }
    }
}
