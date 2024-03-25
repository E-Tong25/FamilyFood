using System;
using Family_Food.Classes;
using Family_Food.Models;

namespace Family_Food.Interfaces
{
	public interface IUsersRepository
	{
		List<User> GetAllUsers();
		List<T> GetUserofType<T>() where T : User;
        void AddUser(User user);
        void RemoveUser(User user);
	}
}

