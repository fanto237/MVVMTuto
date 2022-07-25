using MyDll;

namespace PersonList
{
    public class Person : NotifyableObject
    {
        private string firstname;
        private string lastname;
        private string departement;
        public string FullName => $"{firstname} {lastname}";

        public string Firstname
        {
            get => firstname; set
            {
                if (value != firstname)
                {
                    firstname = value;
                    this.RaisePropertyChanged();
                    this.RaisePropertyChanged(nameof(FullName));
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
                    this.RaisePropertyChanged(nameof(FullName));
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
