using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public interface ICommentRepository
    {
        void addComent(Comment comment);
        Comment getCommentById(int id);
        IEnumerable<Comment> getCommentsConnectedWithThisId(int id);
    }
}
