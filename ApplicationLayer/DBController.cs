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


		public void CreateEventAdmin(string eventName, DateTime eventDate, string eventDescription)
		{

			Event newEvent = new Event(eventName, eventDate, eventDescription);

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand createEventAdmin = new SqlCommand("spInsertEventAdmin", con);
					createEventAdmin.CommandType = CommandType.StoredProcedure;
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





		public EventRepository ShowConfirmedEvent()
		{

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand showConfirmedEvent = new SqlCommand("spSelectConfirmedEvents", con);
					showConfirmedEvent.CommandType = CommandType.StoredProcedure;
					EventRepository eventRepository = new EventRepository();
					Event newEvent;
					SqlDataReader showConfirmedEventReader = showConfirmedEvent.ExecuteReader();

					if (showConfirmedEventReader.HasRows)
					{
						while (showConfirmedEventReader.Read())
						{
							newEvent = new Event
							{
								EventId = Convert.ToInt32(showConfirmedEventReader["EventId"].ToString()),
								EventName = showConfirmedEventReader["EventName"].ToString(),
								EventDate = Convert.ToDateTime(showConfirmedEventReader["EventDate"].ToString()),
								EventDescription = showConfirmedEventReader["EventDescription"].ToString()
							};

							eventRepository.Add(newEvent);

						}
					}
					return eventRepository;
				}
				catch (Exception exception)
				{
					throw exception;
				}





			}
		}

	}
}
