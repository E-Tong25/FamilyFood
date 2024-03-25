using System;
using Family_Food.Models;

namespace Family_Food.Interfaces
{
	public interface IRecipesRepository
	{
		List<Recipe> GetAllRecipes();
		List<T> GetAllRecipesofType<T>() where T : Creator;
        void AddRecipe(Recipe recipe);
        void RemoveRecipe(Recipe recipe);
	}
}

