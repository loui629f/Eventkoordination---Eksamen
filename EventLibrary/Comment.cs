using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{ 
    public class Comment
    {

		public int CommentId { get; set; }
		public string UserEmail { get; set; }
		public string CommentUser { get; set; }


		public Comment(string userEmail, string commentUser)
		{
			UserEmail = userEmail;
			CommentUser = commentUser;
		}

		public Comment(int commentId, string userEmail, string commentUser)
		{
			CommentId = commentId;
			UserEmail = userEmail;
			CommentUser = commentUser;
		}

    }
   
}
