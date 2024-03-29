using System;
using System.ComponentModel.DataAnnotations;
using Family_Food.Classes;

namespace Family_Food.Models
{
	public class Creator : User
	{
		public Guid Id { get; set; }
		public int UserID { get; set; }
		//Allow up to 40 uppercase and lowercase characters.
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public User User { get; set; } = null!;
		public List<Recipe> Recipes { get; set; }
	}
}

