using mvgisa.extensions;
namespace mvgisa
{
    partial class panelIndicator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelIndicatorHead = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtIndicator = new System.Windows.Forms.RichTextBox();
            this.lblIndiName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAddCrti = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelCrit = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelElement = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelSourceOfEvid = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFlowChart = new System.Windows.Forms.RichTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panelElementHead = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtElement = new System.Windows.Forms.RichTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.AddSOE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelCritHead = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtCritiria = new System.Windows.Forms.RichTextBox();
            this.btnAddElement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panelIndicatorHead)).BeginInit();
            this.panelIndicatorHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCrit)).BeginInit();
            this.panelCrit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelElement)).BeginInit();
            this.panelElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).BeginInit();
            this.panelSourceOfEvid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelElementHead)).BeginInit();
            this.panelElementHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCritHead)).BeginInit();
            this.panelCritHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIndicatorHead
            // 
            this.panelIndicatorHead.Controls.Add(this.kryptonButton2);
            this.panelIndicatorHead.Controls.Add(this.txtIndicator);
            this.panelIndicatorHead.Controls.Add(this.lblIndiName);
            this.panelIndicatorHead.Controls.Add(this.btnAddCrti);
            this.panelIndicatorHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIndicatorHead.Location = new System.Drawing.Point(0, 0);
            this.panelIndicatorHead.Name = "panelIndicatorHead";
            this.panelIndicatorHead.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowList;
            this.panelIndicatorHead.Size = new System.Drawing.Size(653, 100);
            this.panelIndicatorHead.StateNormal.Color1 = System.Drawing.Color.ForestGreen;
            this.panelIndicatorHead.StateNormal.Color2 = System.Drawing.Color.DarkGreen;
            this.panelIndicatorHead.TabIndex = 26;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(585, 3);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(27, 28);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 17;
            this.kryptonButton2.Values.Text = "-";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // txtIndicator
            // 
            this.txtIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndicator.Location = new System.Drawing.Point(208, 23);
            this.txtIndicator.Name = "txtIndicator" + controls.indicatorId;
            this.txtIndicator.Size = new System.Drawing.Size(359, 27);
            this.txtIndicator.TabIndex = 6;
            this.txtIndicator.Text = "";
            this.txtIndicator.TextChanged += new System.EventHandler(this.kryptonTextBox5_TextChanged_1);
            // 
            // lblIndiName
            // 
            this.lblIndiName.Location = new System.Drawing.Point(36, 21);
            this.lblIndiName.Name = "lblIndiName";
            this.lblIndiName.Size = new System.Drawing.Size(144, 28);
            this.lblIndiName.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblIndiName.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiName.TabIndex = 0;
            this.lblIndiName.Values.Text = "Indicator Type";
            // 
            // btnAddCrti
            // 
            this.btnAddCrti.Location = new System.Drawing.Point(36, 55);
            this.btnAddCrti.Name = "btnAddCrti" + controls.indicatorId + "_" + 1;
            this.btnAddCrti.Size = new System.Drawing.Size(142, 29);
            this.btnAddCrti.TabIndex = 4;
            this.btnAddCrti.Values.Text = "Add Criteria";
            this.btnAddCrti.Click += new System.EventHandler(this.btnAddCrti_Click);
            // 
            // panelCrit
            // 
            this.panelCrit.Controls.Add(this.panelElement);
            this.panelCrit.Controls.Add(this.panelCritHead);
            this.panelCrit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrit.Location = new System.Drawing.Point(0, 100);
            this.panelCrit.Name = "panelCrit";
            this.panelCrit.Size = new System.Drawing.Size(653, 284);
            this.panelCrit.StateNormal.Color1 = System.Drawing.Color.ForestGreen;
            this.panelCrit.StateNormal.Color2 = System.Drawing.Color.DarkGreen;
            this.panelCrit.TabIndex = 27;
            // 
            // panelElement
            // 
            this.panelElement.Controls.Add(this.panelSourceOfEvid);
            this.panelElement.Controls.Add(this.panelElementHead);
            this.panelElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelElement.Location = new System.Drawing.Point(0, 94);
            this.panelElement.Name = "panelElement";
            this.panelElement.Size = new System.Drawing.Size(653, 190);
            this.panelElement.StateNormal.Color1 = System.Drawing.Color.DarkGreen;
            this.panelElement.TabIndex = 24;
            // 
            // panelSourceOfEvid
            // 
            this.panelSourceOfEvid.Controls.Add(this.kryptonButton3);
            this.panelSourceOfEvid.Controls.Add(this.lblFilename);
            this.panelSourceOfEvid.Controls.Add(this.txtFlowChart);
            this.panelSourceOfEvid.Controls.Add(this.kryptonButton1);
            this.panelSourceOfEvid.Controls.Add(this.kryptonLabel5);
            this.panelSourceOfEvid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSourceOfEvid.Location = new System.Drawing.Point(0, 84);
            this.panelSourceOfEvid.Name = "panelSourceOfEvid";
            this.panelSourceOfEvid.Size = new System.Drawing.Size(653, 106);
            this.panelSourceOfEvid.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panelSourceOfEvid.TabIndex = 25;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(467, 56);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(100, 28);
            this.kryptonButton3.TabIndex = 18;
            this.kryptonButton3.Values.Text = "Upload";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoEllipsis = true;
            this.lblFilename.BackColor = System.Drawing.Color.Transparent;
            this.lblFilename.Location = new System.Drawing.Point(320, 56);
            this.lblFilename.Name = "lblFilename" + controls.indicatorId + "_" + 1 + "_" + 1 + "_" + 1;
            this.lblFilename.Size = new System.Drawing.Size(141, 23);
            this.lblFilename.TabIndex = 17;
            this.lblFilename.Text = "Picture";
            // 
            // txtFlowChart
            // 
            this.txtFlowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlowChart.Location = new System.Drawing.Point(323, 18);
            this.txtFlowChart.Name = "txtFlowChart" + controls.indicatorId + "_" + 1 + "_" + 1 + "_" + 1;
            this.txtFlowChart.Size = new System.Drawing.Size(244, 27);
            this.txtFlowChart.TabIndex = 16;
            this.txtFlowChart.Text = "";
            this.txtFlowChart.TextChanged += new System.EventHandler(this.kryptonTextBox5_TextChanged_1);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(157, 51);
            this.kryptonButton1.Name = "btnFlowChart" + controls.indicatorId + "_" + 1 + "_" + 1 + "_" + 1;
            this.kryptonButton1.Size = new System.Drawing.Size(107, 28);
            this.kryptonButton1.TabIndex = 14;
            this.kryptonButton1.Values.Text = "Links";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(137, 18);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(180, 28);
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Possible Outcome";
            // 
            // panelElementHead
            // 
            this.panelElementHead.Controls.Add(this.txtElement);
            this.panelElementHead.Controls.Add(this.kryptonLabel6);
            this.panelElementHead.Controls.Add(this.AddSOE);
            this.panelElementHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelElementHead.Location = new System.Drawing.Point(0, 0);
            this.panelElementHead.Name = "panelElementHead";
            this.panelElementHead.Size = new System.Drawing.Size(653, 84);
            this.panelElementHead.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panelElementHead.TabIndex = 24;
            // 
            // txtElement
            // 
            this.txtElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElement.Location = new System.Drawing.Point(272, 12);
            this.txtElement.Name = "txtElement" + controls.indicatorId + "_" + 1 + "_" + 1;
            this.txtElement.Size = new System.Drawing.Size(295, 27);
            this.txtElement.TabIndex = 14;
            this.txtElement.Text = "";
            this.txtElement.TextChanged += new System.EventHandler(this.kryptonTextBox5_TextChanged_1);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(112, 11);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(89, 28);
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 8;
            this.kryptonLabel6.Values.Text = "Element";
            // 
            // AddSOE
            // 
            this.AddSOE.Location = new System.Drawing.Point(73, 45);
            this.AddSOE.Name = "AddSOE" + controls.indicatorId + "_" + 1 + "_" + 1 + "_" + 1;
            this.AddSOE.Size = new System.Drawing.Size(182, 29);
            this.AddSOE.TabIndex = 12;
            this.AddSOE.Values.Text = "Add Possible Outcome";
            this.AddSOE.Click += new System.EventHandler(this.AddSOE_Click);
            // 
            // panelCritHead
            // 
            this.panelCritHead.Controls.Add(this.txtCritiria);
            this.panelCritHead.Controls.Add(this.btnAddElement);
            this.panelCritHead.Controls.Add(this.kryptonLabel7);
            this.panelCritHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCritHead.Location = new System.Drawing.Point(0, 0);
            this.panelCritHead.Name = "panelCritHead";
            this.panelCritHead.Size = new System.Drawing.Size(653, 94);
            this.panelCritHead.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panelCritHead.TabIndex = 19;
            // 
            // txtCritiria
            // 
            this.txtCritiria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritiria.Location = new System.Drawing.Point(235, 17);
            this.txtCritiria.Name = "txtCritiria" + controls.indicatorId + "_" + 1;
            this.txtCritiria.Size = new System.Drawing.Size(332, 27);
            this.txtCritiria.TabIndex = 9;
            this.txtCritiria.Text = "";
            this.txtCritiria.TextChanged += new System.EventHandler(this.kryptonTextBox5_TextChanged_1);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(73, 50);
            this.btnAddElement.Name = "btnAddElement" + controls.indicatorId + "_" + 1 + "_" + 1;
            this.btnAddElement.Size = new System.Drawing.Size(142, 29);
            this.btnAddElement.TabIndex = 7;
            this.btnAddElement.Values.Text = "Add Element";
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(70, 16);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(80, 28);
            this.kryptonLabel7.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 5;
            this.kryptonLabel7.Values.Text = "Criteria";
            // 
            // panelIndicator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Controls.Add(this.panelCrit);
            this.Controls.Add(this.panelIndicatorHead);
            this.Name = "panelIndicator";
            this.Size = new System.Drawing.Size(653, 384);
            this.Load += new System.EventHandler(this.panelIndicator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelIndicatorHead)).EndInit();
            this.panelIndicatorHead.ResumeLayout(false);
            this.panelIndicatorHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCrit)).EndInit();
            this.panelCrit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelElement)).EndInit();
            this.panelElement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).EndInit();
            this.panelSourceOfEvid.ResumeLayout(false);
            this.panelSourceOfEvid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelElementHead)).EndInit();
            this.panelElementHead.ResumeLayout(false);
            this.panelElementHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCritHead)).EndInit();
            this.panelCritHead.ResumeLayout(false);
            this.panelCritHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelIndicatorHead;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblIndiName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddCrti;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelCrit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelElement;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelSourceOfEvid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelElementHead;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddSOE;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelCritHead;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddElement;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private System.Windows.Forms.RichTextBox txtIndicator;
        private System.Windows.Forms.RichTextBox txtCritiria;
        private System.Windows.Forms.RichTextBox txtElement;
        private System.Windows.Forms.RichTextBox txtFlowChart;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.Label lblFilename;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;




    }
}
