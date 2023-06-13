using Microsoft.EntityFrameworkCore;

namespace TestowyKolos2.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pastry> Pastries { get; set; }
        public DbSet<OrderPastry> OrderPastries { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(e =>
            {
                e.HasData(new Client
                {
                    ID = 1,
                    FirtName = "Zbychu",
                    LastName = "Zbyszkowski"
                });
            });
            modelBuilder.Entity<Order>(e =>
            {
                e.HasData(new Order
                {
                    Id = 1,
                    AcceptedAt = DateTime.UtcNow,
                    ClientID = 1,
                    EmployeeID = 1,
                }
                );
            }
            );
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(new Employee
                {
                    ID = 1,
                    FirtName = "Zbychu2",
                    LastName = "Zbyszkowski2"
                });
            });
            modelBuilder.Entity<Pastry>(e =>
            {
                e.HasData(new Pastry()
                {
                    ID = 1,
                    Name = "Ciastko",
                    Price = 12.4M,
                    Type = "Ciasto"
                });
            });
            modelBuilder.Entity<OrderPastry>(e =>
            {
                e.ToTable("Order_Pastry");

                e.HasData(new OrderPastry
                {
                    OrderID = 1,
                    PastryID = 1,
                    Amount = 5,
                    Comments = "dsdadsds"
                });
            });
        }

    }
}
