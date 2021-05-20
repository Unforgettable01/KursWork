using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CTOBusinessLogic.ViewModels
{
    public class PaymentViewModel
    {
        public int? Id { get; set; }

        public int ClientId { get; set; }

        public int WorkId { get; set; }

        [DisplayName("Оплата")]
        public decimal Payment { get; set; }

        [DisplayName("Посетитель")]
        public string ClientName { get; set; }

        [DisplayName("Блюдо")]
        public string WorkName { get; set; }

        [DisplayName("Дата транзакции")]
        public DateTime DatePay { get; set; }
    }
}
