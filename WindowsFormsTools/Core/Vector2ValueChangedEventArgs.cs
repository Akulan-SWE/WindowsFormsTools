using System.Numerics;

namespace WindowsFormsTools.Core
{
    public class Vector2ValueChangedEventArgs : EventArgs
    {
        public Vector2 NewValue { get; }

        public Vector2ValueChangedEventArgs(Vector2 newValue)
        {
            NewValue = newValue;
        }
    }
}
