using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }

     
          

        public Event(int eventId, string eventName, DateTime eventDate, string eventDescription)
        {
            EventId = eventId;
            EventName = eventName;
            EventDate = eventDate;
            EventDescription = eventDescription;
        }


        public Event()
        {
            
            
        }
    }
    
}
