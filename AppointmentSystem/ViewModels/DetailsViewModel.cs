using AppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.ViewModels
{
    public class DetailsViewModel
    {
        public Appointment Appointment { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
