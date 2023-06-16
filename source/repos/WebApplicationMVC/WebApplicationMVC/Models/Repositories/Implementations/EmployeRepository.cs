using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models.Repositories.Contracts;

namespace WebApplicationMVC.Models.Repositories.Implementations
{
    public class EmployeRepository : IcompanyRepository<Employe>
    {
        private readonly List<Employe> Employes;
        public EmployeRepository() {
            Employes = new List<Employe>();
            Employes.Add(new Employe {
                Id = 1,
                Image = "/Images/e1.jpg",
                Name = "Employe1",
                Age = 25,
                Email = "employe1@gmail.com",
                Departement = Departement.IT
            });
            Employes.Add(new Employe { 
                Id = 2,
                Image = "/Images/e2.png",
                Name = "Employe2",
                Age = 30,
                Email = "employe2@gmail.com",
                Departement = Departement.Networking
            });
            Employes.Add(new Employe { 
                Id = 3, 
                Image = "/Images/e3.png",
                Name = "Employe3",
                Age = 32,
                Email = "employe3@gmail.com",
                Departement = Departement.HR
            });

        }
        public Employe GetEmploye(int id)
        {
            return Employes.SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employe> GetEmployes()
        {
            return Employes;
        }
        public void Add(Employe employe)
        {
            int id = Employes.Max(e => e.Id) + 1;
            employe.Id = id;
            employe.Image = "/Images/no-image-placeholder.webp";
            Employes.Add(employe);
        }

        Employe IcompanyRepository<Employe>.Add(Employe entity)
        {
            throw new NotImplementedException();
        }

        public Employe update(Employe employe)
        {
            var employeUpdated = Employes.Find(e => e.Id == employe.Id);
            if (employeUpdated != null)
            {
                employeUpdated.Name = employe.Name;
                employeUpdated.Age = employe.Age;
                employeUpdated.Email = employe.Email;
                employeUpdated.Image = employe.Image;
            }
            return employeUpdated;
        }

        public Employe Delete(int id)
        {
            var employeDeleted = Employes.Find(e => e.Id == id);
            if (employeDeleted != null)
            {
                Employes.Remove(employeDeleted);
            }
            return employeDeleted;
        }
    }
}
