using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using mvgisa.extensions;

namespace mvgisa
{
    public partial class PDFViewer : Form
    {
        public PDFViewer()
        {
            InitializeComponent();
        }

        private void PdFRead()
        {
            int Id = int.Parse(controls.flowChartName);
            
            DataTable dt = SQLiteDatabaseCommand.selectSearch("tblFlowChartLines", Id);

            string pdfSource = Application.StartupPath + @"\Documents\" + dt.Rows[0][3].ToString();
        }

        private void PDFViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
