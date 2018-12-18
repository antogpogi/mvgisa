namespace mvgisa
{
    partial class panelElement
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
            this.panelElementHead = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.AddSOE = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelSourceOfEvid = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panelElementHead)).BeginInit();
            this.panelElementHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).BeginInit();
            this.panelSourceOfEvid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelElementHead
            // 
            this.panelElementHead.Controls.Add(this.kryptonButton2);
            this.panelElementHead.Controls.Add(this.richTextBox3);
            this.panelElementHead.Controls.Add(this.kryptonLabel6);
            this.panelElementHead.Controls.Add(this.AddSOE);
            this.panelElementHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelElementHead.Location = new System.Drawing.Point(0, 0);
            this.panelElementHead.Name = "panelElementHead";
            this.panelElementHead.Size = new System.Drawing.Size(653, 84);
            this.panelElementHead.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panelElementHead.TabIndex = 25;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(583, 3);
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
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(272, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(295, 27);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.kryptonTextBox2_TextChanged);
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
            this.AddSOE.Name = "AddSOE";
            this.AddSOE.Size = new System.Drawing.Size(182, 29);
            this.AddSOE.TabIndex = 12;
            this.AddSOE.Values.Text = "Add Possible Outcome";
            this.AddSOE.Click += new System.EventHandler(this.AddSOE_Click);
            // 
            // panelSourceOfEvid
            // 
            this.panelSourceOfEvid.Controls.Add(this.richTextBox4);
            this.panelSourceOfEvid.Controls.Add(this.kryptonButton1);
            this.panelSourceOfEvid.Controls.Add(this.kryptonLabel5);
            this.panelSourceOfEvid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSourceOfEvid.Location = new System.Drawing.Point(0, 84);
            this.panelSourceOfEvid.Name = "panelSourceOfEvid";
            this.panelSourceOfEvid.Size = new System.Drawing.Size(653, 106);
            this.panelSourceOfEvid.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panelSourceOfEvid.TabIndex = 26;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(323, 18);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(244, 27);
            this.richTextBox4.TabIndex = 16;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.kryptonTextBox2_TextChanged);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(157, 51);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(107, 28);
            this.kryptonButton1.TabIndex = 14;
            this.kryptonButton1.Values.Text = "Links";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(137, 17);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(180, 28);
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Possible Outcome";
            // 
            // panelElement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelSourceOfEvid);
            this.Controls.Add(this.panelElementHead);
            this.Name = "panelElement";
            this.Size = new System.Drawing.Size(653, 190);
            ((System.ComponentModel.ISupportInitialize)(this.panelElementHead)).EndInit();
            this.panelElementHead.ResumeLayout(false);
            this.panelElementHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).EndInit();
            this.panelSourceOfEvid.ResumeLayout(false);
            this.panelSourceOfEvid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelElementHead;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddSOE;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelSourceOfEvid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;



    }
}
