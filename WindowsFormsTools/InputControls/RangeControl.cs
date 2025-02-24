using System.Globalization;

namespace WindowsFormsTools.InputControls
{
    public partial class RangeControl : UserControl
    {
        public event EventHandler<ValueChangedEventArgs<float>>? ValueChanged;

        private float value;
        private readonly Size initialValueSize;

        public RangeControl()
        {
            InitializeComponent();
            Precision = 1000;
            aNumericUpDown.Minimum = decimal.MinValue;
            bNumericUpDown.Minimum = decimal.MinValue;
            aNumericUpDown.Maximum = decimal.MaxValue;
            bNumericUpDown.Maximum = decimal.MaxValue;
            initialValueSize = valueLabel.Size;
        }

        public string Header
        {
            get => nameLabel.Text;
            set => nameLabel.Text = value;
        }

        public bool IsDiscrete { get; set; }

        public bool StartEnabled
        {
            get => aNumericUpDown.Enabled;
            set
            {
                aNumericUpDown.Enabled = value;
                aLabel.Enabled = value;
            }
        }

        public bool EndEnabled
        {
            get => bNumericUpDown.Enabled;
            set
            {
                bNumericUpDown.Enabled = value;
                aLabel.Enabled = value;
            }
        }

        public int DecimalPlaces
        {
            get => aNumericUpDown.DecimalPlaces;
            set
            {
                aNumericUpDown.DecimalPlaces = value;
                bNumericUpDown.DecimalPlaces = value;
            }
        }

        public bool CanBeChecked
        {
            get => checkBox.Visible;
            set
            {
                checkBox.Visible = value;
                valueLabel.Size = value
                    ? new Size(initialValueSize.Width - 20, initialValueSize.Height)
                    : initialValueSize;
            }
        }

        public bool IsChecked
        {
            get => checkBox.Checked;
            set => checkBox.Checked = value;
        }

        public int Precision
        {
            get => rangeTrackBar.Maximum;
            set => rangeTrackBar.Maximum = value;
        }

        public float Value
        {
            get =>  value;
            set
            {
                var decimalValue = (decimal)value;
                if (decimalValue >= A && decimalValue <= B)
                {
                    this.value = value;
                    extendNumericControl(aNumericUpDown, decimalValue);
                    extendNumericControl(bNumericUpDown, decimalValue);
                    if (B - A != 0)
                        rangeTrackBar.Value = (int)(Precision * (decimalValue - A) / (B - A));
                    valueLabel.Text = Value.ToString(CultureInfo.InvariantCulture);

                    ValueChanged?.Invoke(this, new ValueChangedEventArgs<float>(this.value));
                }
            }
        }

        public decimal A
        {
            get => aNumericUpDown.Value;
            set
            {
                extendNumericControl(aNumericUpDown, value);
                aNumericUpDown.Value = value;
            }
        }

        public decimal B
        {
            get => bNumericUpDown.Value;
            set
            {
                extendNumericControl(bNumericUpDown, value);
                bNumericUpDown.Value = value;
            }
        }

        private float getValue()
        {
            var result = (float)(aNumericUpDown.Value + 
                (bNumericUpDown.Value - aNumericUpDown.Value) * rangeTrackBar.Value / Precision);
            if (IsDiscrete)
                result = (int)Math.Round(result);
            return result;
        }

        private void extendNumericControl(NumericUpDown control, decimal value)
        {
            if (value < control.Minimum)
                control.Minimum = value;
            else if (value > control.Maximum)
                control.Maximum = value;
        }

        private void rangeTrackBar_Scroll(object sender, EventArgs e)
        {
            Value = getValue();
        }

        private void minNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Value = getValue();
        }

        private void maxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Value = getValue();
        }
    }
}
