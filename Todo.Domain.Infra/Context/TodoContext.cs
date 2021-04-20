using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Domain.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().ToTable("Todo");
            modelBuilder.Entity<TodoItem>().Property(x => x.Id);
            modelBuilder.Entity<TodoItem>().Property(x => x.User).HasMaxLength(120).HasColumnType("varchar");
            modelBuilder.Entity<TodoItem>().Property( x=> x.Title).HasMaxLength(160).HasColumnType("varchar");
            modelBuilder.Entity<TodoItem>().Property(x => x.Done).HasColumnType("bit");
            modelBuilder.Entity<TodoItem>().Property(x => x.Date);
            modelBuilder.Entity<TodoItem>().Property(b => b.User);
        } 
    }
}