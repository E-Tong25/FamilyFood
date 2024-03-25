using Family_Food.Interfaces;
using Family_Food.Models;
using Microsoft.AspNetCore.Mvc;

namespace Family_Food.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CreatorsController : ControllerBase
{
    private ICreatorsRepository _creatorsRepository;

    public CreatorsController(ICreatorsRepository creatorsRepository)
    {
        _creatorsRepository = creatorsRepository;
    }

    //GET
    [HttpGet(Name = "Get All Creators")]
    public List<Creator> Index()
    {
        return _creatorsRepository.GetAllCreators();
    }

    //POST
    [HttpPost(Name = "Post Creator")]
    public void Post(Creator creator)
    {
        _creatorsRepository.AddCreator(creator);
    }

    //DELETE
    [HttpDelete(Name = "Delete Creator")]
    public void Delete(Creator creator)
    {
        _creatorsRepository.RemoveCreator(creator);
    }
}
    
