using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DomainLayer;
namespace ApplicationLayer
{
    public class DBController
    {

        private static string connectionString =
            "Server=EALSQL1.eal.local; Database=A_DB17_2018; User Id=A_STUDENT17; Password=A_OPENDB17;";

        private EventRepository eventRepo = new EventRepository();


        public void CreateEventAdmin(int eventId, string eventName, DateTime eventDate, string eventDescription, bool eventConfirmed)
        {

            Event newEvent = new Event(eventId, eventName, eventDate, eventDescription);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand createEvent = new SqlCommand("spInsertEventAdmin", con);
                    createEvent.CommandType = CommandType.StoredProcedure;
                    createEvent.Parameters.Add(new SqlParameter("@EventId", newEvent.EventId));
                    createEvent.Parameters.Add(new SqlParameter("@EventName", newEvent.EventName));
                    createEvent.Parameters.Add(new SqlParameter("@EventDate", newEvent.EventDate));
                    createEvent.Parameters.Add(new SqlParameter("@EventDescription", newEvent.EventDescription));

                    createEvent.ExecuteNonQuery();


                }
                catch
                {
                    throw new NotImplementedException();
                }
            }

        }





        public void ShowEvent(int eventId, string eventName, DateTime eventDate, string eventDescription, bool eventConfirmed)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand showEvent = new SqlCommand("spSelectAllEvents", con);
                    showEvent.CommandType = CommandType.StoredProcedure;
                    showEvent.Parameters.Add(new SqlParameter("@EventId", eventId));
                    showEvent.Parameters.Add(new SqlParameter("@EventName", eventName));
                    showEvent.Parameters.Add(new SqlParameter("@EventDate", eventDate));
                    showEvent.Parameters.Add(new SqlParameter("@EventDescription", eventDescription));
					showEvent.Parameters.Add(new SqlParameter("@EventConfirmed", eventConfirmed));

                    showEvent.ExecuteNonQuery();


                }
                catch
                {
                    throw new NotImplementedException();
                }
            }
        }
    }

}
