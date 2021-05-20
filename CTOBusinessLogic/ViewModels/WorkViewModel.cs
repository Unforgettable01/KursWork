using System.Collections.Generic;
using System.ComponentModel;

namespace CTOBusinessLogic.ViewModels
{
    public class WorkViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название работы")]
        public string WorkName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
