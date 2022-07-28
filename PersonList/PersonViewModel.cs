using MyDll;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class PersonViewModel : NotifyableObject
    {

        public PersonViewModel()
        {
            AddPersonCommand = new(AddPerson);
        }


        private Person newPerson = new();
        public Person NewPerson
        {
            get => newPerson;
            set
            {
                if (newPerson != value)
                {
                    newPerson = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private ObservableCollection<Person> persons = new();
        public ObservableCollection<Person> Persons
        {
            get => persons;
            set
            {
                if (value != persons)
                {
                    persons = value;
                    this.RaisePropertyChanged();
                }
            }
        }


        public DelegateCommand AddPersonCommand
        {
            get; set;
        }

        public void AddPerson(object o)
        {
            this.persons.Add(newPerson);
            NewPerson = new();
        }
    }
}
