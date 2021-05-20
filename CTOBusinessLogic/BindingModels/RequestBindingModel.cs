using CTOBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace CTOBusinessLogic.BindingModels
{
    public class RequestBindingModel
    {
        public int? Id { get; set; }
        public int WorkId { get; set; }

        [DataMember]
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DataMember]
        [DisplayName("Статус оплаты")]
        public RequestStatus Status { get; set; }
        [DataMember]
        [DisplayName("Дата оплаты")]
        public DateTime DatePay { get; set; }

    }
}
