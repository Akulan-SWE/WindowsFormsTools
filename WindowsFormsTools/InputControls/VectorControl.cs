using System.Numerics;
using WindowsFormsTools.Core;

namespace WindowsFormsTools.InputControls
{
    public partial class VectorControl : UserControl
    {
        public event EventHandler<Vector2ValueChangedEventArgs>? ValueChanged;

        private Vector2 value;

        public VectorControl()
        {
            InitializeComponent();

            xNumericUpDown.Minimum = decimal.MinValue;
            yNumericUpDown.Minimum = decimal.MinValue;
            xNumericUpDown.Maximum = decimal.MaxValue;
            yNumericUpDown.Maximum = decimal.MaxValue;
        }

        public string Header
        {
            get => nameLabel.Text;
            set => nameLabel.Text = value;
        }

        public bool StartEnabled
        {
            get => xNumericUpDown.Enabled;
            set
            {
                xNumericUpDown.Enabled = value;
                xLabel.Enabled = value;
            }
        }

        public bool EndEnabled
        {
            get => yNumericUpDown.Enabled;
            set
            {
                yNumericUpDown.Enabled = value;
                xLabel.Enabled = value;
            }
        }
        public int DecimalPlaces
        {
            get => xNumericUpDown.DecimalPlaces;
            set
            {
                xNumericUpDown.DecimalPlaces = value;
                yNumericUpDown.DecimalPlaces = value;
            }
        }

        public Vector2 Value
        {
            get => value;
            set
            {
                X = value.X;
                Y = value.Y;
                ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(value));
            }
        }

        public float X
        {
            get => value.X;
            set
            {
                extendNumericControl(xNumericUpDown, value);
                xNumericUpDown.Value = (decimal)value;
                this.value.X = value;
                ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(this.value));
            }
        }

        public float Y
        {
            get => value.Y;
            set
            {
                extendNumericControl(yNumericUpDown, value);
                yNumericUpDown.Value = (decimal)value;
                this.value.Y = value;
                ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(this.value));
            }
        }

        private void extendNumericControl(NumericUpDown control, float value)
        {
            decimal dValue = (decimal)value;
            if (dValue < control.Minimum)
                control.Minimum = dValue;
            else if (dValue > control.Maximum)
                control.Maximum = dValue;
        }

        private void xNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            value.X = (float)xNumericUpDown.Value;
            ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(value));
        }

        private void yNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            value.Y = (float)yNumericUpDown.Value;
            ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(value));
        }
    }
}
