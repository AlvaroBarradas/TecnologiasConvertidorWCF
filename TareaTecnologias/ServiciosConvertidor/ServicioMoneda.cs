using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosConvertidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioMoneda : IServicioMoneda
    {
        Moneda IServicioMoneda.dolarAPeso(int dolares)
        {
            Moneda peso = new Moneda();
            peso.dolares = dolares;
            peso.pesos = dolares * 18;
            return peso;
        }

        Moneda IServicioMoneda.pesoADolar(int pesos)
        {
            Moneda dolar = new Moneda();
            dolar.pesos = pesos;
            dolar.dolares = pesos/18;
            return dolar;
        }
    }
}
