﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace CTOBusinessLogic.ViewModels
{
    public class ClientViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }
        [DataMember]
        [DisplayName("Номер телефона")]
        public string NumberPhone { get; set; }
        [DataMember]
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DataMember]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
