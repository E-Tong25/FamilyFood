using System;
namespace Family_Food.Interfaces
{
	public interface IUser
	{
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}

