using mvgisa.extensions;
namespace mvgisa
{
    partial class panelFlow
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
            this.panelSourceOfEvid = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFilename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).BeginInit();
            this.panelSourceOfEvid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSourceOfEvid
            // 
            this.panelSourceOfEvid.Controls.Add(this.kryptonButton3);
            this.panelSourceOfEvid.Controls.Add(this.lblFilename);
            this.panelSourceOfEvid.Controls.Add(this.richTextBox4);
            this.panelSourceOfEvid.Controls.Add(this.kryptonButton2);
            this.panelSourceOfEvid.Controls.Add(this.kryptonButton1);
            this.panelSourceOfEvid.Controls.Add(this.kryptonLabel5);
            this.panelSourceOfEvid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSourceOfEvid.Location = new System.Drawing.Point(0, 0);
            this.panelSourceOfEvid.Name = "panelSourceOfEvid";
            this.panelSourceOfEvid.Size = new System.Drawing.Size(653, 106);
            this.panelSourceOfEvid.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panelSourceOfEvid.TabIndex = 26;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(323, 18);
            this.richTextBox4.Name = "txtFlowChart" + controls.underNode;
            this.richTextBox4.Size = new System.Drawing.Size(244, 27);
            this.richTextBox4.TabIndex = 28;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(573, 3);
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
            this.kryptonButton2.TabIndex = 27;
            this.kryptonButton2.Values.Text = "-";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(157, 51);
            this.kryptonButton1.Name = "btnFlowChart" + controls.underNode;
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
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(467, 51);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(100, 28);
            this.kryptonButton3.TabIndex = 28;
            this.kryptonButton3.Values.Text = "Upload";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoEllipsis = true;
            this.lblFilename.BackColor = System.Drawing.Color.Transparent;
            this.lblFilename.Location = new System.Drawing.Point(320, 51);
            this.lblFilename.Name = "lblFilename" + controls.underNode;
            this.lblFilename.Size = new System.Drawing.Size(141, 23);
            this.lblFilename.TabIndex = 27;
            this.lblFilename.Text = "Picture";
            // 
            // panelFlow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelSourceOfEvid);
            this.Name = "panelFlow";
            this.Size = new System.Drawing.Size(653, 106);
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).EndInit();
            this.panelSourceOfEvid.ResumeLayout(false);
            this.panelSourceOfEvid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelSourceOfEvid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.Label lblFilename;



    }
}
