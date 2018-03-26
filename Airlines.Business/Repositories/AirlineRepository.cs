using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.Business.Models;

namespace Airlines.Business.Repositories
{
    class AirlineRepository : IAirlineRepository
    {
        Session4Entities session4;

        public AirlineRepository()
        {
            session4 = new Session4Entities();
        }

        public List<Airline> GetAllResult()
        {
            return session4.Airlines.ToList();
        }
    }
}
