using WebApplicationMVC.Models.Data;
using WebApplicationMVC.Models.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
namespace WebApplicationMVC.Models.Repositories.Implementations
{
    public class SQLEmployeRepository : IcompanyRepository<Employe>
    {
        private readonly EmployeDbContext _employeDContext;
        public SQLEmployeRepository(EmployeDbContext employeDContext)
        {
            _employeDContext = employeDContext;
        }
        public Employe Add(Employe employe)
        {
            _employeDContext.Employes.Add(employe);
            _employeDContext.SaveChanges();
            return employe;
        }

        public Employe Delete(int id)
        {
            var employeDeleted = GetEmploye(id);
            if(employeDeleted != null)
            {
                _employeDContext.Remove(employeDeleted);
                _employeDContext.SaveChanges();
            }
            return employeDeleted;
        }

        public Employe GetEmploye(int id)
        {
            var employe = _employeDContext.Employes.SingleOrDefault(emp => emp.Id == id);
            return employe;
        }

        public IEnumerable<Employe> GetEmployes()
        {
            return _employeDContext.Employes;
        }

        public Employe update(Employe entity)
        {
            var employe = _employeDContext.Employes.Attach(entity);
            employe.State = EntityState.Modified;
            _employeDContext.SaveChanges();
            return entity;
        }
    }
}
