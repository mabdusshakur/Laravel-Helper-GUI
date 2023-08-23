namespace Laravel_Helper_GUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Main_TP_DGC = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.NAV_PANEL = new Siticone.UI.WinForms.SiticonePanel();
            this.CB_EXIT = new Siticone.UI.WinForms.SiticoneControlBox();
            this.CB_BTN_GROUP = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.CB_MINIMIZE = new Siticone.UI.WinForms.SiticoneControlBox();
            this.NAV_DGC = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.NAV_PANEL.SuspendLayout();
            this.CB_BTN_GROUP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_TP_DGC
            // 
            this.Main_TP_DGC.DragEndTransparencyValue = 1D;
            this.Main_TP_DGC.DragStartTransparencyValue = 0.9D;
            this.Main_TP_DGC.TargetDragControl = this;
            // 
            // NAV_PANEL
            // 
            this.NAV_PANEL.BackColor = System.Drawing.Color.SlateGray;
            this.NAV_PANEL.Controls.Add(this.CB_BTN_GROUP);
            this.NAV_PANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.NAV_PANEL.Location = new System.Drawing.Point(0, 0);
            this.NAV_PANEL.Name = "NAV_PANEL";
            this.NAV_PANEL.ShadowDecoration.Parent = this.NAV_PANEL;
            this.NAV_PANEL.Size = new System.Drawing.Size(800, 31);
            this.NAV_PANEL.TabIndex = 2;
            // 
            // CB_EXIT
            // 
            this.CB_EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_EXIT.FillColor = System.Drawing.Color.Transparent;
            this.CB_EXIT.HoveredState.Parent = this.CB_EXIT;
            this.CB_EXIT.IconColor = System.Drawing.Color.White;
            this.CB_EXIT.Location = new System.Drawing.Point(59, -1);
            this.CB_EXIT.Name = "CB_EXIT";
            this.CB_EXIT.ShadowDecoration.Parent = this.CB_EXIT;
            this.CB_EXIT.Size = new System.Drawing.Size(45, 31);
            this.CB_EXIT.TabIndex = 1;
            // 
            // CB_BTN_GROUP
            // 
            this.CB_BTN_GROUP.BackColor = System.Drawing.Color.Transparent;
            this.CB_BTN_GROUP.BorderColor = System.Drawing.Color.Transparent;
            this.CB_BTN_GROUP.Controls.Add(this.CB_MINIMIZE);
            this.CB_BTN_GROUP.Controls.Add(this.CB_EXIT);
            this.CB_BTN_GROUP.CustomBorderColor = System.Drawing.Color.Transparent;
            this.CB_BTN_GROUP.FillColor = System.Drawing.Color.Transparent;
            this.CB_BTN_GROUP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CB_BTN_GROUP.ForeColor = System.Drawing.Color.Transparent;
            this.CB_BTN_GROUP.Location = new System.Drawing.Point(696, 0);
            this.CB_BTN_GROUP.Name = "CB_BTN_GROUP";
            this.CB_BTN_GROUP.ShadowDecoration.Parent = this.CB_BTN_GROUP;
            this.CB_BTN_GROUP.Size = new System.Drawing.Size(104, 31);
            this.CB_BTN_GROUP.TabIndex = 3;
            this.CB_BTN_GROUP.Text = "siticoneGroupBox1";
            // 
            // CB_MINIMIZE
            // 
            this.CB_MINIMIZE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_MINIMIZE.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.CB_MINIMIZE.FillColor = System.Drawing.Color.Transparent;
            this.CB_MINIMIZE.HoveredState.Parent = this.CB_MINIMIZE;
            this.CB_MINIMIZE.IconColor = System.Drawing.Color.White;
            this.CB_MINIMIZE.Location = new System.Drawing.Point(8, -1);
            this.CB_MINIMIZE.Name = "CB_MINIMIZE";
            this.CB_MINIMIZE.ShadowDecoration.Parent = this.CB_MINIMIZE;
            this.CB_MINIMIZE.Size = new System.Drawing.Size(45, 31);
            this.CB_MINIMIZE.TabIndex = 2;
            // 
            // NAV_DGC
            // 
            this.NAV_DGC.TargetControl = this.NAV_PANEL;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.NAV_PANEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NAV_PANEL.ResumeLayout(false);
            this.CB_BTN_GROUP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneTransparentDrag Main_TP_DGC;
        private Siticone.UI.WinForms.SiticonePanel NAV_PANEL;
        private Siticone.UI.WinForms.SiticoneGroupBox CB_BTN_GROUP;
        private Siticone.UI.WinForms.SiticoneControlBox CB_MINIMIZE;
        private Siticone.UI.WinForms.SiticoneControlBox CB_EXIT;
        private Siticone.UI.WinForms.SiticoneDragControl NAV_DGC;
    }
}

