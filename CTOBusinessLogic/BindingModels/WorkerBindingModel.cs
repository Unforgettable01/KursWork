using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace CTOBusinessLogic.BindingModels
{
    [DataContract]
    public class WorkerBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string WorkerFIO { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string NumberPhone { get; set; }
        [DataMember]
        public string Password { get; set; }
        
    }
}
