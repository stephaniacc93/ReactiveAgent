using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveAgent.Helpers;

namespace ReactiveAgent
{
    public class Operation
    {
        public string OperationE { get; set; }
        public string Result { get; set; }
        public State State { get; set; }

        public Operation(string operationE, string result, State state)
        {
            OperationE = operationE;
            Result = result;
            State = state;
        }

        public Operation()
        {
        }

        public Operation GetOperation(State state)
        {
            List<Operation> operations = new List<Operation>();
            operations.Add(new Operation("5+5","10",State.Easy));
            operations.Add(new Operation("6+1","7", State.Easy));
            operations.Add(new Operation("9+82","91",State.Med));
            operations.Add(new Operation("9*92","828",State.Hard));
            operations.Add(new Operation("3*2", "6", State.Easy));
            operations.Add(new Operation("7*12", "84", State.Hard));
            return operations.Where(x => x.State == state).ToList().PickRandom();                            
        }
    }
}
