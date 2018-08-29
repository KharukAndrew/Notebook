using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Notebook.Domain.Models;
using Notebook.Domain.Repositories;


namespace Notebook.Web.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Note> _repository;

        public HomeController(IRepository<Note> repo)
        {
            _repository = repo;
        }

        public ActionResult Index()
        {
            IEnumerable<Note> notes = _repository.GetAll();
            return View(notes);
        }
    }
}