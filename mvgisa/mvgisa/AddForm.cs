﻿using ComponentFactory.Krypton.Toolkit;
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

        private void btnCoreIndi_Click(object sender, EventArgs e)
        {
            extensions.controls.addCoreIndi_Click(sender, FormPanel, true);
        }

        private void btnIndi_Click(object sender, EventArgs e)
        {
            extensions.controls.addCoreIndi_Click(sender, FormPanel, false);
        }

        private void btnAddCrti_Click(object sender, EventArgs e)
        {
            extensions.controls.addCrit_Click(sender);
        }

        private void btnAddElement_Click(object sender, EventArgs e)
        {
            extensions.controls.addElement_Click(sender);
        }

        private void AddSOE_Click(object sender, EventArgs e)
        {
            extensions.controls.AddSOE_Click(sender);
        }

       
    }
}
