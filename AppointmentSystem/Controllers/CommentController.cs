using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppointmentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentSystem.Controllers
{
    public class CommentController : Controller
    {
        ICommentRepository _commentRepository;
        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}