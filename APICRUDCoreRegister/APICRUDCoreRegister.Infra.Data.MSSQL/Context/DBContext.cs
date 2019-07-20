using Microsoft.EntityFrameworkCore;
using APICRUDCoreRegister.Domain.Domain.Models;

namespace APICRUDCoreRegister.Infra.Data.MSSQL.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ParametroConfig(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void ParametroConfig(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Profile>(e =>
            {
                e
                .ToTable("profile")
                .HasKey(x => x.idProfile);

                e
                .Property(f => f.idProfile)
                .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<User>(e =>
            {
                e
                .ToTable("user")
                .HasKey(x => x.idUser);

                e
                .Property(f => f.idUser)
                .ValueGeneratedOnAdd();

                e
                .HasOne(p => p.Profile)
                .WithMany()
                .HasForeignKey(x => x.idProfile);
            });
        }
    }
}
