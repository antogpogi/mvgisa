using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace mvgisa
{
    public partial class PresentationForm : Form
    {
        public PresentationForm()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            KryptonDropButton db = new KryptonDropButton();
            db.Dock = DockStyle.Left;
            db.Width = this.flowLayoutPanel1.Width;
            db.Height = 50;
            db.ButtonStyle = ButtonStyle.ListItem;
            db.ForeColor = Color.Black;
            db.StateNormal.Border.Color1 = Color.Cyan;
            db.StateNormal.Border.DrawBorders = PaletteDrawBorders.All;
            db.StateNormal.Border.ColorAlign = PaletteRectangleAlign.Inherit;

            KryptonButton db1 = new KryptonButton();
            db1.Dock = DockStyle.Right;
            db1.Width = this.flowLayoutPanel1.Width - 50;
            db1.Height = 50;
            db1.ButtonStyle = ButtonStyle.ListItem;

            this.flowLayoutPanel1.Controls.Add(db);
            this.flowLayoutPanel1.Controls.Add(db1);
            this.flowLayoutPanel1.Controls.SetChildIndex(db1, 1);
        }

        private void kryptonDropButton4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
