using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactWebApp.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactWebApp
{
    public class HomeController : Controller
    {
        
        private readonly IBaseRepository _baseRepository;

        public HomeController(IBaseRepository baseRepository)
        {
            
            this._baseRepository = baseRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
              _baseRepository.GetById(id);
            return View();

            
        }
    }
}
