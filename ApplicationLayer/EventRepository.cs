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
		public int GetId(int index)
		{
			return Events[index].EventId;
		}
		public string GetName(int index)
		{
			return Events[index].EventName;
		}
		public DateTime GetDate(int index)
		{
            return Events[index].EventDate;
		}
		public string GetDescription(int index)
		{
			return Events[index].EventDescription;
		}

	}
}
