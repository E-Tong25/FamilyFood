using System;
using Family_Food.Models;
using Family_Food.Interfaces;

namespace Family_Food.Classes
{
	public class User: IUser
	{
        public Guid Id { get; set; } = Guid.NewGuid();
        public Creator? Creator { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

