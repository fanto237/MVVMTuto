using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curencies
{
	internal class CurencyViewModel : BaseViewModel
	{

		private decimal _value;
		public decimal Value
		{
			get => _value; set
			{
				if (_value != value)
					_value = value;
			}
		}
	}
}
