using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities.Models.RideStates
{
    public abstract class RideState
    {
        private Ride _ride;

        public RideState(Ride ride)
        {
            _ride = ride;
        }

        public abstract void StateChangeCheck();

        public abstract void DeclineRequest(Ride ride);
    }
}
