using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
  public class Shift
  {
		public int ShiftId { get; set; }
		public int EventId { get; set; }
		public string UserEmail { get; set; }
		public DateTime ShiftDate { get; set; }
		public string ShiftType { get; set; }

  }


}
