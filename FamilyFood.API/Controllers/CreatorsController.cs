using Family_Food.Repositories;
using Family_Food.Models;
using Family_Food.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Family_Food.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CreatorsController : ControllerBase
{
    private ICreatorsRepository _creatorsRepository;

    public CreatorsController(ICreatorsRepository creatorsRepository)
    {
        _creatorsRepository = creatorsRepository;
    }

    //GET
    [HttpGet]
    public List<Creator> Get()
    {
        return _creatorsRepository.GetAllCreators();
    }

    //POST
    [HttpPost]
    public void Post(Creator creator)
    {
        _creatorsRepository.AddCreator(creator);
    }

    //DELETE
    [HttpDelete]
    public void Delete(Creator creator)
    {
        _creatorsRepository.RemoveCreator(creator);
    }
}
    
