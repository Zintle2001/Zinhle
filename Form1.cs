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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormSetup(Form myForm)
        {
         if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            Form childForm = new Form2();
            childForm.MidParnt() = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();

        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            FormSetup(form2);
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            FormSetup(form3);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }