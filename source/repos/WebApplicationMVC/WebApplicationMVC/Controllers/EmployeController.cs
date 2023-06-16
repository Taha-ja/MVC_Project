using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Extensions;
using WebApplicationMVC.Models;
using WebApplicationMVC.Models.Repositories.Contracts;
using WebApplicationMVC.Models.ViewModels;

namespace WebApplicationMVC.Controllers
{
    //[Route("Employe")]
    public class EmployeController : Controller
    {
        private readonly IcompanyRepository<Employe> _employeRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public EmployeController(IcompanyRepository<Employe> employeRepository, IWebHostEnvironment hostingEnvironment)
        {
            _employeRepository = employeRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        //[Route("Index")]
        public IActionResult Index()
        {
            IEnumerable<Employe> employeList = _employeRepository.GetEmployes();
            return View(employeList);
        }
        public IActionResult Details(int? id)
        {
            if (id is null) return RedirectToAction("Index");
            Employe employe = _employeRepository.GetEmploye(id??1);
            return View(employe);
        }
        //[HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeRepository.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(EmployeCreateView model)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.Image != null)
                {
                    string extFile = Path.GetExtension(model.Image.FileName);
                    string uploadFolder =Path.Combine(_hostingEnvironment.WebRootPath,"Images");
                    uniqueFileName = Guid.NewGuid()+"_"+ model.Image.FileName;
                    string path = Path.Combine(uploadFolder, uniqueFileName);
                    model.Image.CopyTo(new FileStream(path, FileMode.Create));
                }
                Employe employe = model.convertToEmploye(uniqueFileName);
                _employeRepository.Add(employe);
                return RedirectToAction("Details", new { id = employe.Id });
            }
                return View();
        }
    }
}
