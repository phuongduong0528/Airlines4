using Airlines.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Manager
{
    interface IAirlineManager
    {
        List<Airline> GetAllResult();

        List<Airline> GetResultByDate(int month, int year);
        List<Airline> GetResultFilter(int month, int year, int gender, int age);
    }
}
