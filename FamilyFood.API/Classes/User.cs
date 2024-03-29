using System;
using Family_Food.Models;
using Family_Food.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Family_Food.Classes
{
	public class User: IUser
	{
        public Guid Id { get; set; } = Guid.NewGuid();
        public Creator? Creator { get; set; }
        //Allow up to 40 uppercase and lowercase characters.
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

