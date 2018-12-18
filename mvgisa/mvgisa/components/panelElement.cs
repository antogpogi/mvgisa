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

namespace mvgisa
{
    public partial class panelElement : UserControl
    {
        public panelElement()
        {
            InitializeComponent();
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

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {
            extensions.controls.resizeTextBox(sender);
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            extensions.controls.resizeTextBox(sender);
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            extensions.controls.resizeTextBox(sender);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Control parentControl = ((KryptonButton)sender).Parent;
            Control grandParentControl = parentControl.Parent;
            Control nxtControl = grandParentControl.Parent;
            parentControl.Parent.Height = parentControl.Parent.Height - 190;
            grandParentControl.Parent.Height = grandParentControl.Parent.Height - 190;
            nxtControl.Parent.Height = nxtControl.Parent.Height - 190;
            this.Dispose();
        }
    }
}
