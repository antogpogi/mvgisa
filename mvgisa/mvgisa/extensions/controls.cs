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
        public static int indicatorId { get; set; }
        public static string underNode { get; set; }
        public static int KRA { get; set; }
        public static string indicator { get; set; }
        public static string flowChartIndx { get; set; }
        public static string flowChartName { get; set; }

        public static List<FlowChartItems> flowList = new List<FlowChartItems>();

        public static void changeName(object sender)
        {
            string str = ((KryptonButton)sender).Name;
            int i = int.Parse(str.Substring(str.LastIndexOf('_') + 1)) + 1;
            int e = str.IndexOfAny("012346789".ToCharArray());
            int l = (str.LastIndexOf('_') + 1) - e;
            string x = str.Substring(e, l);
            ((KryptonButton)sender).Name = x + i;
            extensions.controls.underNode = x + i;
        }

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
            control.Parent.Height = control.Parent.Height + 284;
        }

        public static void addElement_Click(object sender)
        {
            panelElement el = new panelElement();
            el.Dock = DockStyle.Top;
            Control parentControl = ((KryptonButton)sender).Parent;
            Control grandParentControl = parentControl.Parent;
            parentControl.Parent.Controls.Add(el);
            parentControl.Parent.Controls.SetChildIndex(el, 0);
            parentControl.Parent.Height = parentControl.Parent.Height + 190;
            grandParentControl.Parent.Height = grandParentControl.Parent.Height + 190;
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
            parentControl.Parent.Height = parentControl.Parent.Height + 106;
            grandParentControl.Parent.Height = grandParentControl.Parent.Height + 106;
            greatGrandParentControl.Parent.Height = greatGrandParentControl.Parent.Height + 106;
        }

        public static void openFlowChart(object sender)
        {
            flowChartIndx = ((KryptonButton)sender).Name.Substring(12);
            FlowForm ff = new FlowForm();
            ff.ShowDialog();
        }

        public static void resizeTextBox(object sender)
        {
            ((RichTextBox)sender).SuspendLayout();
            ((RichTextBox)sender).Height = (((RichTextBox)sender).Lines.Count() + 2) * ((RichTextBox)sender).Font.Height;
            Control parent = ((RichTextBox)sender).Parent;
            int height = ((RichTextBox)sender).Height;
            parent.SuspendLayout();
            parent.Size = new System.Drawing.Size(0, 0);
            parent.AutoSize = true;
            parent.Padding = new Padding(0, 0, 0, 7);
            parent.ResumeLayout();
            ((RichTextBox)sender).ResumeLayout();
            while (parent.Name != "FormPanel")
            {
                parent = parent.Parent;
                if (parent.Name == "FormPanel") { break; }
                parent.SuspendLayout();
                parent.Size = new System.Drawing.Size(0, 0);
                parent.AutoSize = true;
                parent.ResumeLayout();
              
            }
            MessageBox.Show(((RichTextBox)sender).Name);
        }

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static void uploadPicture(Label lblFilename)
        {
            OpenFileDialog pfd = new OpenFileDialog();
            pfd.InitialDirectory = "c:\\";
            pfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            pfd.FilterIndex = 1;
            pfd.Multiselect = false;
            pfd.RestoreDirectory = true;
            if (pfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblFilename.Text = pfd.SafeFileName;
                lblFilename.AccessibleDescription = pfd.FileName;
            }
        }

        public static void disposeField(object sender)
        {

        }
    }
}
