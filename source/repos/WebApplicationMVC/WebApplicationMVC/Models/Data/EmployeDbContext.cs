using Microsoft.EntityFrameworkCore;

namespace WebApplicationMVC.Models.Data
{
    public class EmployeDbContext:DbContext
    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext> options):base(options)
        {
            
        }
        public DbSet<Employe> Employes { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employe>().HasData(new Employe() {
                Id = 2,
                Image = "/Images/e1.jpg",
                Name = "Employe1",
                Age = 25,
                Email = "employe1@gmail.com",
                Departement = Departement.IT
            },
            new Employe
            {
                Id = 3,
                Image = "/Images/e2.png",
                Name = "Employe2",
                Age = 30,
                Email = "employe2@gmail.com",
                Departement = Departement.Networking
            },
            new Employe
            {
                Id = 4,
                Image = "/Images/e3.png",
                Name = "Employe3",
                Age = 32,
                Email = "employe3@gmail.com",
                Departement = Departement.HR
            }
            );
        }
    }
}
