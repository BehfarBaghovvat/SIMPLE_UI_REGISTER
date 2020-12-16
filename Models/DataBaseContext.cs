﻿using System.Data.Entity.Migrations.Infrastructure;

namespace Models
{
	public class DataBaseContext : System.Data.Entity.DbContext
	{
		static DataBaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>());
		}
		public DataBaseContext() : base()
		{

		}
		
		public System.Data.Entity.DbSet<User> Users { get; set; }
	}
}
