namespace mvgisa
{
    partial class AddForm
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
            this.lblKRA = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KRAPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtKRA = new System.Windows.Forms.RichTextBox();
            this.btnIndi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCoreIndi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ActionsPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.FormPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.KRAPanel)).BeginInit();
            this.KRAPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsPanel1)).BeginInit();
            this.ActionsPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKRA
            // 
            this.lblKRA.Location = new System.Drawing.Point(39, 57);
            this.lblKRA.Name = "lblKRA";
            this.lblKRA.Size = new System.Drawing.Size(162, 28);
            this.lblKRA.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblKRA.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKRA.TabIndex = 0;
            this.lblKRA.Values.Text = "Key Result Area";
            // 
            // KRAPanel
            // 
            this.KRAPanel.Controls.Add(this.txtKRA);
            this.KRAPanel.Controls.Add(this.btnIndi);
            this.KRAPanel.Controls.Add(this.btnCoreIndi);
            this.KRAPanel.Controls.Add(this.lblKRA);
            this.KRAPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KRAPanel.Location = new System.Drawing.Point(0, 0);
            this.KRAPanel.Name = "KRAPanel";
            this.KRAPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowSheet;
            this.KRAPanel.Size = new System.Drawing.Size(645, 165);
            this.KRAPanel.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.KRAPanel.StateNormal.Color2 = System.Drawing.Color.MidnightBlue;
            this.KRAPanel.StateNormal.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.KRAPanel.StateNormal.ColorAngle = 1F;
            this.KRAPanel.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine;
            this.KRAPanel.StateNormal.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.KRAPanel.TabIndex = 2;
            // 
            // txtKRA
            // 
            this.txtKRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKRA.Location = new System.Drawing.Point(208, 56);
            this.txtKRA.Name = "txtKRA";
            this.txtKRA.Size = new System.Drawing.Size(359, 27);
            this.txtKRA.TabIndex = 6;
            this.txtKRA.Text = "";
            // 
            // btnIndi
            // 
            this.btnIndi.Location = new System.Drawing.Point(254, 108);
            this.btnIndi.Name = "btnIndi";
            this.btnIndi.Size = new System.Drawing.Size(142, 29);
            this.btnIndi.TabIndex = 3;
            this.btnIndi.Values.Text = "Add Indicator";
            this.btnIndi.Click += new System.EventHandler(this.btnIndi_Click);
            // 
            // btnCoreIndi
            // 
            this.btnCoreIndi.Location = new System.Drawing.Point(39, 108);
            this.btnCoreIndi.Name = "btnCoreIndi";
            this.btnCoreIndi.Size = new System.Drawing.Size(176, 29);
            this.btnCoreIndi.TabIndex = 2;
            this.btnCoreIndi.Values.Text = "Add Core Indicator";
            this.btnCoreIndi.Click += new System.EventHandler(this.btnCoreIndi_Click);
            // 
            // ActionsPanel1
            // 
            this.ActionsPanel1.Controls.Add(this.btnCancel);
            this.ActionsPanel1.Controls.Add(this.btnSave);
            this.ActionsPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionsPanel1.Location = new System.Drawing.Point(0, 558);
            this.ActionsPanel1.Name = "ActionsPanel1";
            this.ActionsPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.ActionsPanel1.Size = new System.Drawing.Size(645, 78);
            this.ActionsPanel1.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ActionsPanel1.StateNormal.Color2 = System.Drawing.Color.Navy;
            this.ActionsPanel1.StateNormal.ColorAngle = 2F;
            this.ActionsPanel1.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.ActionsPanel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(354, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 58);
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(122, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 58);
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.AutoScroll = true;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormPanel.Location = new System.Drawing.Point(0, 165);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.FormPanel.Size = new System.Drawing.Size(645, 395);
            this.FormPanel.TabIndex = 4;
            // 
            // AddForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 636);
            this.Controls.Add(this.ActionsPanel1);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.KRAPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KRAPanel)).EndInit();
            this.KRAPanel.ResumeLayout(false);
            this.KRAPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsPanel1)).EndInit();
            this.ActionsPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblKRA;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel KRAPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel ActionsPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel FormPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIndi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCoreIndi;
        private System.Windows.Forms.RichTextBox txtKRA;
    }
}