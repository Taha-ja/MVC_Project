namespace WebApplicationMVC.Models.Repositories.Contracts
{
    public interface IcompanyRepository<T>
    {
        public T GetEmploye(int id);
        public T Add(T entity);
        public IEnumerable<T> GetEmployes();
        public T update(T entity);
        public T Delete(int id);
    }
}
