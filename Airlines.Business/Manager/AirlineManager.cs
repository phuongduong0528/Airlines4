using Airlines.Business.Models;
using Airlines.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Business.Manager
{
    public class AirlineManager : IAirlineManager
    {
        private AirlineRepository _airlineRepository;
        private Session4Entities _session4DbContext;

        public AirlineManager()
        {
            _airlineRepository = new AirlineRepository();
            _session4DbContext = new Session4Entities();
        }

        public List<Airline> GetAllResult()
        {
            return _airlineRepository.GetAllResult();
        }

        public List<Airline> GetResultByDate(int month, int year)
        {
            List<Airline> result = GetAllResult();
            return result.Where(r => r.month == month && r.year == year).ToList();
        }

        public List<Airline> GetResultFilter(int month, int year, int gender, int age)
        {
            List<Airline> result = GetResultByDate(month, year);
            if (result.Count == 0)
                return null;
            switch (gender)
            {
                case 0:
                    result = result.Where(r => r.gender == "M").ToList();
                    break;
                case 1:
                    result = result.Where(r => r.gender == "F").ToList();
                    break;
            }
            switch (age)
            {
                case 0:
                    result = result.Where(r => r.age >= 18 && r.age <= 24).ToList();
                    break;
                case 1:
                    result = result.Where(r => r.age >= 25 && r.age <= 39).ToList();
                    break;
                case 2:
                    result = result.Where(r => r.age >= 40 && r.age <= 59).ToList();
                    break;
                case 3:
                    result = result.Where(r => r.age >= 60).ToList();
                    break;
            }
            return result;
        }
    }
}
