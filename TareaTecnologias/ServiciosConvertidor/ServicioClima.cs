using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConvertidor
{
    public class ServicioClima : IServicioClima
    {
        Clima IServicioClima.celAFar(double cel)
        {
            Clima far = new Clima();
            far.cel = cel;
            far.far = cel * 1.8 + 32;
            return far;
        }

        Clima IServicioClima.farACel(double far)
        {
            Clima cel = new Clima();
            cel.far = far;
            cel.cel = (far - 32) * 5 / 9;
            return cel;
        }
    }
}
