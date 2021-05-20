using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTODatabaseImplement.Models
{
    public class Client
    {
        public int Id { get; set; }


        [ForeignKey("ClientId")]
        public virtual List<Society> Societies { get; set; }
    }
}
