namespace WindowsFormsTools.Miscellaneous
{
    partial class CollapsiblePanel
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
            titlePanel = new Panel();
            lblPanelTitle = new Label();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.DarkGray;
            titlePanel.BackgroundImageLayout = ImageLayout.Stretch;
            titlePanel.Controls.Add(lblPanelTitle);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Margin = new Padding(4, 3, 4, 3);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(173, 23);
            titlePanel.TabIndex = 1;
            titlePanel.MouseDoubleClick += titlePanel_MouseDoubleClick;
            // 
            // lblPanelTitle
            // 
            lblPanelTitle.AutoSize = true;
            lblPanelTitle.BackColor = Color.Transparent;
            lblPanelTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPanelTitle.Location = new Point(5, 3);
            lblPanelTitle.Margin = new Padding(4, 0, 4, 0);
            lblPanelTitle.Name = "lblPanelTitle";
            lblPanelTitle.Size = new Size(64, 13);
            lblPanelTitle.TabIndex = 1;
            lblPanelTitle.Text = "Panel title";
            // 
            // CollapsiblePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(titlePanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CollapsiblePanel";
            Size = new Size(173, 171);
            LocationChanged += collapsiblePanel_LocationChanged;
            SizeChanged += collapsiblePanel_SizeChanged;
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblPanelTitle;
    }
}
