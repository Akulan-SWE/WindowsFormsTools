namespace WindowsFormsTools.Miscellaneous
{
    public class StateButton : Button
    {
        // "Properties" tab does not handle pure Image[] or ImageList.ImageCollection property
        // without extra implementations, a wrapper is easier
        public class ImageEntry
        {
            public string? Name { get; set; }
            public Image? Image { get; set; }

            public override string ToString()
            {
                return Name ?? Image?.ToString() ?? "Empty entry";
            }
        }

        public event EventHandler<ValueChangedEventArgs<int>>? StateIndexChanged;

        private ImageEntry[]? stateImages;
        private int stateIndex = -1;

        public ImageEntry[]? StateImages
        {
            get => stateImages;
            set
            {
                stateImages = value;

                StateIndex = stateImages != null && stateImages.Length != 0
                    ? stateIndex == -1 ? 0 : stateIndex
                    : -1;
            }
        }

        public int StateIndex
        {
            get => stateIndex;
            set
            {
                if (StateImages == null || StateImages.Length == 0)
                    return;

                int newStateIndex = value % StateImages.Length;

                if (stateIndex == newStateIndex)
                    return;

                stateIndex = newStateIndex;
                var entry = StateImages[stateIndex];
                Image = entry.Image;
                Text = Image == null ? entry.Name : string.Empty;

                StateIndexChanged?.Invoke(this, new ValueChangedEventArgs<int>(stateIndex));
            }
        }

        public StateButton() : base()
        {
            Click += StateButton_Click;
        }

        private void StateButton_Click(object? sender, EventArgs e)
        {
            StateIndex++;
        }
    }
}
