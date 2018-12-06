using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            extensions.controls.AddSOE_Click(sender);
        }
    }
}
