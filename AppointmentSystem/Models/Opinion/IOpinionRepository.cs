using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public interface IOpinionRepository
    {
        void addOpinion(Opinion opinion);
        IEnumerable<Opinion> getAllOpinions();
    }
}
