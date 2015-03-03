using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveAgent
{
    public static class ReactiveAgent
    {
        public static Operation GetOperation(double time)
        {
            if (time >= 0 && time < 3)
            {
                return FabricaDeAcciones.CrearUnaAccion(State.Hard);
            }
            else if (time >= 3 && time < 7)
            {
                return FabricaDeAcciones.CrearUnaAccion(State.Med);
            }
            else //if (time >= 7 && time < 12)
            {
                return FabricaDeAcciones.CrearUnaAccion(State.Easy);
            }
        }
    }
}
