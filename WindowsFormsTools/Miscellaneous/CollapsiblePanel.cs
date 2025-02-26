using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace WindowsFormsTools.Miscellaneous
{
    [DesignTimeVisible(true)]
    [Category("Containers")]
    [Description("Visual Studio like Collapsible Panel")]
    [Designer(typeof(CollapsiblePanelDesigner))]
    public partial class CollapsiblePanel : UserControl
    {
        public enum PanelStates
        {
            Collapsed,
            Expanded
        }

        public class StateChangedEventArgs(PanelStates newState) : EventArgs
        {
            public PanelStates NewState { get; } = newState;
        }

        int expandedHeight;
        PanelStates panelState = PanelStates.Expanded;
        CollapsiblePanel? nextPanel;

        [Category("Collapsible Panel")]
        public event EventHandler<StateChangedEventArgs>? StateChanged;

        #region Properties

        [Description("Gets or sets the value for user control height when it is expanded")]
        [DisplayName("Expanded Height")]
        [Category("Collapsible Panel")]
        [DefaultValue(0)]
        public int ExpandedHeight
        {
            get => expandedHeight;
            set
            {
                if (value <= 0 || expandedHeight == value)
                    return;

                expandedHeight = value;

                if (DesignMode || panelState == PanelStates.Expanded)
                {
                    SetBounds(Location.X,
                        Location.Y,
                        Size.Width,
                        titlePanel.Height + expandedHeight);
                }
            }
        }

        [Description("Gets or sets panel title")]
        [DisplayName("Panel Title")]
        [Category("Collapsible Panel")]
        public string PanelTitle
        {
            get => lblPanelTitle.Text;
            set => lblPanelTitle.Text = value;
        }

        [DefaultValue(typeof(PanelStates), "Expanded")]
        [Description("Gets or sets current panel state")]
        [DisplayName("Panel State")]
        [Category("Collapsible Panel")]
        public PanelStates PanelState
        {
            get => panelState;
            set => setPanelState(value);
        }

        [Description("Gets or sets current header panel color")]
        [DisplayName("Header Color")]
        [Category("Collapsible Panel")]
        public Color HeaderColor
        {
            get => titlePanel.BackColor;
            set => titlePanel.BackColor = value;
        }

        [Category("Collapsible Panel")]
        [Description("Gets or sets the panel to be located beneath this panel")]
        public CollapsiblePanel? NextPanel
        {
            get => nextPanel;
            set
            {
                nextPanel = value;
                moveNextPanel();
            }
        }

        #endregion

        public CollapsiblePanel()
        {
            InitializeComponent();
        }

        void collapsiblePanel_SizeChanged(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                if (panelState == PanelStates.Expanded)
                {
                    expandedHeight = Height - titlePanel.Height;
                }
                else
                {
                    SetBounds(Location.X,
                        Location.Y,
                        Size.Width,
                        titlePanel.Height);
                }
            }

            moveNextPanel();
        }

        void collapsiblePanel_LocationChanged(object sender, EventArgs e)
        {
            moveNextPanel();
        }

        private void titlePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var newState = panelState == PanelStates.Collapsed
                ? PanelStates.Expanded
                : PanelStates.Collapsed;
            setPanelState(newState);
        }

        private void setPanelState(PanelStates newState)
        {
            if (panelState == newState)
                return;

            panelState = newState;

            int newHeight = panelState == PanelStates.Expanded
                ? titlePanel.Height + expandedHeight
                : titlePanel.Height;

            SetBounds(Location.X,
                Location.Y,
                Size.Width,
                newHeight);

            if (!DesignMode)
            {
                StateChanged?.Invoke(this, new StateChangedEventArgs(panelState));
            }
        }

        private void moveNextPanel()
        {
            if (nextPanel != null)
            {
                nextPanel.Location = new Point(nextPanel.Location.X,
                    Location.Y + Size.Height);
            }
        }
    }

    [System.Security.Permissions.PermissionSet
    (System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class CollapsiblePanelDesigner : ParentControlDesigner
    {
        private DesignerActionListCollection? actionLists;

        public override DesignerActionListCollection ActionLists
        {
            get => actionLists ??= [new CollapsiblePanelActionList(Component)];
        }
    }

    public class CollapsiblePanelActionList(IComponent component) : DesignerActionList(component)
    {
        private readonly CollapsiblePanel? collapsiblePanel = component as CollapsiblePanel;

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            var method = new DesignerActionMethodItem(this, "Toggle", "Toggle", "", "", true);
            items.Add(method);
            return items;
        }

        public void Toggle()
        {
            if (collapsiblePanel == null)
                return;

            collapsiblePanel.PanelState = collapsiblePanel.PanelState == CollapsiblePanel.PanelStates.Collapsed
                ? CollapsiblePanel.PanelStates.Expanded
                : CollapsiblePanel.PanelStates.Collapsed;
        }

        public CollapsiblePanel.PanelStates PanelState
        {
            get
            {
                var value = GetPropertyByName("PanelState").GetValue(collapsiblePanel);
                if (value != null)
                    return (CollapsiblePanel.PanelStates)value;
                return CollapsiblePanel.PanelStates.Expanded;
            }

            set => GetPropertyByName("PanelState").SetValue(collapsiblePanel, value);
        }

        internal PropertyDescriptor GetPropertyByName(string propName)
        {
            var prop = TypeDescriptor.GetProperties(collapsiblePanel)[propName];
            if (null == prop)
            {
                throw new ArgumentException("Matching property not found.", propName);
            }
            return prop;
        }
    }
}