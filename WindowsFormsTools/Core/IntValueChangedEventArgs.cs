namespace WindowsFormsTools.Core
{
    public class IntValueChangedEventArgs : EventArgs
    {
        public int NewValue { get; }

        public IntValueChangedEventArgs(int newValue)
        {
            NewValue = newValue;
        }
    }
}
