using Microsoft.EntityFrameworkCore;

namespace Produtos.Models
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        { }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>().HasKey(m => m.Id);

            base.OnModelCreating(builder);
        }
    }
}
