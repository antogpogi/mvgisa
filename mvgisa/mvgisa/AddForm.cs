using ComponentFactory.Krypton.Toolkit;
using mvgisa.extensions;
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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnCoreIndi_Click(object sender, EventArgs e)
        {
            extensions.controls.indicatorId += 1;
            extensions.controls.indicator = "Core Indicator";
            extensions.controls.addCoreIndi_Click(sender, FormPanel, true);
        }

        private void btnIndi_Click(object sender, EventArgs e)
        {
            extensions.controls.indicatorId += 1;
            extensions.controls.indicator = "Indicator";
            extensions.controls.addCoreIndi_Click(sender, FormPanel, false);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            controls.flowList.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            extensions.controls.KRA = extensions.SQLiteDatabaseCommand.newKRA(txtKRA.Text);
            foreach (RichTextBox tb in extensions.controls.GetAll(this, typeof(RichTextBox)))
            {
                try
                {
                    string name = tb.Name;
                    int indx = name.IndexOfAny("0123456789".ToCharArray());
                    int len = name.Length - indx;
                    string path = name.Substring(indx, len);
                    name = name.Substring(0, indx);
                    path = extensions.controls.KRA + "_" + path;
                    switch (name)
                    {
                        case "txtCore Indicator":
                            extensions.SQLiteDatabaseCommand.insertNodeIndicator("tblIndicator", tb.Text, path, "Core Indicator");
                            break;

                        case "txtIndicator":
                            extensions.SQLiteDatabaseCommand.insertNodeIndicator("tblIndicator", tb.Text, path, "Indicator");
                            break;

                        case "txtFlowChart":
                            extensions.SQLiteDatabaseCommand.insertNodes("tblFlowChart", tb.Text, path);
                            break;

                        case "txtElement":
                            extensions.SQLiteDatabaseCommand.insertNodes("tblElement", tb.Text, path);
                            break;

                        case "txtCritiria":
                            extensions.SQLiteDatabaseCommand.insertNodes("tblCritiria", tb.Text, path);
                            break;
                    }
                }
                catch { }
            }
            SQLiteDatabaseCommand.insertFlowLines();
            this.Close();
        } 
    }
}
