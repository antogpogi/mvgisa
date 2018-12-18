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
    public partial class panelFlow : UserControl
    {
        public panelFlow()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            extensions.controls.openFlowChart(sender);
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            extensions.controls.resizeTextBox(sender);
        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {
            extensions.controls.resizeTextBox(sender);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Control parentControl = ((KryptonButton)sender).Parent;
            Control grandParentControl = parentControl.Parent;
            Control greatGrandParentControl = grandParentControl.Parent;
            Control lastControl = greatGrandParentControl.Parent;
            parentControl.Parent.Height = parentControl.Parent.Height - 106;
            grandParentControl.Parent.Height = grandParentControl.Parent.Height - 106;
            greatGrandParentControl.Parent.Height = greatGrandParentControl.Parent.Height - 106;
            lastControl.Parent.Height = lastControl.Parent.Height - 106;
            this.Dispose();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            controls.uploadPicture(lblFilename);
        }
    }
}
