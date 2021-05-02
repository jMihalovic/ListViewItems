using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewItems
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set { surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set { birthDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BirthDate")); }
        }

        public static ObservableCollection<Person> AllPeople { get; set; } = new ObservableCollection<Person>();

        public static void InitPeople()
        {
            AllPeople.Add(new Person
            {
                Name = "Jakub",
                Surname = "Mihalovič",
                BirthDate = new DateTime(2002, 12, 17)
            });

            AllPeople.Add(new Person
            {
                Name = "Jan",
                Surname = "Novák",
                BirthDate = new DateTime(1980, 6, 23)
            });

            AllPeople.Add(new Person
            {
                Name = "Josef",
                Surname = "Mihalovič",
                BirthDate = new DateTime(1970, 5, 5)
            });

            AllPeople.Add(new Person
            {
                Name = "Kryštof",
                Surname = "Srnka",
                BirthDate = new DateTime(2020, 7, 27)
            });

        }

    }
}
