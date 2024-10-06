using Microsoft.EntityFrameworkCore;
using HumbleCompany.web.Models;

namespace HumbleCompany.web.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> Options) : base(Options) 
        {
            
        }
        public DbSet<Empleado> Empleado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empleado>(tb =>
            {
                tb.HasKey(col => col.Id);

                tb.Property(col => col.Id)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Id).HasMaxLength(50);
                //tb.Property(col => col.Email).HasMaxLength(50);


            });
            modelBuilder.Entity<Empleado>().ToTable("Empleado");
        }
    }
}
