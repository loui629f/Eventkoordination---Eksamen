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

                    SqlCommand createEventAdmin = new SqlCommand("spInsertEventAdmin", con);
                    createEventAdmin.CommandType = CommandType.StoredProcedure;
                    createEventAdmin.Parameters.Add(new SqlParameter("@EventId", newEvent.EventId));
                    createEventAdmin.Parameters.Add(new SqlParameter("@EventName", newEvent.EventName));
                    createEventAdmin.Parameters.Add(new SqlParameter("@EventDate", newEvent.EventDate));
                    createEventAdmin.Parameters.Add(new SqlParameter("@EventDescription", newEvent.EventDescription));

                    createEventAdmin.ExecuteNonQuery();


                }
                catch
                {
                    throw new NotImplementedException();
                }
            }

        }





        /*public List<string> ShowNotConfirmedEvent()
        {
            List<string> dbInfo = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
				try
				{
					con.Open();

					SqlCommand showNotConfirmedEvent = new SqlCommand("spSelectAllEvents", con);
					showNotConfirmedEvent.CommandType = CommandType.StoredProcedure;

					SqlDataReader showNotConfirmedEventReader = showNotConfirmedEvent.ExecuteReader();

					if (showNotConfirmedEventReader.HasRows)
					{
						while (showNotConfirmedEventReader.Read())
						{
							string eventId = showNotConfirmedEventReader["EventId"].ToString();
							string eventName = showNotConfirmedEventReader["EventName"].ToString();
							string eventDate = showNotConfirmedEventReader["EventDate"].ToString();
							string eventDescription = showNotConfirmedEventReader["EventDescription"].ToString();
							//Indsæt i GUI
						}
					}
				}
				catch
				{
					throw new NotImplementedException();
				}

            }
        }*/
    }

}
