
namespace WindowsFormsTools.InputControls
{
    public partial class ColorControl : UserControl
    {
        public event EventHandler<ValueChangedEventArgs<Color>>? ValueChanged;

        public string Header
        {
            get => colorLabel.Text;
            set => colorLabel.Text = value;
        }

        public Color Value
        {
            get => colorPanel.BackColor;
            set
            {
                colorPanel.BackColor = value;
                ValueChanged?.Invoke(this, new ValueChangedEventArgs<Color>(value));
            }
        }

        public int ColorPanelWidth
        {
            get => colorPanel.Width;
            set
            {
                colorPanel.Location = new Point(Size.Width - value, colorPanel.Location.Y);
                colorPanel.Width = value;
            }
        }

        public ColorControl()
        {
            InitializeComponent();
        }

        private void colorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Value = colorDialog.Color;
            }
        }
    }
}
