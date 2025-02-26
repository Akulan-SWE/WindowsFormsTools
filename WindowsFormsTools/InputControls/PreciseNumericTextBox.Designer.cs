namespace WindowsFormsTools.InputControls
{
    partial class PreciseNumericTextBox
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
            textBox = new TextBox();
            downButton = new Button();
            upButton = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(0, 0);
            textBox.Margin = new Padding(0);
            textBox.Name = "textBox";
            textBox.Size = new Size(59, 23);
            textBox.TabIndex = 2;
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox_TextChanged;
            textBox.KeyPress += textBox_KeyPress;
            // 
            // downButton
            // 
            downButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            downButton.FlatAppearance.BorderSize = 0;
            downButton.FlatStyle = FlatStyle.Flat;
            downButton.Image = Properties.Resources.down;
            downButton.Location = new Point(59, 10);
            downButton.Margin = new Padding(0);
            downButton.Name = "downButton";
            downButton.Size = new Size(12, 13);
            downButton.TabIndex = 4;
            downButton.Text = "a";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // upButton
            // 
            upButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            upButton.FlatAppearance.BorderSize = 0;
            upButton.FlatStyle = FlatStyle.Flat;
            upButton.Image = Properties.Resources.up;
            upButton.Location = new Point(59, -1);
            upButton.Margin = new Padding(0);
            upButton.Name = "upButton";
            upButton.Size = new Size(12, 13);
            upButton.TabIndex = 3;
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // PreciseNumericTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(upButton);
            Controls.Add(downButton);
            Controls.Add(textBox);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(350, 23);
            MinimumSize = new Size(35, 23);
            Name = "PreciseNumericTextBox";
            Size = new Size(71, 23);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
    }
}
