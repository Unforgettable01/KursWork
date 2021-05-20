using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTODatabaseImplement.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("RequestId")]
        public virtual List<RequestWork> RequestWorks { get; set; }
        [ForeignKey("RequestId")]
        public virtual List<RequestCost> RequestCosts { get; set; }

        public virtual Client Client { get; set; }
    }
}
