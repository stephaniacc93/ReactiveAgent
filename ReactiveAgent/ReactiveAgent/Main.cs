using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveAgent
{
    public class Main
    {

        public Main(Estado estado)
        {
            //Entorno modifica estado
            FabricaDeAcciones fabricaDeAcciones = new FabricaDeAcciones(estado);                
        }
    }
}
