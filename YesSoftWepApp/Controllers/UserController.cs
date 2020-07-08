using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Entity;
using infra.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace YesSoftWepApp.Controllers
{
    public class UserController : Controller
    {
        private UnitOfWork UnitOfWork;

        public UserController()
        {
            UnitOfWork = new UnitOfWork();
        }
        public IActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            UnitOfWork.UserRepository.Add(user);
            UnitOfWork.SaveChanges();
            return View();
        }
    }
}