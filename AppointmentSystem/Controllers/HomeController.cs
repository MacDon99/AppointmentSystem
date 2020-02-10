using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppointmentSystem.Models;
using AppointmentSystem.ViewModels;

namespace AppointmentSystem.Controllers
{
    public class HomeController : Controller
    {
        IOpinionRepository _OpinionRepository;
        public HomeController(IOpinionRepository opinionRepository)
        {
            _OpinionRepository = opinionRepository;
        }

        public IActionResult Index()
        {
            OpinionViewModel opinions = new OpinionViewModel()
            {
                Opinions = _OpinionRepository.getAllOpinions().ToList()
            };
            return View(opinions);
        }
    }
}
