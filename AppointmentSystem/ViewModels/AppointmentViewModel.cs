using AppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.ViewModels
{
    public class AppointmentViewModel
    {

        public string Tittle { get; set; }
        public List<Appointment> Appointments { get; set; }
       
       // public string Date = Appointmnets
    }
}
