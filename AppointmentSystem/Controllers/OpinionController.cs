using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppointmentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentSystem.Controllers
{
    public class OpinionController : Controller
    {
        IOpinionRepository _Opinions;
        public OpinionController(IOpinionRepository Opinions)
        {
            _Opinions = Opinions;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddOpinion(Opinion opinion)
        {
            if (ModelState.IsValid)
            { 
            _Opinions.addOpinion(opinion);
                return View("OpinionSent");
            }
            return View(opinion);
        }
    }
}