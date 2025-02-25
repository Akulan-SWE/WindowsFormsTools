namespace WindowsFormsTools.Core
{
    public class FloatValueChangedEventArgs : EventArgs
    {
        public float NewValue { get; }

        public FloatValueChangedEventArgs(float newValue)
        {
            NewValue = newValue;
        }
    }
}
