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
    public partial class FlowForm : Form
    {
        public FlowForm()
        {
            InitializeComponent();
        }

        private void FlowForm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {
            dataGridView1.AutoGenerateColumns = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(String));
            dt.Columns.Add("Document name", typeof(String));
            dt.Columns.Add("Start page", typeof(String));
            dt.Columns.Add("End page", typeof(String));

            DataGridViewTextBoxColumn startPage = new DataGridViewTextBoxColumn();
            startPage.Width = 70;
            startPage.HeaderText = "Start Page";
            startPage.DataPropertyName = "Start Page";

            DataGridViewTextBoxColumn endPage = new DataGridViewTextBoxColumn();
            endPage.Width = 70;
            endPage.HeaderText = "End Page";
            endPage.DataPropertyName = "End Page";

            DataGridViewComboBoxColumn documentName = new DataGridViewComboBoxColumn();
            DataTable dtList = SQLiteDatabaseCommand.dataList("tblDocument");
            dtList.Columns.Remove(dtList.Columns[0]);
            dtList.Columns.Remove(dtList.Columns[1]);
            int x = 0;
            List<string> items = new List<string>();
            foreach (DataRow row in dtList.Rows)
            {
                items.Add(dtList.Rows[x][0].ToString());
                x++;
            }
            documentName.DataSource = items;
            documentName.Width = 200;
            documentName.HeaderText = "Document Name";
            documentName.DataPropertyName = "DocumentName";

            DataGridViewTextBoxColumn title = new DataGridViewTextBoxColumn();
            title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            title.HeaderText = "Title";
            title.DataPropertyName = "Title";

            dataGridView1.DataSource = dt;
            dataGridView1.Columns.AddRange(title, documentName, startPage, endPage);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int indx = 0;
            int lastRow = dataGridView1.Rows.Count - 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (indx != lastRow)
                {
                    extensions.FlowChartItems ci = new extensions.FlowChartItems();
                    ci.flowNumber = extensions.controls.flowChartIndx;
                    ci.text = dataGridView1.Rows[indx].Cells[0].Value.ToString();
                    ci.documentName = dataGridView1.Rows[indx].Cells[1].Value.ToString();
                    ci.pageFrom = dataGridView1.Rows[indx].Cells[2].Value.ToString();
                    ci.pageTo = dataGridView1.Rows[indx].Cells[3].Value.ToString();
                    indx++;
                    extensions.controls.flowList.Add(ci);
                }
                else { break; }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
