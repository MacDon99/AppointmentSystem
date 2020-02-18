using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly AppDbContext _appDbContext;
        public OpinionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void addOpinion(Opinion opinion)
        {
            _appDbContext.Add(opinion);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Opinion> getAllOpinions()
        {
            return _appDbContext.Opinions;
        }
    }
}
