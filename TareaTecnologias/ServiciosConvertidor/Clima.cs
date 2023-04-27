using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConvertidor
{
    [DataContract]
    internal class Clima
    {
        [DataMember]
        public double far { get; set; }
        [DataMember]
        public double cel { get; set; }

    }
}
