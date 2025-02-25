namespace WindowsFormsTools.Core
{
    public class ColorValueChangedEventArgs : EventArgs
    {
        public Color NewValue { get; }

        public ColorValueChangedEventArgs(Color newValue)
        {
            NewValue = newValue;
        }
    }
}
