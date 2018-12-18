using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvgisa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openForm(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            form.ControlBox = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Show();

        }

        public void OpenForm(Form form)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Dispose();
                openForm(form);
            }
            else
            {
                openForm(form);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.ShowDialog();
        }

        private void presentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation2Form pf = new Presentation2Form();
            OpenForm(pf);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentsForm df = new DocumentsForm();
            OpenForm(df);
        }
    }
}
