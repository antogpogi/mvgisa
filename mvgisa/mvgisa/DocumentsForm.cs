using mvgisa.extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvgisa
{
    public partial class DocumentsForm : Form
    {
        public DocumentsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblFilename.Text = ofd.SafeFileName;
                lblFilename.AccessibleDescription = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Documents\";
            Directory.CreateDirectory(path);
            string filename = path + lblFilename.Text;
            if (lblFilename.Text != "" && txtDocName.Text != "")
            {
                if (!File.Exists(filename))
                {
                    File.Copy(lblFilename.AccessibleDescription, filename, true);
                }
                SQLiteDatabaseCommand.insertDocument(txtDocName.Text, filename);
                loadData();
            }
        }

        private void loadData()
        {
            try
            {
                DataTable dt = SQLiteDatabaseCommand.dataList("tblDocument");
                dt.Columns.Remove(dt.Columns[0]);
                dt.Columns.Remove(dt.Columns[1]);
                dataGridView1.DataSource = dt;
            }
            finally
            {
                dataGridView1.Refresh();
            }
        }

        private void DocumentsForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteDatabaseCommand.deleteDocument(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            loadData();
        }
    }
}
