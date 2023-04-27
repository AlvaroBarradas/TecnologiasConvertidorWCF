using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConvertidor
{
    [DataContract]
    internal class Moneda
    {
        [DataMember]
        public int dolares { get; set; }
        [DataMember]
        public int pesos { get; set; }
    }
}
