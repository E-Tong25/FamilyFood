using System;
using Family_Food.Models;

namespace Family_Food.Interfaces
{
	public interface ICreatorsRepository
	{
		List<Creator> GetAllCreators();
		List<T> GetAllCreatorsofType<T>() where T : Recipe;
        void AddCreator(Creator creator);
        void RemoveCreator(Creator creator);
	}
}

