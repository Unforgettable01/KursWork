﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTODatabaseImplement.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string ClientFIO { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string NumberPhone { get; set; }
        [Required]
        public string Password { get; set; }

        [ForeignKey("ClientId")]
        public virtual List<Payment> Payment { get; set; }
        [ForeignKey("ClientId")]
        public virtual List<Request> Request { get; set; }
    }
}
