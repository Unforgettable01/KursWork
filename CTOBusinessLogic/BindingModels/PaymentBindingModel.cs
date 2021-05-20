using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CTOBusinessLogic.BindingModels
{
    [DataContract]
    public class PaymentBindingModel
    {
        public int? Id { get; set; }
        [DataMember]
        public DateTime DatePay { get; set; }
        [DataMember]
        public int sum { get; set; }
        [DataMember]
        public int WorkId { get; set; }
        [DataMember]
        public int WorkerId { get; set; }
    }
}
