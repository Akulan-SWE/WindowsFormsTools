namespace WindowsFormsTools.Core
{
    public class DecimalValueChangedEventArgs : EventArgs
    {
        public decimal NewValue { get; }

        public DecimalValueChangedEventArgs(decimal newValue)
        {
            NewValue = newValue;
        }
    }
}
