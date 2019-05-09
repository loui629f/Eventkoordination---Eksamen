using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLibrary;

namespace Eventkoordination___Eksamen
{
    public class Controller
    {
        private DBController dbController = new DBController();
      

        public void CreateEvent(int eventId, string eventName, DateTime eventDate, string eventDescription)
        {
            dbController.CreateEvent(eventId, eventName, eventDate, eventDescription);
        }
    }

    
}
