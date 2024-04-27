using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApiProject
{
	public class ApplicationDbContext:DbContext
	{
		public DbSet<Product> Products { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){ }
		
	}
}
