using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveAgent
{
    public static class FabricaDeAcciones
    {
        private static State State { get; set; }

        public static Operation CrearUnaAccion(State s)
        {
            State = s;
            Operation operation = new Operation();

            if (State == State.Easy)
            {
                return operation.GetOperation(State.Easy);
            }
            else if (State == State.Med)
            {
                return operation.GetOperation(State.Med);
            }
            else
            {
                return operation.GetOperation(State.Hard);
            }
         
        }

    }
}
