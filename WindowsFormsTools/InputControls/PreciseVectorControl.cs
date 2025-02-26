using System.Numerics;
using WindowsFormsTools.Core;

namespace WindowsFormsTools.InputControls
{
    public partial class PreciseVectorControl: UserControl
    {
        public event EventHandler<Vector2ValueChangedEventArgs>? ValueChanged;

        private Vector2 value;

        public PreciseVectorControl()
        {
            InitializeComponent();
        }

        public string Header
        {
            get => nameLabel.Text;
            set => nameLabel.Text = value;
        }

        public bool StartEnabled
        {
            get => xNumericTextBox.Enabled;
            set
            {
                xNumericTextBox.Enabled = value;
                xLabel.Enabled = value;
            }
        }

        public bool EndEnabled
        {
            get => yNumericTextBox.Enabled;
            set
            {
                yNumericTextBox.Enabled = value;
                xLabel.Enabled = value;
            }
        }

        public Vector2 Value
        {
            get => value;
            set
            {
                if (value == this.value)
                    return;

                this.value = value;

                xNumericTextBox.Value = (decimal)value.X;
                yNumericTextBox.Value = (decimal)value.Y;

                ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(this.value));
            }
        }

        public float X
        {
            get => (float)xNumericTextBox.Value;
            set
            {
                if (value == this.value.X)
                    return;

                xNumericTextBox.Value = (decimal)value;
                this.value.X = value;
                ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(this.value));
            }
        }

        public float Y
        {
            get => (float)yNumericTextBox.Value;
            set
            {
                if (value == this.value.Y)
                    return;

                yNumericTextBox.Value = (decimal)value;
                this.value.Y = value;
                ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(this.value));
            }
        }

        private void xNumericTextBox_ValueChanged(object? sender, DecimalValueChangedEventArgs e)
        {
            value.X = (float)e.NewValue;
            ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(value));
        }

        private void yNumericTextBox_ValueChanged(object? sender, DecimalValueChangedEventArgs e)
        {
            value.Y = (float)e.NewValue;
            ValueChanged?.Invoke(this, new Vector2ValueChangedEventArgs(value));
        }
    }
}
