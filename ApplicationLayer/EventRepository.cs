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
		public int GetCount() => Events.Count;
		public string GetEventName(string date)
		{
			foreach (Event item in Events)
			{
				if (item.EventDate.ToString() == date)
				{
					return item.EventName;
				}
				
			}
			return null;
		}

		public Dictionary<DateTime, Tuple<int, string, string>> eventDateDictionary = new Dictionary<DateTime, Tuple<int, string, string>>();

		public Dictionary<DateTime, Tuple<int, string, string>> AddToDictionary(Event id, Event name, Event date, Event description)
		{
			if (!eventDateDictionary.ContainsKey(date.EventDate))
			{
				eventDateDictionary.Add(date.EventDate, new Tuple<int, string, string>(id.EventId, name.EventName, description.EventDescription ));
			}
			return eventDateDictionary;

		}






		public List<string> GetDate()
		{







			List<string> DateOfEvents = new List<string>();
			foreach (Event events in Events)
			{
				DateOfEvents.Add(events.EventDate.ToString());
			}
			return DateOfEvents;
		}

	}
}
