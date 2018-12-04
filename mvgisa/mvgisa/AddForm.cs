using ComponentFactory.Krypton.Toolkit;
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
        bool oddCrit = false;
        bool oddElem = false;
        bool oddSOE = false;

        public AddForm()
        {
            InitializeComponent();
        }

        private void addIndicator(Control parentControl)
        {
            KryptonPanel panelIndicatorPrefab = new KryptonPanel();
            panelIndicatorPrefab.Controls.Add(addCrit());
            panelIndicatorPrefab.Controls.Add(addIndiHead());
            panelIndicatorPrefab.Dock = System.Windows.Forms.DockStyle.Top;
            panelIndicatorPrefab.Location = new System.Drawing.Point(0, 0);
            panelIndicatorPrefab.Name = "panelIndictor2";
            panelIndicatorPrefab.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            panelIndicatorPrefab.Size = new System.Drawing.Size(654, 366);
            panelIndicatorPrefab.TabIndex = 0;

            Control placer = parentControl;

            placer.Controls.Add(panelIndicatorPrefab);
            placer.Controls.SetChildIndex(panelIndicatorPrefab, 0);
        }

        private KryptonPanel addCrit()
        {
            // 
            // panelCrit
            // 
            KryptonPanel panelCritPref = new KryptonPanel();
            panelCritPref.Controls.Add(addElement());
            panelCritPref.Controls.Add(addCritHead());
            panelCritPref.Dock = System.Windows.Forms.DockStyle.Top;
            panelCritPref.Name = "panelCrit";
            panelCritPref.Size = new System.Drawing.Size(654, 266);
            panelCritPref.TabIndex = 21;
            return panelCritPref;
        }

        private KryptonPanel addElement()
        {
            // 
            // panelElement
            // 
            KryptonPanel panelElementPref = new KryptonPanel();
            panelElementPref.Controls.Add(addSourceOfEvid());
            panelElementPref.Controls.Add(addElementHead());
            panelElementPref.Dock = System.Windows.Forms.DockStyle.Top;
            panelElementPref.Location = new System.Drawing.Point(0, 94);
            panelElementPref.Name = "panelElement";
            panelElementPref.Size = new System.Drawing.Size(654, 172);
            panelElementPref.TabIndex = 24;
            return panelElementPref;
        }

        private KryptonPanel addElementHead()
        {
            // 
            // kryptonTextBox3
            // 
            KryptonTextBox txtElemH = new KryptonTextBox();
            txtElemH.Location = new System.Drawing.Point(224, 13);
            txtElemH.Name = "kryptonTextBox3";
            txtElemH.Size = new System.Drawing.Size(380, 27);
            txtElemH.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtElemH.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtElemH.TabIndex = 20;
            // 
            // kryptonLabel6
            // 
            KryptonLabel lblElemH = new KryptonLabel();
            lblElemH.Location = new System.Drawing.Point(33, 12);
            lblElemH.Name = "kryptonLabel6";
            lblElemH.Size = new System.Drawing.Size(89, 28);
            lblElemH.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblElemH.TabIndex = 8;
            lblElemH.Values.Text = "Element";
            // 
            // kryptonButton2
            // 
            KryptonButton btnElemH = new KryptonButton();
            btnElemH.Location = new System.Drawing.Point(39, 46);
            btnElemH.Name = "kryptonButton2";
            btnElemH.Size = new System.Drawing.Size(226, 29);
            btnElemH.TabIndex = 12;
            btnElemH.Values.Text = "Add Source of Evidence";
            btnElemH.Click += new System.EventHandler(AddSOE_Click);
            // 
            // panelElementHead
            // 
            KryptonPanel panelElementHeadPref = new KryptonPanel();
            panelElementHeadPref.Controls.Add(txtElemH);
            panelElementHeadPref.Controls.Add(lblElemH);
            panelElementHeadPref.Controls.Add(btnElemH);
            panelElementHeadPref.Dock = System.Windows.Forms.DockStyle.Top;
            panelElementHeadPref.Location = new System.Drawing.Point(0, 0);
            panelElementHeadPref.Name = "panelElementHead";
            panelElementHeadPref.Size = new System.Drawing.Size(654, 84);
            if (oddElem)
            { panelElementHeadPref.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke; }
            else
            { panelElementHeadPref.StateNormal.Color1 = System.Drawing.Color.White; }
            if (oddElem)
            {
                oddElem = false;
            }
            else
            {
                oddElem = true;
            }
            panelElementHeadPref.TabIndex = 24;
            return panelElementHeadPref;
        }

        private KryptonPanel addSourceOfEvid()
        {
            // 
            // kryptonButton1
            // 
            KryptonButton btnSOEOpen = new KryptonButton();
            btnSOEOpen.Location = new System.Drawing.Point(420, 9);
            btnSOEOpen.Name = "kryptonButton1";
            btnSOEOpen.Size = new System.Drawing.Size(116, 35);
            btnSOEOpen.TabIndex = 14;
            btnSOEOpen.Values.Text = "Open";
            // 
            // kryptonLabel1
            // 
            KryptonLabel lblSOEPage = new KryptonLabel();
            lblSOEPage.Location = new System.Drawing.Point(149, 50);
            lblSOEPage.Name = "kryptonLabel1";
            lblSOEPage.Size = new System.Drawing.Size(62, 24);
            lblSOEPage.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSOEPage.TabIndex = 23;
            lblSOEPage.Values.Text = "Pages";
            // 
            // kryptonLabel2
            // 
            KryptonLabel lblSOEFrom = new KryptonLabel();
            lblSOEFrom.Location = new System.Drawing.Point(223, 50);
            lblSOEFrom.Name = "kryptonLabel2";
            lblSOEFrom.Size = new System.Drawing.Size(53, 24);
            lblSOEFrom.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSOEFrom.TabIndex = 16;
            lblSOEFrom.Values.Text = "From";
            // 
            // kryptonTextBox1
            // 
            KryptonTextBox txtSOEFrom = new KryptonTextBox();
            txtSOEFrom.Location = new System.Drawing.Point(451, 51);
            txtSOEFrom.Name = "kryptonTextBox1";
            txtSOEFrom.Size = new System.Drawing.Size(116, 27);
            txtSOEFrom.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSOEFrom.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSOEFrom.TabIndex = 22;
            // 
            // kryptonLabel3
            // 
            KryptonLabel lblSOETo = new KryptonLabel();
            lblSOETo.Location = new System.Drawing.Point(412, 50);
            lblSOETo.Name = "kryptonLabel3";
            lblSOETo.Size = new System.Drawing.Size(33, 24);
            lblSOETo.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSOETo.TabIndex = 18;
            lblSOETo.Values.Text = "To";
            // 
            // kryptonTextBox2
            // 
            KryptonTextBox txtSOETo = new KryptonTextBox();
            txtSOETo.Location = new System.Drawing.Point(282, 51);
            txtSOETo.Name = "kryptonTextBox2";
            txtSOETo.Size = new System.Drawing.Size(116, 27);
            txtSOETo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSOETo.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtSOETo.TabIndex = 21;
            // 
            // kryptonLabel4
            // 
            KryptonLabel lblSOEDocFN = new KryptonLabel();
            lblSOEDocFN.Location = new System.Drawing.Point(223, 16);
            lblSOEDocFN.Name = "kryptonLabel4";
            lblSOEDocFN.Size = new System.Drawing.Size(191, 28);
            lblSOEDocFN.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSOEDocFN.TabIndex = 13;
            lblSOEDocFN.Values.Text = "Document filename";
            // 
            // kryptonLabel5
            // 
            KryptonLabel lblSOE = new KryptonLabel();
            lblSOE.Location = new System.Drawing.Point(26, 16);
            lblSOE.Name = "kryptonLabel5";
            lblSOE.Size = new System.Drawing.Size(191, 28);
            lblSOE.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSOE.TabIndex = 10;
            lblSOE.Values.Text = "Source of Evidence";

            // 
            // panelSourceOfEvid
            // 

            KryptonPanel panelSourceOfEvidPref = new KryptonPanel();
            panelSourceOfEvidPref.Controls.Add(btnSOEOpen);
            panelSourceOfEvidPref.Controls.Add(lblSOEPage);
            panelSourceOfEvidPref.Controls.Add(lblSOEFrom);
            panelSourceOfEvidPref.Controls.Add(txtSOEFrom);
            panelSourceOfEvidPref.Controls.Add(lblSOETo);
            panelSourceOfEvidPref.Controls.Add(txtSOETo);
            panelSourceOfEvidPref.Controls.Add(lblSOEDocFN);
            panelSourceOfEvidPref.Controls.Add(lblSOE);
            panelSourceOfEvidPref.Dock = System.Windows.Forms.DockStyle.Top;
            panelSourceOfEvidPref.Location = new System.Drawing.Point(0, 84);
            panelSourceOfEvidPref.Name = "panelSourceOfEvid";
            panelSourceOfEvidPref.Size = new System.Drawing.Size(654, 88);
            if (oddSOE)
            { panelSourceOfEvidPref.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke; }
            else
            { panelSourceOfEvidPref.StateNormal.Color1 = System.Drawing.Color.White; }
            if (oddSOE)
            {
                oddSOE = false;
            }
            else
            {
                oddSOE = true;
            }
            panelSourceOfEvidPref.TabIndex = 25;
            return panelSourceOfEvidPref;
        }

        private KryptonPanel addCritHead()
        {
            
            // 
            // kryptonTextBox4
            // 
            KryptonTextBox txtCritH1 = new KryptonTextBox();
            txtCritH1.Location = new System.Drawing.Point(227, 16);
            txtCritH1.Name = "txtCritH1";
            txtCritH1.Size = new System.Drawing.Size(376, 23);
            txtCritH1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCritH1.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCritH1.TabIndex = 0;
            // 
            // kryptonButton3
            // 
            KryptonButton btnCritH1 = new KryptonButton();
            btnCritH1.Location = new System.Drawing.Point(39, 50);
            btnCritH1.Name = "btnCritH1";
            btnCritH1.Size = new System.Drawing.Size(138, 25);
            btnCritH1.TabIndex = 0;
            btnCritH1.Values.Text = "Add Element";
            btnCritH1.Click += new System.EventHandler(btnAddElement_Click);
            // 
            // kryptonLabel7
            // 
            KryptonLabel lblCritH1 = new KryptonLabel();
            lblCritH1.Location = new System.Drawing.Point(36, 16);
            lblCritH1.Name = "lblCritH1";
            lblCritH1.Size = new System.Drawing.Size(76, 24);
            lblCritH1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCritH1.TabIndex = 0;
            lblCritH1.Values.Text = "Criteria";

            // 
            // panelCritHead
            // 
            KryptonPanel panelCritHeadPref = new KryptonPanel();
            panelCritHeadPref.Controls.Add(txtCritH1);
            panelCritHeadPref.Controls.Add(btnCritH1);
            panelCritHeadPref.Controls.Add(lblCritH1);
            panelCritHeadPref.Dock = System.Windows.Forms.DockStyle.Top;
            panelCritHeadPref.Location = new System.Drawing.Point(0, 0);
            panelCritHeadPref.Name = "panelCritHead1";
            panelCritHeadPref.Size = new System.Drawing.Size(655, 100);
            if (oddCrit)
            { panelCritHeadPref.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke; }
            else
            { panelCritHeadPref.StateNormal.Color1 = System.Drawing.Color.White; }
            if (oddCrit)
            {
                oddCrit = false;
            }
            else
            {
                oddCrit = true;
            }
            panelCritHeadPref.TabIndex = 19;
            return panelCritHeadPref;
        }

        private KryptonPanel addIndiHead()
        {
            // 
            // kryptonTextBox5
            // 
            KryptonTextBox indiTxt1 = new KryptonTextBox();
            indiTxt1.Location = new System.Drawing.Point(227, 22);
            indiTxt1.Name = "kryptonTextBox5";
            indiTxt1.Size = new System.Drawing.Size(380, 27);
            indiTxt1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            indiTxt1.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            indiTxt1.TabIndex = 2;
            // 
            // kryptonLabel8
            // 
            KryptonLabel indiLbl1 = new KryptonLabel();
            indiLbl1.Location = new System.Drawing.Point(36, 21);
            indiLbl1.Name = "kryptonLabel8";
            indiLbl1.Size = new System.Drawing.Size(144, 28);
            indiLbl1.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            indiLbl1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            indiLbl1.TabIndex = 0;
            indiLbl1.Values.Text = "Indicator Type";
            // 
            // kryptonButton4
            // 
            KryptonButton indiBtn = new KryptonButton();
            indiBtn.Location = new System.Drawing.Point(36, 55);
            indiBtn.Name = "kryptonButton4";
            indiBtn.Size = new System.Drawing.Size(142, 29);
            indiBtn.TabIndex = 4;
            indiBtn.Values.Text = "Add Criteria";
            indiBtn.Click += new System.EventHandler(btnAddCrti_Click);

            // 
            // panelIndicatorHead
            // 
            KryptonPanel panelIndicatorHeadPref = new KryptonPanel();
            panelIndicatorHeadPref.Controls.Add(indiTxt1);
            panelIndicatorHeadPref.Controls.Add(indiLbl1);
            panelIndicatorHeadPref.Controls.Add(indiBtn);
            panelIndicatorHeadPref.Dock = System.Windows.Forms.DockStyle.Top;
            panelIndicatorHeadPref.Location = new System.Drawing.Point(0, 0);
            panelIndicatorHeadPref.Name = "panelIndicatorHead";
            panelIndicatorHeadPref.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowList;
            panelIndicatorHeadPref.Size = new System.Drawing.Size(654, 100);
            panelIndicatorHeadPref.StateNormal.Color1 = System.Drawing.Color.ForestGreen;
            panelIndicatorHeadPref.StateNormal.Color2 = System.Drawing.Color.DarkGreen;
            panelIndicatorHeadPref.TabIndex = 19;

            return panelIndicatorHeadPref;
        }

        private void btnCoreIndi_Click(object sender, EventArgs e)
        {
            addIndicator(FormPanel);
        }

        private Control addControl(KryptonPanel panel, object sender, int height)
        {
            KryptonPanel addThis = panel;
            Control button = (KryptonButton)sender;
            Control control = button.Parent;
            Control panelToAdd = control.Parent;
            panelToAdd.Controls.Add(addThis);
            panelToAdd.Controls.SetChildIndex(addThis, 0);
            panelToAdd.Height = panelToAdd.Height + height;
            return panelToAdd;
        }

        private void btnAddCrti_Click(object sender, EventArgs e)
        {
            addControl(addCrit(), sender, 266);
        }

        private void btnAddElement_Click(object sender, EventArgs e)
        {
            Control baseControl = addControl(addElement(), sender, 172);
            Control parentControl = baseControl.Parent;
            parentControl.Height = parentControl.Height + 172;
        }

        private void AddSOE_Click(object sender, EventArgs e)
        {
            Control baseControl = addControl(addSourceOfEvid(), sender, 88);
            Control nextControl = baseControl.Parent;
            nextControl.Height = nextControl.Height + 88;
            Control parentControl = nextControl.Parent;
            parentControl.Height = parentControl.Height + 88;
        }
    }
}
