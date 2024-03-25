using System;
namespace Family_Food.Models
{
	public class Ingredient
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Name { get; set;}
		//how to get a unit type for recipes like ounces and cups
		public string Amount { get; set; }
	}
}

