namespace WindowsFormsTools.InputControls
{
    partial class VectorControl
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
            nameLabel = new Label();
            yNumericUpDown = new NumericUpDown();
            yLabel = new Label();
            xLabel = new Label();
            xNumericUpDown = new NumericUpDown();
            tableLayoutPanel = new TableLayoutPanel();
            yPanel = new Panel();
            xPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)yNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xNumericUpDown).BeginInit();
            tableLayoutPanel.SuspendLayout();
            yPanel.SuspendLayout();
            xPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 7);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 15);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Header";
            // 
            // yNumericUpDown
            // 
            yNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yNumericUpDown.DecimalPlaces = 3;
            yNumericUpDown.Location = new Point(24, 0);
            yNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            yNumericUpDown.Name = "yNumericUpDown";
            yNumericUpDown.Size = new Size(70, 23);
            yNumericUpDown.TabIndex = 16;
            yNumericUpDown.ValueChanged += yNumericUpDown_ValueChanged;
            // 
            // yLabel
            // 
            yLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yLabel.AutoSize = true;
            yLabel.Location = new Point(5, 3);
            yLabel.Margin = new Padding(4, 0, 4, 0);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(14, 15);
            yLabel.TabIndex = 17;
            yLabel.Text = "Y";
            // 
            // xLabel
            // 
            xLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xLabel.AutoSize = true;
            xLabel.Location = new Point(4, 2);
            xLabel.Margin = new Padding(4, 0, 4, 0);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(14, 15);
            xLabel.TabIndex = 15;
            xLabel.Text = "X";
            // 
            // xNumericUpDown
            // 
            xNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xNumericUpDown.DecimalPlaces = 3;
            xNumericUpDown.Location = new Point(23, 0);
            xNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            xNumericUpDown.Name = "xNumericUpDown";
            xNumericUpDown.Size = new Size(70, 23);
            xNumericUpDown.TabIndex = 14;
            xNumericUpDown.ValueChanged += xNumericUpDown_ValueChanged;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(yPanel, 1, 0);
            tableLayoutPanel.Controls.Add(xPanel, 0, 0);
            tableLayoutPanel.Location = new Point(4, 29);
            tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(203, 31);
            tableLayoutPanel.TabIndex = 18;
            // 
            // yPanel
            // 
            yPanel.Controls.Add(yNumericUpDown);
            yPanel.Controls.Add(yLabel);
            yPanel.Dock = DockStyle.Bottom;
            yPanel.Location = new Point(105, 4);
            yPanel.Margin = new Padding(4, 3, 4, 3);
            yPanel.Name = "yPanel";
            yPanel.Size = new Size(94, 24);
            yPanel.TabIndex = 18;
            // 
            // xPanel
            // 
            xPanel.Controls.Add(xNumericUpDown);
            xPanel.Controls.Add(xLabel);
            xPanel.Dock = DockStyle.Bottom;
            xPanel.Location = new Point(4, 4);
            xPanel.Margin = new Padding(4, 3, 4, 3);
            xPanel.Name = "xPanel";
            xPanel.Size = new Size(93, 24);
            xPanel.TabIndex = 17;
            // 
            // VectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel);
            Controls.Add(nameLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VectorControl";
            Size = new Size(210, 63);
            ((System.ComponentModel.ISupportInitialize)yNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xNumericUpDown).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            yPanel.ResumeLayout(false);
            yPanel.PerformLayout();
            xPanel.ResumeLayout(false);
            xPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel yPanel;
        private System.Windows.Forms.Panel xPanel;

    }
}
