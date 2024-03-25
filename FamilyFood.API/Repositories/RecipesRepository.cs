using System;
using Family_Food.Data;
using Family_Food.Interfaces;
using Family_Food.Models;

namespace Family_Food.Repositories
{
	public class RecipesRepository:IRecipesRepository
	{
        public FamilyFoodContext ctx;
        public RecipesRepository(FamilyFoodContext _ctx)
        {
            ctx = _ctx;
        }

        public List<Recipe> GetAllRecipes()
        {
            return ctx.Recipes.ToList();
        }

        public List<T> GetAllRecipesofType<T>() where T : Creator
        {
            return ctx.Recipes.OfType<T>().ToList();
        }

        public void AddRecipe(Recipe recipe)
        {
            ctx.Recipes.Add(recipe);
            ctx.SaveChanges();
        }

        public void RemoveRecipe(Recipe recipe)
        {
            var recipeToDelete = ctx.Recipes.Where(r => r.Id == recipe.Id).FirstOrDefault();
            if (recipeToDelete != null)
            {
                ctx.Recipes.Remove(recipeToDelete);
                ctx.SaveChanges();
                return;
            }
        }
    }
}

