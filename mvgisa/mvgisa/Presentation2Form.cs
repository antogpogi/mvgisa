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
    public partial class Presentation2Form : Form
    {
        string KRAId = "";
        int indx = 0;
        DataTable dtCritiria = new DataTable();
        DataTable dtElement = new DataTable();
        DataTable dtFlowChart = new DataTable();

        public Presentation2Form()
        {
            InitializeComponent();
        }

        private void KRAList()
        {
            DataTable dt = extensions.SQLiteDatabaseCommand.dataList("tblKRA");
            int x = 0;
            foreach (DataRow row in dt.Rows)
            {
                LinkLabel lnklbl = new LinkLabel();
                lnklbl.SuspendLayout();
                lnklbl.AutoSize = true;
                lnklbl.Font = new System.Drawing.Font("Century Gothic", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lnklbl.Location = new System.Drawing.Point(30, 20);
                lnklbl.Margin = new System.Windows.Forms.Padding(30, 20, 30, 0);
                lnklbl.Name = "linkLabel" + x;
                lnklbl.ForeColor = Color.White;
                lnklbl.LinkColor = Color.White;
                lnklbl.Padding = new System.Windows.Forms.Padding(3);
                lnklbl.Size = new System.Drawing.Size(200, 48);
                lnklbl.TabIndex = 0;
                lnklbl.TabStop = true;
                lnklbl.Text = dt.Rows[x][1].ToString();
                lnklbl.AccessibleDescription = dt.Rows[x][0].ToString();
                lnklbl.Click += new EventHandler(KRA_Click);
                x++;
                lnklbl.ResumeLayout(false);
                flowLayoutPanelKRA.Controls.Add(lnklbl);
            }
        }
        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }

        private void load_Critiria()
        {
            cbCritiria.Items.Clear();
            dtCritiria = SQLiteDatabaseCommand.flowList("tblCritiria", KRAId);
            int x = 0;
            foreach (DataRow row in dtCritiria.Rows)
            {
                cbCritiria.Items.Add(dtCritiria.Rows[x][1].ToString());
                x++;
            }

            cbCritiria.DropDownWidth = DropDownWidth(cbCritiria);
        }

        private void load_Element()
        {
            cbElement.Items.Clear();
            indx = cbCritiria.SelectedIndex;
            dtElement = SQLiteDatabaseCommand.flowList("tblElement", dtCritiria.Rows[indx][2].ToString());
            int x = 0;
            foreach (DataRow row in dtElement.Rows)
            {
                cbElement.Items.Add(dtElement.Rows[x][1].ToString());
                x++;
            }

            cbElement.DropDownWidth = DropDownWidth(cbElement);
        }

        private void load_FlowChart()
        {
            cbPossibleOutcome.Items.Clear();
            indx = cbElement.SelectedIndex;
            dtFlowChart = SQLiteDatabaseCommand.flowList("tblFlowChart", dtElement.Rows[indx][2].ToString());
            int x = 0;
            foreach (DataRow row in dtElement.Rows)
            {
                cbPossibleOutcome.Items.Add(dtFlowChart.Rows[x][1].ToString());
                x++;
            }

            cbPossibleOutcome.DropDownWidth = DropDownWidth(cbPossibleOutcome);
        }

        private void KRA_Click(object sender, EventArgs e)
        {
            KRAId = ((LinkLabel)sender).AccessibleDescription;
            load_Critiria();
            cbElement.Items.Clear();
            cbPossibleOutcome.Items.Clear();
        }

        private void Presentation2Form_Load(object sender, EventArgs e)
        {
            KRAList();
        }

        private void cbCritiria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load_Element();
            cbPossibleOutcome.Items.Clear();
        }

        private void cbElement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load_FlowChart();
        }

    }
}
