using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Repositories
{
    interface IAirlineRepository
    {
        List<Airline> GetAllResult();
    }
}
