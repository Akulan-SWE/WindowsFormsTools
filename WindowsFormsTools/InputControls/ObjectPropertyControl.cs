using System.Numerics;
using System.Reflection;

namespace WindowsFormsTools.InputControls
{
    public partial class ObjectPropertyControl : UserControl
    {
        private static readonly Dictionary<Type, Func<ObjectPropertyControl, PropertyInfo, Control>> propertyFuncs = new Dictionary
            <Type, Func<ObjectPropertyControl, PropertyInfo, Control>>
            {
                {
                    typeof(Single),
                    (opc, p) => opc.addRangeControl(p, false)
                },
                {
                    typeof(int),
                    (opc, p) => opc.addRangeControl(p, true)
                },
                {
                    typeof(Color),
                    (opc, p) => opc.addColorControl(p)
                },
                {
                    typeof(Vector2),
                    (opc, p) => opc.addVectorControl(p)
                }
            };

        private static readonly Dictionary<Type, Func<ObjectPropertyControl, FieldInfo, Control>> fieldFuncs = new Dictionary
            <Type, Func<ObjectPropertyControl, FieldInfo, Control>>
            {
                {
                    typeof(Single),
                    (opc, p) => opc.addRangeControl(p, false)
                },
                {
                    typeof(int),
                    (opc, p) => opc.addRangeControl(p, true)
                },
                {
                    typeof(Color),
                    (opc, p) => opc.addColorControl(p)
                },
                {
                    typeof(Vector2),
                    (opc, p) => opc.addVectorControl(p)
                }
            };

        public object? TargetObject
        {
            get => targetObject;
            set
            {
                targetObject = value;
                initControls();
            }
        }

        private void initControls()
        {
            flowLayoutPanel.Controls.Clear();
            if (targetObject != null)
            {

                var fields = targetObject.GetType().GetFields();
                foreach (var field in fields)
                {
                    if (fieldFuncs.TryGetValue(field.FieldType, out var createAction))
                    {
                        var control = createAction(this, field);
                        flowLayoutPanel.Controls.Add(control);
                    }
                }

                var properties = targetObject.GetType().GetProperties();
                foreach (var property in properties)
                {
                    if (propertyFuncs.TryGetValue(property.PropertyType, out var createAction))
                    {
                        var control = createAction(this, property);
                        flowLayoutPanel.Controls.Add(control);
                    }
                }
            }
        }

        #region Property Funcs

        private Control addRangeControl(PropertyInfo property, bool isDiscrete)
        {
            var rangeControl = new RangeControl();
            rangeControl.Header = property.Name;
            rangeControl.IsDiscrete = isDiscrete;
            if (isDiscrete)
            {
                var value = (int)property.GetValue(TargetObject);
                var range = getDefaultRange(value);
                rangeControl.A = range.Item1;
                rangeControl.B = range.Item2;
                rangeControl.Value = value;
                rangeControl.ValueChanged += (s, e) =>
                    property.SetValue(TargetObject, (int)e.NewValue);
            }
            else
            {
                var value = (float)property.GetValue(TargetObject);
                var range = getDefaultRange(value);
                rangeControl.A = range.Item1;
                rangeControl.B = range.Item2;
                rangeControl.Value = value;
                rangeControl.ValueChanged += (s, e) =>
                    property.SetValue(TargetObject, e.NewValue);
            }
            return rangeControl;
        }

        private Control addVectorControl(PropertyInfo property)
        {
            var vectorControl = new PreciseVectorControl();
            vectorControl.Header = property.Name;
            vectorControl.Value = (Vector2)property.GetValue(TargetObject);
            vectorControl.ValueChanged += (s, e) =>
                property.SetValue(TargetObject, e.NewValue);
            return vectorControl;
        }

        private Control addColorControl(PropertyInfo property)
        {
            var colorControl = new ColorControl();
            colorControl.Header = property.Name;
            colorControl.Value = (Color)property.GetValue(TargetObject);
            colorControl.ValueChanged += (s, e) =>
                property.SetValue(TargetObject, e.NewValue);
            return colorControl;
        }

        #endregion

        #region Field Funcs

        private Control addRangeControl(FieldInfo field, bool isDiscrete)
        {
            var rangeControl = new RangeControl();
            rangeControl.Header = field.Name;
            rangeControl.IsDiscrete = isDiscrete;
            if (isDiscrete)
            {
                var value = (int)field.GetValue(TargetObject);
                var range = getDefaultRange(value);
                rangeControl.A = range.Item1;
                rangeControl.B = range.Item2;
                rangeControl.Value = value;
                rangeControl.ValueChanged += (s, e) => field.SetValue(TargetObject, (int)e.NewValue);
            }
            else
            {
                var value = (float)field.GetValue(TargetObject);
                var range = getDefaultRange(value);
                rangeControl.A = range.Item1;
                rangeControl.B = range.Item2;
                rangeControl.Value = value;
                rangeControl.ValueChanged += (s, e) => field.SetValue(TargetObject, e.NewValue);
            }
            return rangeControl;
        }

        private Control addVectorControl(FieldInfo field)
        {
            var vectorControl = new PreciseVectorControl();
            vectorControl.Header = field.Name;
            vectorControl.Value = (Vector2)field.GetValue(TargetObject);
            vectorControl.ValueChanged += (s, e) =>
            {
                field.SetValue(TargetObject, e.NewValue);
            };
            return vectorControl;
        }

        private Control addColorControl(FieldInfo field)
        {
            var colorControl = new ColorControl();
            colorControl.Header = field.Name;
            colorControl.Value = (Color)field.GetValue(TargetObject);
            colorControl.ValueChanged += (s, e) =>
            {
                field.SetValue(TargetObject, e.NewValue);
            };
            return colorControl;
        }

        #endregion

        private object? targetObject;

        public ObjectPropertyControl()
        {
            InitializeComponent();
        }

        private (decimal, decimal) getDefaultRange(float value)
        {
            return ((decimal)value - 100, (decimal)value + 100);
        }

        private (decimal, decimal) getDefaultRange(int value)
        {
            int start = value > 0 ? 0 : value - 100;
            int end = value < 100 ? 100 : value + 100;
            return (start, end);
        }
    }
}
