using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CTOBusinessLogic.ViewModels
{
    public class CostViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Сумма")]
        public decimal Sum { get; set; }

        public int WorkerId { get; set; }

        [DisplayName("Имя работки")]
        public string WorkerName { get; set; }
    }
}
