using System.Net.Sockets;

namespace printing_om_and_pm_system_app.Db
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
			base(options)
		{
			
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Users)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.User_ID);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Orders)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(o => o.Order_ID);
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Items)
                .WithMany(i => i.OrderItems)
                .HasForeignKey(i => i.Item_ID);

            modelBuilder.Entity<ItemService>()
                .HasOne(its => its.Items)
                .WithMany(i => i.ItemServices)
                .HasForeignKey(i => i.Item_ID);
            modelBuilder.Entity<ItemService>()
                .HasOne(its => its.Services)
                .WithMany(s => s.ItemServices)
                .HasForeignKey(s => s.Service_ID);

            modelBuilder.Entity<ProcessService>()
                .HasOne(ps => ps.Processes)
                .WithMany(p => p.ProcessServices)
                .HasForeignKey(p => p.Process_ID);
            modelBuilder.Entity<ProcessService>()
                .HasOne(ps => ps.Services)
                .WithMany(s => s.ProcessServices)
                .HasForeignKey(s => s.Service_ID);

            modelBuilder.Entity<Service>()
                .HasOne(s => s.Machines)
                .WithMany(m => m.Services)
                .HasForeignKey(s => s.Machine_ID);

            modelBuilder.Entity<Service>()
                .HasOne(s => s.Materials)
                .WithMany(m => m.Services)
                .HasForeignKey(s => s.Material_ID);
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