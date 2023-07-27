using System.Net.Sockets;

namespace printing_om_and_pm_system_app.Db
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
			base(options)
		{
			
		}
        
        public DbSet<User> Users { get; set; }

    }
}