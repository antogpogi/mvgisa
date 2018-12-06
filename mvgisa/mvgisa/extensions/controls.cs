using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvgisa.extensions
{
    class controls
    {
        public static void addCoreIndi_Click(object sender, Control control, bool isCore)
        {
            panelIndicator pi = new panelIndicator();
            pi.Dock = DockStyle.Top;
            control.Controls.Add(pi);
            control.Controls.SetChildIndex(pi, 0);
        }

        public static void addCrit_Click(object sender)
        {
            panelCritiria c = new panelCritiria();
            c.Dock = DockStyle.Top;
            Control control = ((KryptonButton)sender).Parent;
            control.Parent.Controls.Add(c);
            control.Parent.Controls.SetChildIndex(c, 0);
            control.Parent.Height = control.Parent.Height + 220;
        }

        public static void addElement_Click(object sender)
        {
            panelElement el = new panelElement();
            el.Dock = DockStyle.Top;
            Control parentControl = ((KryptonButton)sender).Parent;
            Control grandParentControl = parentControl.Parent;
            parentControl.Parent.Controls.Add(el);
            parentControl.Parent.Controls.SetChildIndex(el, 0);
            parentControl.Parent.Height = parentControl.Parent.Height + 125;
            grandParentControl.Parent.Height = grandParentControl.Parent.Height + 125;
        }

        public static void AddSOE_Click(object sender)
        {
            panelFlow f = new panelFlow();
            f.Dock = DockStyle.Top;
            Control parentControl = ((KryptonButton)sender).Parent;
            Control grandParentControl = parentControl.Parent;
            Control greatGrandParentControl = grandParentControl.Parent;
            parentControl.Parent.Controls.Add(f);
            parentControl.Parent.Controls.SetChildIndex(f, 0);
            parentControl.Parent.Height = parentControl.Parent.Height + 75;
            grandParentControl.Parent.Height = grandParentControl.Parent.Height + 75;
            greatGrandParentControl.Parent.Height = greatGrandParentControl.Parent.Height + 75;
        }
    }
}
