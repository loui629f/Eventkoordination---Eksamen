using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
    class CommentRepository
    {
		public List<Comment> Comments { get; private set; } = new List<Comment>();

		public void Add(Comment comment)
		{
			Comments.Add(comment);
		}
	}
}
