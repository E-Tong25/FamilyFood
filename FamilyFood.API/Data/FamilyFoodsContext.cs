using System;
using Family_Food.Models;
using Family_Food.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace Family_Food.Data
{
	public class FamilyFoodContext : DbContext
	{
        public DbSet<Recipe> Recipes { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Creator> Creators { get; set; }
		public DbSet<User> Users { get; set; }

        public string DbPath { get; }

		public FamilyFoodContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = Path.Join(path, "familyFood.db");
		}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
			options.UseSqlite($"Data Source={DbPath}");
        }

    }
}

