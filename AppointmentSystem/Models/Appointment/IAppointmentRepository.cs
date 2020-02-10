using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public interface IAppointmentRepository
    {
        Appointment getAppointmentById(int id);
        IEnumerable<Appointment> getAllAppointments();
        void ConfirmAppointment(int id);
        void AddAppointment(Appointment appointment);
    }
}
