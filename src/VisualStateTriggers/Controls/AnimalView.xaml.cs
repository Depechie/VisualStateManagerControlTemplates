using Xamarin.Forms;
using VisualStateTriggers.Models;

namespace VisualStateTriggers.Controls
{
    public partial class AnimalView : ContentView
    {
        public static readonly BindableProperty AnimalDescriptionProperty = BindableProperty.Create(nameof(AnimalDescription),
            typeof(string),
            typeof(AnimalView),
            default(string));

        public static readonly BindableProperty AnimalProperty = BindableProperty.Create(nameof(Animal),
            typeof(AnimalType),
            typeof(AnimalView),
            default(AnimalType));

        public string AnimalDescription
        {
            get => (string)GetValue(AnimalDescriptionProperty);
            set => SetValue(AnimalDescriptionProperty, value);
        }

        public AnimalType Animal
        {
            get => (AnimalType)GetValue(AnimalProperty);
            set => SetValue(AnimalProperty, value);
        }

        public AnimalView()
        {
            InitializeComponent();
        }
    }
}