using System.ComponentModel;
using System.Runtime.CompilerServices;
using VisualStateTriggers.Models;

namespace VisualStateTriggers.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _animalDescription;
        public string AnimalDescription
        {
            get => _animalDescription;
            set
            {
                _animalDescription = value;
                OnPropertyChanged();
            }
        }

        private AnimalType _animal = AnimalType.Cat;
        public AnimalType Animal
        {
            get => _animal;
            set
            {
                _animal = value;
                OnPropertyChanged();
            }
        }

        private string _selectedView = "Cat";
        public string SelectedView
        {
            get => _selectedView;
            set
            {
                _selectedView = value;
                Animal = Enum<AnimalType>.Parse(value);
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            AnimalDescription = AnimalType.Cat.ToString();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}