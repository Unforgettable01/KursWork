using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace CTOBusinessLogic.BindingModels
{
    public class WorkBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        [DisplayName("Название работы")]
        public string WorkName { get; set; }
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        
    }
}
