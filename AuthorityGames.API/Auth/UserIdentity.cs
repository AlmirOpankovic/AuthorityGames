﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Security;

namespace AuthorityGames.API.Auth
{
	public class UserIdentity : IUserIdentity
	{
		public IEnumerable<string> Claims { get; set; }

		public string UserName { get; set; }
	}
}
