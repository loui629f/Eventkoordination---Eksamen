using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
    public class EventRepository
    {
		public List<Event> Events { get; private set; } = new List<Event>();
        
	
        
		public void Add(Event newEvent)
		{
			Events.Add(newEvent);
		}

		public string GetDate()
		{
			return Events.OfType<DateTime>().ToString();
		}

	}
}
