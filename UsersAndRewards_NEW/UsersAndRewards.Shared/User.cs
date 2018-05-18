using System;
using System.Collections.Generic;
using System.Linq;

namespace UsersAndRewards.Shared
{
	public class User
	{
		public int UserId { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime Birthdate { get; set; }

		public int Age { get; }

		public List<Reward> Rewards { get; set; }

		public User()
		{

		}
	}
}
