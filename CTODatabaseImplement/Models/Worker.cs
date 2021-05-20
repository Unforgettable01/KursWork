﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTODatabaseImplement.Models
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public string WorkerFIO { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string NumberPhone { get; set; }
        [Required]
        public string Password { get; set; }
        [ForeignKey("WorkerId")]
        public virtual List<Work> Work { get; set; }
    }
}
