using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Curencies
{
	internal class BaseViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler? PropertyChanged;

		public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = "")
		{
			if (!string.IsNullOrEmpty(propertyName))
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
