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
    public partial class panelCritiria : UserControl
    {
        public panelCritiria()
        {
            InitializeComponent();
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

        private void kryptonTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            extensions.controls.resizeTextBox(sender);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Control control = ((KryptonButton)sender).Parent;
            Control nxtControl = control.Parent;
            control.Parent.Height = control.Parent.Height - 284;
            nxtControl.Parent.Height = nxtControl.Parent.Height - 284;
            this.Dispose();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            controls.uploadPicture(lblFilename);
        }
    }
}
