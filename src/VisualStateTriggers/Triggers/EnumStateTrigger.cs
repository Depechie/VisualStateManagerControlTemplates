using System;
using Xamarin.Forms;

namespace VisualStateTriggers.Triggers
{
    public class EnumStateTrigger : StateTriggerBase
    {
        public static readonly BindableProperty EnumTypeProperty = BindableProperty.Create(nameof(EnumType), typeof(Type), typeof(EnumStateTrigger), null);

        public static readonly BindableProperty EnumValueProperty = BindableProperty.Create(nameof(EnumValue), typeof(object), typeof(EnumStateTrigger), null, propertyChanged: OnBindablePropertyChanged);

        public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(object), typeof(EnumStateTrigger), null, propertyChanged: OnBindablePropertyChanged);

        public Type EnumType
        {
            get => (Type)GetValue(EnumTypeProperty);
            set => SetValue(EnumTypeProperty, value);
        }

        public object EnumValue
        {
            get => (object)GetValue(EnumValueProperty);
            set => SetValue(EnumValueProperty, value);
        }

        public object Value
        {
            get => (object)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        private static void OnBindablePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var trigger = bindable as EnumStateTrigger;
            trigger.UpdateTrigger();
        }

        private void UpdateTrigger()
        {
            if (EnumType is null || EnumValue is null || Value is null || !EnumType.IsEnum || !EnumType.IsEnumDefined(EnumValue) || !EnumType.IsEnumDefined(Value))
                SetActive(false);
            else
                SetActive(Enum.Equals(EnumValue, Value));
        }
    }
}