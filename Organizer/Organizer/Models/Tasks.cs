using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Organizer.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Subject { get; set; }
        [Required]
        [StringLength(255)]
        public string Task { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }

        public virtual Users User { get; set; }
    }
}