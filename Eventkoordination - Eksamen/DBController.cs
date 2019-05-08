using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eventkoordination___Eksamen
{
   public class DBController
   {

		private static string connectionString =
			"Server=EALSQL1.eal.local; Database=A_DB23_2018; User Id=A_STUDENT17; Password=A_OPENDB23;";


		public void ShowEvent(int eventId, string eventName, DateTime eventDate, string eventDescription)
		{

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand showEvent = new SqlCommand("SelectAllEvents", con);
					showEvent.CommandType = CommandType.StoredProcedure;
					showEvent.Parameters.Add(new SqlParameter("@EventId", eventId));
					showEvent.Parameters.Add(new SqlParameter("@EventName", eventName));
					showEvent.Parameters.Add(new SqlParameter("@EventDate", eventDate));
					showEvent.Parameters.Add(new SqlParameter("@EventDescription", eventDescription));

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
