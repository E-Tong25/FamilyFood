using Family_Food.Repositories;
using Family_Food.Classes;
using Family_Food.Interfaces;
using Family_Food.Models;
using Microsoft.AspNetCore.Mvc;

namespace Family_Food.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UsersController : ControllerBase
{
    private IUsersRepository _usersRepository;

    public UsersController(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    //GET
    [HttpGet(Name = "Get All Users")]
    public List<User> Index()
    {
        return _usersRepository.GetAllUsers();
    }

    //POST
    [HttpPost(Name = "Post User")]
    public void Post(User user)
    {
        _usersRepository.AddUser(user);
    }

    //DELETE
    [HttpDelete(Name = "Delete User")]
    public void Delete(User user)
    {
        _usersRepository.RemoveUser(user);
    }
}




