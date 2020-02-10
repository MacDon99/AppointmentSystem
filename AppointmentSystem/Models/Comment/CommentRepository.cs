using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _appDbContext;

        public CommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void addComent(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
        }

        public Comment getCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> getCommentsConnectedWithThisId(int id)
        {
            List<Comment> comments = new List<Comment>();
            foreach (var element in _appDbContext.Comments)
            {
                if (element.AppointmentId == id)
                {
                    comments.Add(element);
                }
            }
            return comments;
        }
    }
}
