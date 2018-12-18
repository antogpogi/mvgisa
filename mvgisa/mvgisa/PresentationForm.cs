using mvgisa.extensions;
using Opulos.Core.UI;
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
    public partial class PresentationForm : Form
    {
        string KRAId = "";
        public PresentationForm()
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

        private void KRA_Click(object sender, EventArgs e)
        {
            KRAId = ((LinkLabel)sender).AccessibleDescription;
            lblKRANme.Text = ((LinkLabel)sender).Text;
            AccordionSet();
        }

        private void fcl_Click(object sender, EventArgs e)
        {
            PDFViewer pd = new PDFViewer();
            controls.flowChartName = ((LinkLabel)sender).AccessibleDescription;
            pd.ShowDialog();
        }

        private void AccordionSet()
        {
            accIndicator.SuspendLayout();
            accIndicator.Controls.Clear();
            accIndicator.CheckBoxMargin = new Padding(1);
            accIndicator.ContentMargin = new Padding(15, 5, 15, 5);
            accIndicator.ContentPadding = new Padding(1);
            accIndicator.Insets = new Padding(5);
            accIndicator.AddResizeBars = false;
            accIndicator.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            DataTable dtIndi, dtCrit, dtElement, dtFlow, dtFlowLines = new DataTable();
            dtIndi = extensions.SQLiteDatabaseCommand.itemsList("tblIndicator", KRAId);
           
            int e = 0;

            e = 0;
            foreach (DataRow row in dtIndi.Rows)
            {
                Accordion accCritiria = new Accordion();
                accCritiria.Margin = new System.Windows.Forms.Padding(5);
                accCritiria.CheckBoxMargin = new Padding(2);
                accCritiria.ContentMargin = new Padding(15, 5, 15, 5);
                accCritiria.ContentPadding = new Padding(1);
                accCritiria.Insets = new Padding(5);
                accCritiria.FillHeight = false;
                accCritiria.OpenOneOnly = true;
                accCritiria.AddResizeBars = false;
                accCritiria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                dtCrit = extensions.SQLiteDatabaseCommand.itemsList("tblCritiria", dtIndi.Rows[e][3].ToString());
                int c = 0;
                foreach (DataRow rowC in dtCrit.Rows)
                {
                    Accordion accElement = new Accordion();
                    accElement.Margin = new System.Windows.Forms.Padding(5);
                    accElement.CheckBoxMargin = new Padding(2);
                    accElement.ContentMargin = new Padding(15, 5, 15, 5);
                    accElement.ContentPadding = new Padding(1);
                    accElement.Insets = new Padding(5);
                    accElement.FillHeight = false;
                    accElement.OpenOneOnly = true;
                    accElement.AddResizeBars = false;
                    accElement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dtElement = extensions.SQLiteDatabaseCommand.itemsList("tblElement", dtCrit.Rows[c][2].ToString());
                    int el = 0;
                    foreach (DataRow rowE in dtElement.Rows)
                    {
                        
                        Accordion accFlowChart = new Accordion();
                        accFlowChart.Margin = new System.Windows.Forms.Padding(5);
                        accFlowChart.CheckBoxMargin = new Padding(2);
                        accFlowChart.ContentMargin = new Padding(15, 5, 15, 5);
                        accFlowChart.ContentPadding = new Padding(1);
                        accFlowChart.Insets = new Padding(5);
                        accFlowChart.FillHeight = false;
                        accFlowChart.OpenOneOnly = true;
                        accFlowChart.AddResizeBars = false;
                        accFlowChart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dtFlow = extensions.SQLiteDatabaseCommand.itemsList("tblFlowChart", dtElement.Rows[el][2].ToString());
                        int f = 0;
                        foreach (DataRow rowF in dtFlow.Rows)
                        {
                           
                            Accordion accFlowChartLines = new Accordion();
                            accFlowChartLines.Margin = new System.Windows.Forms.Padding(5);
                            accFlowChartLines.CheckBoxMargin = new Padding(2);
                            accFlowChartLines.ContentMargin = new Padding(15, 5, 15, 5);
                            accFlowChartLines.ContentPadding = new Padding(1);
                            accFlowChartLines.Insets = new Padding(5);
                            accFlowChartLines.FillHeight = false;
                            accFlowChartLines.OpenOneOnly = true;
                            accFlowChartLines.AddResizeBars = false;
                            accFlowChartLines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            dtFlowLines = extensions.SQLiteDatabaseCommand.getFlowChartLines(dtFlow.Rows[f][2].ToString());
                            int fl = 0;
                            TableLayoutPanel tlp = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(5) };
                            tlp.Dock = DockStyle.Fill;
                            foreach (DataRow rowFL in dtFlowLines.Rows)
                            {
                                LinkLabel lnkLbl = new LinkLabel();
                                lnkLbl.Name = "lnkLabel" + dtFlowLines.Rows[fl][2].ToString();
                                lnkLbl.Text = "Open";
                                lnkLbl.AccessibleDescription = dtFlowLines.Rows[fl][0].ToString();
                                lnkLbl.Click += new EventHandler(fcl_Click);
                                lnkLbl.AutoSize = true;
                                tlp.TabStop = true;
                                tlp.Controls.Add(new Label() { Text = dtFlowLines.Rows[fl][2].ToString(), AutoSize = true, TextAlign = ContentAlignment.BottomLeft, Font =  new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }, 0, fl);
                                tlp.Controls.Add(lnkLbl, 1, fl);
                                fl++;
                            }
                            accFlowChart.Add(tlp, dtFlow.Rows[f][1].ToString(), dtFlow.Rows[f][1].ToString(), 1, true);
                            accFlowChart.Close();
                            accFlowChart.OpenOnAdd = false;
                            f++;
                        }
                        accElement.Add(accFlowChart, dtElement.Rows[el][1].ToString(), dtElement.Rows[el][1].ToString(), 1, true);
                        accElement.Close();
                        accElement.OpenOnAdd = false;
                        el++;
                    }
                    accCritiria.Add(accElement, dtCrit.Rows[c][1].ToString(), dtCrit.Rows[c][1].ToString(), 1, true);
                    accCritiria.Close();
                    accIndicator.OpenOnAdd = false;
                    c++;
                }
                accIndicator.ResumeLayout(true);
                accIndicator.Add(accCritiria, dtIndi.Rows[e][2].ToString() + ": " + dtIndi.Rows[e][1].ToString(), dtIndi.Rows[e][2].ToString() + ": " + dtIndi.Rows[e][1].ToString(), 1, true);
                accIndicator.Close();
                accIndicator.OpenOnAdd = false;
                e++;
            }
            
        }

        private void PresentationForm_Load(object sender, EventArgs e)
        {
            KRAList();
        }
    }
}
