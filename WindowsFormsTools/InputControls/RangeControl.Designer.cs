namespace WindowsFormsTools.InputControls
{
    partial class RangeControl
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
            checkBox = new CheckBox();
            nameLabel = new Label();
            valueLabel = new Label();
            bNumericUpDown = new NumericUpDown();
            bLabel = new Label();
            aLabel = new Label();
            aNumericUpDown = new NumericUpDown();
            rangeTrackBar = new TrackBar();
            inputTableLayoutPanel = new TableLayoutPanel();
            bPanel = new Panel();
            aPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)bNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rangeTrackBar).BeginInit();
            inputTableLayoutPanel.SuspendLayout();
            bPanel.SuspendLayout();
            aPanel.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox
            // 
            checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox.AutoSize = true;
            checkBox.Location = new Point(189, 10);
            checkBox.Margin = new Padding(4, 3, 4, 3);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(15, 14);
            checkBox.TabIndex = 15;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Visible = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 9);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 15);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Header";
            // 
            // valueLabel
            // 
            valueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            valueLabel.Location = new Point(55, 10);
            valueLabel.Margin = new Padding(4, 0, 4, 0);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(149, 15);
            valueLabel.TabIndex = 14;
            valueLabel.Text = "0.000";
            valueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bNumericUpDown
            // 
            bNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bNumericUpDown.Location = new Point(23, 1);
            bNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            bNumericUpDown.Name = "bNumericUpDown";
            bNumericUpDown.Size = new Size(69, 23);
            bNumericUpDown.TabIndex = 11;
            bNumericUpDown.ValueChanged += maxNumericUpDown_ValueChanged;
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new Point(4, 3);
            bLabel.Margin = new Padding(4, 0, 4, 0);
            bLabel.Name = "bLabel";
            bLabel.Size = new Size(14, 15);
            bLabel.TabIndex = 12;
            bLabel.Text = "B";
            // 
            // aLabel
            // 
            aLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aLabel.AutoSize = true;
            aLabel.Location = new Point(4, 3);
            aLabel.Margin = new Padding(4, 0, 4, 0);
            aLabel.Name = "aLabel";
            aLabel.Size = new Size(15, 15);
            aLabel.TabIndex = 10;
            aLabel.Text = "A";
            // 
            // aNumericUpDown
            // 
            aNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aNumericUpDown.Location = new Point(22, 0);
            aNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            aNumericUpDown.Name = "aNumericUpDown";
            aNumericUpDown.Size = new Size(71, 23);
            aNumericUpDown.TabIndex = 9;
            aNumericUpDown.ValueChanged += minNumericUpDown_ValueChanged;
            // 
            // rangeTrackBar
            // 
            rangeTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rangeTrackBar.Location = new Point(0, 30);
            rangeTrackBar.Margin = new Padding(4, 3, 4, 3);
            rangeTrackBar.Maximum = 1000;
            rangeTrackBar.Name = "rangeTrackBar";
            rangeTrackBar.Size = new Size(210, 45);
            rangeTrackBar.TabIndex = 13;
            rangeTrackBar.TickStyle = TickStyle.None;
            rangeTrackBar.Scroll += rangeTrackBar_Scroll;
            // 
            // inputTableLayoutPanel
            // 
            inputTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputTableLayoutPanel.ColumnCount = 2;
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputTableLayoutPanel.Controls.Add(bPanel, 1, 0);
            inputTableLayoutPanel.Controls.Add(aPanel, 0, 0);
            inputTableLayoutPanel.Location = new Point(1, 58);
            inputTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            inputTableLayoutPanel.RowCount = 1;
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            inputTableLayoutPanel.Size = new Size(204, 31);
            inputTableLayoutPanel.TabIndex = 16;
            // 
            // bPanel
            // 
            bPanel.Controls.Add(bLabel);
            bPanel.Controls.Add(bNumericUpDown);
            bPanel.Dock = DockStyle.Bottom;
            bPanel.Location = new Point(106, 4);
            bPanel.Margin = new Padding(4, 3, 4, 3);
            bPanel.Name = "bPanel";
            bPanel.Size = new Size(94, 24);
            bPanel.TabIndex = 18;
            // 
            // aPanel
            // 
            aPanel.Controls.Add(aNumericUpDown);
            aPanel.Controls.Add(aLabel);
            aPanel.Dock = DockStyle.Bottom;
            aPanel.Location = new Point(4, 4);
            aPanel.Margin = new Padding(4, 3, 4, 3);
            aPanel.Name = "aPanel";
            aPanel.Size = new Size(94, 24);
            aPanel.TabIndex = 17;
            // 
            // RangeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(inputTableLayoutPanel);
            Controls.Add(checkBox);
            Controls.Add(nameLabel);
            Controls.Add(valueLabel);
            Controls.Add(rangeTrackBar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RangeControl";
            Size = new Size(210, 92);
            ((System.ComponentModel.ISupportInitialize)bNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)aNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rangeTrackBar).EndInit();
            inputTableLayoutPanel.ResumeLayout(false);
            bPanel.ResumeLayout(false);
            bPanel.PerformLayout();
            aPanel.ResumeLayout(false);
            aPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.NumericUpDown bNumericUpDown;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.NumericUpDown aNumericUpDown;
        private System.Windows.Forms.TrackBar rangeTrackBar;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
        private System.Windows.Forms.Panel aPanel;
        private System.Windows.Forms.Panel bPanel;

    }
}
