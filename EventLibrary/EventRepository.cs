using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLibrary
{
    public class EventRepository
    {
        private List<Event> Events = new List<Event>();
        private Event event1 = new Event();

        public void CreateEvent(int eventId, string eventName, DateTime eventDate, string eventDescription)
        {
            Event even = new Event(eventId, eventName, eventDate, eventDescription);
            event1 = even;

        }

    }
}
