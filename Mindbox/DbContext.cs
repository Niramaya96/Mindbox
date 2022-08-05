namespace Mindbox
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Category> Categories { get; set; } = new();
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new();
    }
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Database.db");
        }
    }
}