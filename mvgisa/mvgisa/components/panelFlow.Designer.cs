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
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).BeginInit();
            this.panelSourceOfEvid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSourceOfEvid
            // 
            this.panelSourceOfEvid.Controls.Add(this.kryptonTextBox1);
            this.panelSourceOfEvid.Controls.Add(this.kryptonButton1);
            this.panelSourceOfEvid.Controls.Add(this.kryptonLabel5);
            this.panelSourceOfEvid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSourceOfEvid.Location = new System.Drawing.Point(0, 0);
            this.panelSourceOfEvid.Name = "panelSourceOfEvid";
            this.panelSourceOfEvid.Size = new System.Drawing.Size(654, 88);
            this.panelSourceOfEvid.StateNormal.Color1 = System.Drawing.Color.WhiteSmoke;
            this.panelSourceOfEvid.TabIndex = 26;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(224, 26);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(258, 27);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 21;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(505, 21);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(116, 35);
            this.kryptonButton1.TabIndex = 14;
            this.kryptonButton1.Values.Text = "Open";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(26, 16);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(113, 28);
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Flow Chart";
            // 
            // panelFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSourceOfEvid);
            this.Name = "panelFlow";
            this.Size = new System.Drawing.Size(654, 88);
            ((System.ComponentModel.ISupportInitialize)(this.panelSourceOfEvid)).EndInit();
            this.panelSourceOfEvid.ResumeLayout(false);
            this.panelSourceOfEvid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelSourceOfEvid;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;

    }
}
