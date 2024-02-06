using Microsoft.EntityFrameworkCore;
using System;

namespace Chart.Models
{
	public class AppDb : DbContext
	{
        public AppDb(DbContextOptions<AppDb> options) : base(options)
		{
                
        }
		

		public DbSet<Example> Examples { get; set; }
	}
}
