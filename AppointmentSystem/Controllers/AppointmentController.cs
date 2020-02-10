using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppointmentSystem.Models;
using AppointmentSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentSystem.Controllers
{
    public class AppointmentController : Controller
    {
        IAppointmentRepository _Appointments;
        ICommentRepository _CommentRepository;

        
        public AppointmentController(IAppointmentRepository appointments, ICommentRepository commentRepository)
        {
            _Appointments = appointments;
            _CommentRepository = commentRepository;
        }

        public IActionResult Index()
        {
            var appointments = _Appointments.getAllAppointments();
            
            AppointmentViewModel appointmentVM = new AppointmentViewModel()
            {
                Tittle = "All appointments", Appointments = appointments.OrderBy(s => s.isConfirmed).ToList()
            };
            return View(appointmentVM);
        }
        public IActionResult NotConfirmed()
        {
            var appointments = _Appointments.getAllAppointments();

            AppointmentViewModel appointmentVM = new AppointmentViewModel()
            {
                Tittle = "All appointments",
                Appointments = appointments.OrderBy(s => s.isConfirmed).ToList()
            };
            return View(appointmentVM);
        }

        [HttpPost]


        public IActionResult ConfirmAppointment(DetailsViewModel viewModel)
        {

            //var id = RouteData.Values["id"];


            var appointment = _Appointments.getAppointmentById(Convert.ToInt32(viewModel.Appointment.Id));

            if (!viewModel.Appointment.isConfirmed) 
            {
                
                ModelState.AddModelError("NotChecked", "You haven't confirmed in checkbox!");
                DetailsViewModel vm = new DetailsViewModel()
                {
                    Appointment = appointment,
                    Comments = _CommentRepository.getCommentsConnectedWithThisId(appointment.Id).ToList()
                };
                return View("Details", vm);
            }
            //_Appointments[id].isConfirmed;
            // appointment.isConfirmed = viewModel.Appointment.isConfirmed;
            // _Appointments.getAppointmentById(Convert.ToInt32(id)).isConfirmed = viewModel.Appointment.isConfirmed;
            // _appDbContext.SaveChanges();
            _Appointments.ConfirmAppointment(viewModel.Appointment.Id);
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            DetailsViewModel detailsViewModel = new DetailsViewModel()
            {
                Appointment = _Appointments.getAppointmentById(id),
                Comments = _CommentRepository.getCommentsConnectedWithThisId(id).ToList()
            };
            return View(detailsViewModel);
        }

        [HttpGet]
        public IActionResult AddAppointment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAppointment(Appointment appointment)
        {

            if (ModelState.IsValid)
            {
                _Appointments.AddAppointment(appointment);
                return View("AppointmentRequestSent");
            }
            return View(appointment);
        }

    }
}