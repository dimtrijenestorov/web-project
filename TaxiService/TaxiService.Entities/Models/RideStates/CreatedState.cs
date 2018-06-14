using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models.RideStates
{
    public class CreatedState : RideState
    {
        public CreatedState(Ride ride) : base(ride)
        {
        }

        // TODO:
        public override void DeclineRequest(Ride ride)
        {
            throw new NotImplementedException();
        }

        public override void StateChangeCheck()
        {
            throw new NotImplementedException();
        }
    }
}
