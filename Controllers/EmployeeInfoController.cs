using System.Web.Mvc;

using MVC_Repository.Models;
using MVC_Repository.Repositories;

namespace MVC_Repository.Controllers
{
    public class EmployeeInfoController : Controller
    {
        //Property of the type IRepository <TEnt, in TPk>
        private IRepository<EmployeeInfo, int> _repository;

        //The Dependency Injection of the IRepository<TEnt, in TPk>
        public EmployeeInfoController(IRepository<EmployeeInfo, int> repo)
        {
            _repository = repo;
        }

        // GET: EmployeeInfo
        public ActionResult Index()
        {
            var Emps = _repository.Get();

            return View(Emps);
        }

        public ActionResult Create()
        {
            var Emp = new EmployeeInfo();
            return View(Emp);
        }


        [HttpPost]
        public ActionResult Create(EmployeeInfo Emp)
        {
            _repository.Add(Emp);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var Emp = _repository.Get(id);
            return View(Emp);
        }

        [HttpPost]
        public ActionResult Delete(int id,EmployeeInfo emp)
        {
            var Emp = _repository.Get(id);
            _repository.Remove(Emp);
            return RedirectToAction("Index");
        }
    }
}