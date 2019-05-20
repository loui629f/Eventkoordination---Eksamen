using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
    class UserRepository
    {
		public List<User> Users { get; private set; } = new List<User>();
	}
}
