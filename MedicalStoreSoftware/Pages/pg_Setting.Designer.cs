namespace MedicalStoreSoftware.Pages
{
    partial class pg_Setting
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTheme = new System.Windows.Forms.Label();
            this.lbgbclr = new System.Windows.Forms.Label();
            this.cdBackGroundclr = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lbTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1610, 50);
            this.panelHeader.TabIndex = 13;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(716, 5);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(179, 40);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "SETTING";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTheme
            // 
            this.lbTheme.AutoSize = true;
            this.lbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheme.Location = new System.Drawing.Point(175, 76);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(184, 29);
            this.lbTheme.TabIndex = 14;
            this.lbTheme.Text = "Theme Setting";
            // 
            // lbgbclr
            // 
            this.lbgbclr.AutoSize = true;
            this.lbgbclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgbclr.Location = new System.Drawing.Point(219, 115);
            this.lbgbclr.Name = "lbgbclr";
            this.lbgbclr.Size = new System.Drawing.Size(164, 22);
            this.lbgbclr.TabIndex = 15;
            this.lbgbclr.Text = "Background Color: ";
            // 
            // cdBackGroundclr
            // 
            this.cdBackGroundclr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cdBackGroundclr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cdBackGroundclr.FormattingEnabled = true;
            this.cdBackGroundclr.Items.AddRange(new object[] {
            "White",
            "Light Gray",
            "Gray"});
            this.cdBackGroundclr.Location = new System.Drawing.Point(470, 114);
            this.cdBackGroundclr.Name = "cdBackGroundclr";
            this.cdBackGroundclr.Size = new System.Drawing.Size(231, 28);
            this.cdBackGroundclr.TabIndex = 16;
            this.cdBackGroundclr.SelectedIndexChanged += new System.EventHandler(this.cdBackGroundclr_SelectedIndexChanged);
            // 
            // pg_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Globals.BackGround;
            this.Controls.Add(this.cdBackGroundclr);
            this.Controls.Add(this.lbgbclr);
            this.Controls.Add(this.lbTheme);
            this.Controls.Add(this.panelHeader);
            this.Name = "pg_Setting";
            this.Size = new System.Drawing.Size(1610, 723);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.Label lbgbclr;
        private System.Windows.Forms.ComboBox cdBackGroundclr;


    }
}
