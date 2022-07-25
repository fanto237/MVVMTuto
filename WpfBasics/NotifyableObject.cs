using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyDll
{
    public class NotifyableObject : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (!string.IsNullOrEmpty(propertyName))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
