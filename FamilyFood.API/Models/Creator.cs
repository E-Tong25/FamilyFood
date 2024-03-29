using System;
using System.ComponentModel.DataAnnotations;
using Family_Food.Classes;

namespace Family_Food.Models
{
	public class Creator : User
	{
		public List<Recipe> Recipes { get; set; }
	}
}

