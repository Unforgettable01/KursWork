using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTODatabaseImplement.Models
{
    public class Cost
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Sum { get; set; }
       
        [ForeignKey("CostId")]
        public virtual List<RequestCost> RequestCost { get; set; }
    }
}
