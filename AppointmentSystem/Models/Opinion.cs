using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class Opinion
    {
        [BindNever]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Message cannot be empty!")]
        [StringLength(300, ErrorMessage = "Message cannot have more than 300 characters!")]
        public string Message { get; set; }
    }
}
