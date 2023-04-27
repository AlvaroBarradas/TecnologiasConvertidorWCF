using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosConvertidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    interface IServicioMoneda
    {
        [OperationContract]
        Moneda dolarAPeso(int dolares);
        [OperationContract]
        Moneda pesoADolar(int pesos);
    }

}
