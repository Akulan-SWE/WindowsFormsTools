using System.Text;
using WindowsFormsTools.Core;

namespace WindowsFormsTools.InputControls
{
    public partial class PreciseNumericTextBox: UserControl
    {
        public event EventHandler<DecimalValueChangedEventArgs>? ValueChanged;

        private bool manualChange;
        private decimal value;

        public decimal Value
        {
            get => value;
            set
            {
                this.value = value;

                ValueChanged?.Invoke(this, new DecimalValueChangedEventArgs(value));

                if (!manualChange)
                {
                    int shift = 0;
                    manualChange = true;
                    textBox.Text = processedString(this.value.ToString(), ref shift);
                    manualChange = false;
                }
            }
        }

        public PreciseNumericTextBox()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!manualChange)
            {
                manualChange = true;
                int caret = textBox.SelectionStart;
                int shift = 0;
                textBox.Text = processedString(textBox.Text, ref shift);
                Value = decimal.Parse(textBox.Text);
                textBox.SelectionStart = caret + shift;
                manualChange = false;
            }
        }

        private string processedString(string text, ref int caretShift)
        {
            bool hasPoint = false;
            StringBuilder b = new StringBuilder();
            foreach (var c in text)
            {
                if (c == '-')
                {
                    if (b.Length == 0)
                        b.Append(c);
                    else
                        caretShift--;
                }
                else if (c == '.' || c == ',')
                {
                    if (!hasPoint)
                    {
                        if (b.Length == 0)
                            b.Append('0');
                        b.Append(',');
                        hasPoint = true;
                    }
                    else
                    {
                        caretShift--;
                    }
                }
                else if (char.IsDigit(c))
                {
                    b.Append(c);
                }
            }
            if (b.Length == 1 && b[0] == '-')
                b.Remove(0, 1);
            else if (b.Length > 1)
            {
                if (b[0] == '0' && !hasPoint)
                    b.Remove(0, 1);
            }

            if (b.Length == 0)
                b.Append('0');

            return b.ToString();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                char.IsDigit(e.KeyChar)
                || char.IsControl(e.KeyChar)
                || e.KeyChar == ','
                || e.KeyChar == '.'
                || e.KeyChar == '-');
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && char.IsDigit(textBox.Text[textBox.Text.Length - 1]))
            {
                Value += getStep(textBox.Text,
                    textBox.SelectionStart == 0 ? textBox.Text.Length : textBox.SelectionStart);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && char.IsDigit(textBox.Text[textBox.Text.Length - 1]))
            {
                Value -= getStep(textBox.Text,
                    textBox.SelectionStart == 0 ? textBox.Text.Length : textBox.SelectionStart);
            }
        }

        private decimal getStep(string value, int cursor)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            int point = value.IndexOf(",", StringComparison.Ordinal);
            int decimals = point != -1 ? point - cursor : value.Length - cursor;
            if (point != -1 && cursor > point) decimals++;
            return (decimal)Math.Pow(10, decimals);
        }
    }
}
