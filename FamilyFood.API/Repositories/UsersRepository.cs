using System;
using Family_Food.Classes;
using Family_Food.Data;
using Family_Food.Interfaces;
using Family_Food.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Family_Food.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public FamilyFoodContext ctx;
        public UsersRepository(FamilyFoodContext _ctx)
        {
            ctx = _ctx;
        }

        public List<User> GetAllUsers()
        {
            return ctx.Users.ToList(); 
        }

        public List<T> GetUserofType<T>() where T : User
        {
            return ctx.Users.OfType<T>().ToList();
        }

        public void AddUser(User user)
        {
            ctx.Users.Add(user);
        }
        public void RemoveUser(User user)
        {
            var userToDelete = ctx.Users.Where(c => c.Id == user.Id).FirstOrDefault();
        }
    }
}

