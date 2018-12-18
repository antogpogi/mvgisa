namespace mvgisa
{
    partial class PresentationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelKRA = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKRANme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.accIndicator = new Opulos.Core.UI.Accordion();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelKRA
            // 
            this.flowLayoutPanelKRA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelKRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelKRA.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelKRA.Location = new System.Drawing.Point(39, 71);
            this.flowLayoutPanelKRA.Name = "flowLayoutPanelKRA";
            this.flowLayoutPanelKRA.Size = new System.Drawing.Size(284, 457);
            this.flowLayoutPanelKRA.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanelKRA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 609);
            this.panel1.TabIndex = 1;
            // 
            // lblKRANme
            // 
            this.lblKRANme.AutoSize = true;
            this.lblKRANme.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKRANme.Location = new System.Drawing.Point(24, 21);
            this.lblKRANme.Name = "lblKRANme";
            this.lblKRANme.Size = new System.Drawing.Size(0, 28);
            this.lblKRANme.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.accIndicator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(364, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 506);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblKRANme);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(364, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 103);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key Result Area List";
            // 
            // accIndicator
            // 
            this.accIndicator.AccessibleDescription = "1";
            this.accIndicator.AddResizeBars = false;
            this.accIndicator.AllowMouseResize = true;
            this.accIndicator.AnimateCloseEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalNegative | Opulos.Core.UI.AnimateWindowFlags.Hide) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.accIndicator.AnimateCloseMillis = 300;
            this.accIndicator.AnimateOpenEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalPositive | Opulos.Core.UI.AnimateWindowFlags.Show) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.accIndicator.AnimateOpenMillis = 300;
            this.accIndicator.AutoFixDockStyle = true;
            this.accIndicator.AutoScroll = true;
            this.accIndicator.AutoSize = true;
            this.accIndicator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accIndicator.BackColor = System.Drawing.Color.White;
            this.accIndicator.CheckBoxFactory = null;
            this.accIndicator.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this.accIndicator.ContentBackColor = null;
            this.accIndicator.ContentMargin = null;
            this.accIndicator.ContentPadding = new System.Windows.Forms.Padding(5);
            this.accIndicator.ControlBackColor = null;
            this.accIndicator.ControlMinimumHeightIsItsPreferredHeight = true;
            this.accIndicator.ControlMinimumWidthIsItsPreferredWidth = true;
            this.accIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accIndicator.DownArrow = null;
            this.accIndicator.FillHeight = false;
            this.accIndicator.FillLastOpened = false;
            this.accIndicator.FillModeGrowOnly = false;
            this.accIndicator.FillResetOnCollapse = false;
            this.accIndicator.FillWidth = true;
            this.accIndicator.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this.accIndicator.GrabRequiresPositiveFillWeight = true;
            this.accIndicator.GrabWidth = 6;
            this.accIndicator.GrowAndShrink = false;
            this.accIndicator.Insets = new System.Windows.Forms.Padding(0);
            this.accIndicator.Location = new System.Drawing.Point(0, 0);
            this.accIndicator.Name = "accIndicator";
            this.accIndicator.OpenOnAdd = false;
            this.accIndicator.OpenOneOnly = true;
            this.accIndicator.ResizeBarFactory = null;
            this.accIndicator.ResizeBarsAlign = 0.5D;
            this.accIndicator.ResizeBarsArrowKeyDelta = 10;
            this.accIndicator.ResizeBarsFadeInMillis = 800;
            this.accIndicator.ResizeBarsFadeOutMillis = 800;
            this.accIndicator.ResizeBarsFadeProximity = 30;
            this.accIndicator.ResizeBarsFill = 1D;
            this.accIndicator.ResizeBarsKeepFocusAfterMouseDrag = false;
            this.accIndicator.ResizeBarsKeepFocusIfControlOutOfView = true;
            this.accIndicator.ResizeBarsKeepFocusOnClick = true;
            this.accIndicator.ResizeBarsMargin = null;
            this.accIndicator.ResizeBarsMinimumLength = 50;
            this.accIndicator.ResizeBarsStayInViewOnArrowKey = true;
            this.accIndicator.ResizeBarsStayInViewOnMouseDrag = true;
            this.accIndicator.ResizeBarsStayVisibleIfFocused = true;
            this.accIndicator.ResizeBarsTabStop = true;
            this.accIndicator.ShowPartiallyVisibleResizeBars = false;
            this.accIndicator.ShowToolMenu = true;
            this.accIndicator.ShowToolMenuOnHoverWhenClosed = false;
            this.accIndicator.ShowToolMenuOnRightClick = true;
            this.accIndicator.ShowToolMenuRequiresPositiveFillWeight = false;
            this.accIndicator.Size = new System.Drawing.Size(740, 506);
            this.accIndicator.TabIndex = 0;
            this.accIndicator.UpArrow = null;
            // 
            // PresentationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1104, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PresentationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Presentation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PresentationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKRA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKRANme;
        private System.Windows.Forms.Panel panel3;
        private Opulos.Core.UI.Accordion accIndicator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;

    }
}