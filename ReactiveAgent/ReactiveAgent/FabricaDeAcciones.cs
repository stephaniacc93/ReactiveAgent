using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveAgent
{
    public class FabricaDeAcciones
    {
        private Estado Estado { get; set; }

        public FabricaDeAcciones(Estado estado)
        {
            this.Estado = estado;
        }

        public void CrearUnaAccion()
        {
            if (Estado == Estado.Easy)
            {
                //haz algo
            }
            else if (Estado == Estado.Med)
            {
                //haz otra cosa
            }
            else if (Estado == Estado.Hard)
            {
                //haz algo mas
            }
        }

    }
}
