using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TelefonRehberi.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        [Required(ErrorMessage = "Çalışan adı girilmesi zorunludur!")]
        public string WorkerFirstName { get; set; }
        [Required(ErrorMessage = "Çalışan soyadı girilmesi zorunludur!")]
        public string WorkerLastName { get; set; }
        [Required(ErrorMessage = "Çalışan telefon numarası girilmesi zorunludur!")]
        public string WorkerPhoneNumber { get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        [NotMapped]
        public virtual IEnumerable<SelectListItem> departments { get; set; }
        public virtual IList<Worker> Workers { get; set; }
        [ForeignKey("WorkerId")]
        public int? WorkerManagerId { get; set; }
        public Worker WorkerManager { get; set; }
        [NotMapped]
        public virtual IEnumerable<SelectListItem> workers { get; set; }

    }
}
