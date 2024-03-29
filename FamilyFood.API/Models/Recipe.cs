using System;
using System.ComponentModel.DataAnnotations;

namespace Family_Food.Models
{
	// Recipes should include name of the recipe, a list of ingredients (includes the name of the ingredient and amount of), and author
	public class Recipe
	{
		public Guid Id { get; set; } = Guid.NewGuid();

		[Required(ErrorMessage ="Name of recipe is required.")]
		[StringLength(50, ErrorMessage ="The {0} value cannot exceed {1} characters.")]
		public string Name { get; set; }

		[Required(ErrorMessage ="Ingredients are required.")]
		[Range(1,40, ErrorMessage ="For a {0}, there must be between {1} and {2}.")]
		public ICollection<Ingredient> Ingredients { get; set; }

		public Guid CreatorId { get; set; } = Guid.NewGuid();
		public Creator Creator { get; set; } = null!;

		public DateTime OriginallyCreated { get; set; }
	}
}

