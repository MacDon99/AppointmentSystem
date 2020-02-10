using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class Comment
    {
        [BindNever]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Comment cannot be empty!")]
        [StringLength(200, ErrorMessage = "Comment cannot have more than 200 characters!")]
        public string Message { get; set; }
        public int AppointmentId { get; set; }
    }
}
