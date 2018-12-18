using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using mvgisa.extensions;

namespace mvgisa
{
    public partial class panelIndicator : UserControl
    {
        public panelIndicator()
        {
            InitializeComponent();
        }

        private void btnAddCrti_Click(object sender, EventArgs e)
        {
            extensions.controls.changeName(sender);
            extensions.controls.addCrit_Click(sender);
        }
        private void btnAddElement_Click(object sender, EventArgs e)
        {
            extensions.controls.changeName(sender);
            extensions.controls.addElement_Click(sender);
        }

        private void AddSOE_Click(object sender, EventArgs e)
        {
            extensions.controls.changeName(sender);
            extensions.controls.AddSOE_Click(sender);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            extensions.controls.openFlowChart(sender);
        }

        private void kryptonTextBox5_TextChanged_1(object sender, EventArgs e)
        {
            extensions.controls.resizeTextBox(sender);
        }

        private void panelIndicator_Load(object sender, EventArgs e)
        {
            lblIndiName.Text = extensions.controls.indicator;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Control parentControl = ((KryptonButton)sender).Parent;
            parentControl.Parent.Height = parentControl.Parent.Height - 384;
            this.Dispose();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            controls.uploadPicture(lblFilename);
        }
    }
}
