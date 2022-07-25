using Curencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class PersonModel : NotifyableObject
    {
        private string? firstname;
        private string? lastname;
        private string? departement;
        private string Fullname => $"{firstname} {lastname}";

        public string Firstname
        {
            get => firstname; set
            {
                if (value != firstname)
                {
                    firstname = value;
                    this.RaisePropertyChanged();
                    this.RaisePropertyChanged(nameof(Fullname));
                }
            }
        }

        public string Lastname
        {
            get => lastname; set
            {
                if (value != lastname)
                {
                    lastname = value;
                    this.RaisePropertyChanged();
                    this.RaisePropertyChanged(nameof(Fullname));
                }
            }
        }

        public string Departement
        {
            get => departement; set
            {
                if (value != departement)
                {
                    departement = value;
                    this.RaisePropertyChanged();

                }
            }
        }


    }
}
