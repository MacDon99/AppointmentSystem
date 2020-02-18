using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public AppointmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddAppointment(Appointment appointment)
        {
            _appDbContext.Appointments.Add(appointment);
            _appDbContext.SaveChanges();
        }

        public void ConfirmAppointment(int id)
        {
            getAppointmentById(Convert.ToInt32(id)).isConfirmed = true;
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Appointment> getAllAppointments()
        {
            return _appDbContext.Appointments;
        }

        public Appointment getAppointmentById(int id)
        {
            return _appDbContext.Appointments.FirstOrDefault(s => s.Id == id);
        }
    }
}
