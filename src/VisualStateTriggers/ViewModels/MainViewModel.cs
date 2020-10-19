using System.Collections.ObjectModel;
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

        private ObservableCollection<AnimalModel> _animals = new ObservableCollection<AnimalModel>();
        public ObservableCollection<AnimalModel> Animals
        {
            get => _animals;
            set
            {
                _animals = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            AnimalDescription = AnimalType.Cat.ToString();

            Animals.Add(new AnimalModel() { Animal = AnimalType.Bird, AnimalName = "Jack", AnimalDescription = "Sparrow" });
            Animals.Add(new AnimalModel() { Animal = AnimalType.Cat, AnimalName = "Cheshire", AnimalDescription = "Tabby British Shorthair" });
            Animals.Add(new AnimalModel() { Animal = AnimalType.Bird, AnimalName = "Woody", AnimalDescription = "Woodpecker" });
            Animals.Add(new AnimalModel() { Animal = AnimalType.Dog, AnimalName = "Laika", AnimalDescription = "Space dog" });
            Animals.Add(new AnimalModel() { Animal = AnimalType.Dog, AnimalName = "Lassie", AnimalDescription = "Collie" });
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}