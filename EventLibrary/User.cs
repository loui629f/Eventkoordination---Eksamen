﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class User
    {

		public string UserEmail { get; set; }
		public string UserName { get; set; }
		public string UserPassword { get; set; }

		public User(string userEmail, string userName, string userPassword)
		{
			UserEmail = userEmail;
			UserName = userName;
			UserPassword = userPassword;
		}

    }
}
