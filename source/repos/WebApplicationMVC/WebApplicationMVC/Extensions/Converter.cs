using WebApplicationMVC.Models;
using WebApplicationMVC.Models.ViewModels;

namespace WebApplicationMVC.Extensions
{
    public static class Converter
    {
        public static Employe convertToEmploye(this EmployeCreateView model, string pathtoImage)
        {
            Employe employe = new Employe();
            employe.Name = model.Name;
            employe.Age = model.Age;
            employe.Departement = model.Departement;
            employe.Email = model.Email;
            employe.Image = pathtoImage;
            return employe;
        }
    }
}
