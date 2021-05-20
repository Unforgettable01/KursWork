using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CTOBusinessLogic.BindingModels
{
    [DataContract]
    public class ChangeStatusBindingModel
    {
        [DataMember]
        public int RequestId { get; set; }
        [DataMember]
        public int CostId { get; set; }
    }
}
