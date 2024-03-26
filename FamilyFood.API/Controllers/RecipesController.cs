using Microsoft.AspNetCore.Mvc;
using Family_Food.Models;
using Family_Food.Interfaces;
using Family_Food.Data;

namespace Family_Food.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipesController : ControllerBase
{
    private IRecipesRepository _recipesRepository;

    public RecipesController(IRecipesRepository recipesRepository)
    {
        _recipesRepository = recipesRepository;
    }

    //GET: api/recipes
    [HttpGet(Name = "Get All Recipes")]
    public List<Recipe> GetAll()
    {
        return _recipesRepository.GetAllRecipes();
    }

    ////GET: api/recipes/creator
    //[HttpGet(Name = "Get All Recipes By Creator")]
   // Get all recipes from a Single Creator Name


    //POST
    [HttpPost(Name = "Post Recipe")]
    public void Post(Recipe recipe)
    {
        _recipesRepository.AddRecipe(recipe);
    }

    //DELETE
    [HttpDelete(Name ="Delete Recipe")]
    public void Delete(Recipe recipe)
    {
        _recipesRepository.RemoveRecipe(recipe);
    }
}

