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
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemService> ItemServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<ProcessService> ProcessServices { get; set; }

    }
}