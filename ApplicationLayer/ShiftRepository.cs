using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
    class ShiftRepository
    {
		public List<Shift> Shifts { get; private set; } = new List<Shift>();

		public void Add(Shift shift)
		{
			Shifts.Add(shift);
		}
	}
}
