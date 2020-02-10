using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class Appointment
    {
        //[BindNever]
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required!")]
        [StringLength(100, ErrorMessage ="First name is too long.")]
        public string CustomerFirstName { get; set; }
        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(100, ErrorMessage = "Last name is too long.")]
        public string CustomerLastName { get; set; }
        [Required(ErrorMessage = "Phone number is required!")]
        [StringLength(100, ErrorMessage = "Phone number is too long.")]
        public string CustomerPhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
    ErrorMessage = "Email is not valid.")]
        public string CustomerEmail { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Date { get { return AppointmentDate.ToString("MM/dd/yyyy HH:mm"); }  }
        public bool isConfirmed { get; set; }
        public bool isDone { get; set; }
    }
}
