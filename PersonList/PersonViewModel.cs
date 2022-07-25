using Curencies;
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
        ObservableCollection<PersonModel> persons = new ObservableCollection<PersonModel>();
        public PersonViewModel()
        {
            Person = new PersonModel();
        }
        PersonModel person;
        public PersonModel Person
        {
            get => person; set
            {
                if (person != value)
                {
                    person = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public DelegateCommand Save { get; set; }
    }
}
