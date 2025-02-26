namespace WindowsFormsTools.InputControls
{
    partial class PreciseVectorControl
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
            yLabel = new Label();
            xLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            xNumericTextBox = new PreciseNumericTextBox();
            yNumericTextBox = new PreciseNumericTextBox();
            tableLayoutPanel.SuspendLayout();
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
            // yLabel
            // 
            yLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            yLabel.Location = new Point(102, 0);
            yLabel.Margin = new Padding(4, 0, 4, 0);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(11, 23);
            yLabel.TabIndex = 17;
            yLabel.Text = "Y";
            yLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // xLabel
            // 
            xLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            xLabel.Location = new Point(4, 0);
            xLabel.Margin = new Padding(4, 0, 4, 0);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(11, 23);
            xLabel.TabIndex = 15;
            xLabel.Text = "X";
            xLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel.Controls.Add(yLabel, 2, 0);
            tableLayoutPanel.Controls.Add(xLabel, 0, 0);
            tableLayoutPanel.Controls.Add(xNumericTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(yNumericTextBox, 3, 0);
            tableLayoutPanel.Location = new Point(4, 27);
            tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(198, 23);
            tableLayoutPanel.TabIndex = 18;
            // 
            // xNumericTextBox
            // 
            xNumericTextBox.Location = new Point(19, 0);
            xNumericTextBox.Margin = new Padding(0);
            xNumericTextBox.MaximumSize = new Size(350, 23);
            xNumericTextBox.MinimumSize = new Size(35, 23);
            xNumericTextBox.Name = "xNumericTextBox";
            xNumericTextBox.Size = new Size(79, 23);
            xNumericTextBox.TabIndex = 19;
            xNumericTextBox.Value = new decimal(new int[] { 0, 0, 0, 0 });
            xNumericTextBox.ValueChanged += xNumericTextBox_ValueChanged;
            // 
            // yNumericTextBox
            // 
            yNumericTextBox.Location = new Point(117, 0);
            yNumericTextBox.Margin = new Padding(0);
            yNumericTextBox.MaximumSize = new Size(350, 23);
            yNumericTextBox.MinimumSize = new Size(35, 23);
            yNumericTextBox.Name = "yNumericTextBox";
            yNumericTextBox.Size = new Size(79, 23);
            yNumericTextBox.TabIndex = 20;
            yNumericTextBox.Value = new decimal(new int[] { 0, 0, 0, 0 });
            yNumericTextBox.ValueChanged += yNumericTextBox_ValueChanged;
            // 
            // PreciseVectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel);
            Controls.Add(nameLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PreciseVectorControl";
            Size = new Size(210, 54);
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private PreciseNumericTextBox xNumericTextBox;
        private PreciseNumericTextBox yNumericTextBox;
    }
}
