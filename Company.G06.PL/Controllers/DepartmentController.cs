using Company.G06.BLL.Interfaces;
using Company.G06.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Company.G06.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        // Ask CLR to create DepartmentRepository object 
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll();

            return View(departments);
        }
    }
}
