using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class Controller
    {
		public DBController dbcon = new DBController();
		private EventRepository eventRepo = new EventRepository();

		public void CreateEventAdmin(int eventId, string eventName, DateTime eventDate, string eventDescription)
		{
			dbcon.CreateEventAdmin(eventId, eventName, eventDate, eventDescription);
		}

		public EventRepository ShowNotConfirmedEvent()
		{
			eventRepo = dbcon.ShowNotConfirmedEvent();
			return eventRepo;
			
		}

	}


}
