using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace CTOBusinessLogic.ViewModels
{
    public class WorkerViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО работника")]
        public string WorkerFIO { get; set; }
        [DisplayName("Почта")]
        public string Email { get; set; }
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Номер телефона")]
        public string NumberPhone { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
