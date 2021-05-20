using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTODatabaseImplement.Models
{
    public class Work
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int WorkerId { get; set; }
        [ForeignKey("WorkId")]
        public virtual List<Payment> Payments { get; set; }
        [ForeignKey("WorkId")]
        public virtual List<RequestWork> RequestWork { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
