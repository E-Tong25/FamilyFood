using System;
using Family_Food.Data;
using Family_Food.Interfaces;
using Family_Food.Models;

namespace Family_Food.Repositories
{
    public class CreatorsRepository : ICreatorsRepository
    {
        public FamilyFoodContext ctx;
        public CreatorsRepository(FamilyFoodContext _ctx)
        {
            ctx = _ctx;
        }

        public void AddCreator(Creator creator)
        {
            ctx.Creators.Add(creator);
        }

        public List<Creator> GetAllCreators()
        {
            return ctx.Creators.ToList(); 
        }

        public List<T> GetAllCreatorsofType<T>() where T : Recipe
        {
            return ctx.Creators.OfType<T>().ToList();
        }

        public void RemoveCreator(Creator creator)
        {
            var creatorToDelete = ctx.Creators.Where(c => c.Id == creator.Id).FirstOrDefault();
        }
    }
}

