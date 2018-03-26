using Airlines.Business.Manager;
using Airlines.Business.Models;
using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Services.Adaptor
{
    public class SurveyResultAdaptor
    {
        private AirlineManager _airlineManager;

        public SurveyResultAdaptor()
        {
            _airlineManager = new AirlineManager();
        }

        public SurveyResult GetSurveyResult_Summary(List<Airline> a)
        {
            SurveyResult s = new SurveyResult();
            s.All = a.Count();
            s.Male = a.Where(x => x.gender.Equals("M")).Count();
            s.Female = a.Where(x => x.gender.Equals("F")).Count();
            s.A_18_24 = a.Where(x => x.age >= 18 && x.age <= 24).Count();
            s.A_25_39 = a.Where(x => x.age >= 25 && x.age <= 39).Count();
            s.A_40_59 = a.Where(x => x.age >= 40 && x.age <= 59).Count();
            s.A_60P = a.Where(x => x.age >= 60).Count();
            s.Economy = a.Where(x => x.cabintype.Equals("Economy")).Count();
            s.Business = a.Where(x => x.cabintype.Equals("Business")).Count();
            s.First = a.Where(x => x.cabintype.Equals("First")).Count();
            s.AUH = a.Where(x => x.arrival.Equals("AUH")).Count();
            s.BAH = a.Where(x => x.arrival.Equals("BAH")).Count();
            s.DOH = a.Where(x => x.arrival.Equals("DOH")).Count();
            s.RUH = a.Where(x => x.arrival.Equals("RUH")).Count();
            s.CAI = a.Where(x => x.arrival.Equals("CAI")).Count();
            return s;
        }

        public SurveyResult GetSurveyResult_Q1(List<Airline> a, int score)
        {
            SurveyResult s = new SurveyResult();
            s.All = a.Where(x => x.q1 == score).Count();
            s.Male = a.Where(x => x.gender.Equals("M") && x.q1 == score).Count();
            s.Female = a.Where(x => x.gender.Equals("F") && x.q1 == score).Count();
            s.A_18_24 = a.Where(x => x.age>=18 && x.age<= 24 && x.q1 == score).Count();
            s.A_25_39 = a.Where(x => x.age >= 25 && x.age <= 39 && x.q1 == score).Count();
            s.A_40_59 = a.Where(x => x.age >= 40 && x.age <= 59 && x.q1 == score).Count();
            s.A_60P = a.Where(x => x.age >= 60 && x.q1 == score).Count();
            s.Economy = a.Where(x => x.cabintype.Equals("Economy") && x.q1 == score).Count();
            s.Business = a.Where(x => x.cabintype.Equals("Business") && x.q1 == score).Count();
            s.First = a.Where(x => x.cabintype.Equals("First") && x.q1 == score).Count();
            s.AUH = a.Where(x => x.arrival.Equals("AUH") && x.q1 == score).Count();
            s.BAH = a.Where(x => x.arrival.Equals("BAH") && x.q1 == score).Count();
            s.DOH = a.Where(x => x.arrival.Equals("DOH") && x.q1 == score).Count();
            s.RUH = a.Where(x => x.arrival.Equals("RUH") && x.q1 == score).Count();
            s.CAI = a.Where(x => x.arrival.Equals("CAI") && x.q1 == score).Count();
            return s;
        }

        public SurveyResult GetSurveyResult_Q2(List<Airline> a, int score)
        {
            SurveyResult s = new SurveyResult();
            s.All = a.Where(x => x.q2 == score).Count();
            s.Male = a.Where(x => x.gender.Equals("M") && x.q2 == score).Count();
            s.Female = a.Where(x => x.gender.Equals("F") && x.q2 == score).Count();
            s.A_18_24 = a.Where(x => x.age >= 18 && x.age <= 24 && x.q2 == score).Count();
            s.A_25_39 = a.Where(x => x.age >= 25 && x.age <= 39 && x.q2 == score).Count();
            s.A_40_59 = a.Where(x => x.age >= 40 && x.age <= 59 && x.q2 == score).Count();
            s.A_60P = a.Where(x => x.age >= 60 && x.q2 == score).Count();
            s.Economy = a.Where(x => x.cabintype.Equals("Economy") && x.q2 == score).Count();
            s.Business = a.Where(x => x.cabintype.Equals("Business") && x.q2 == score).Count();
            s.First = a.Where(x => x.cabintype.Equals("First") && x.q2 == score).Count();
            s.AUH = a.Where(x => x.arrival.Equals("AUH") && x.q2 == score).Count();
            s.BAH = a.Where(x => x.arrival.Equals("BAH") && x.q2 == score).Count();
            s.DOH = a.Where(x => x.arrival.Equals("DOH") && x.q2 == score).Count();
            s.RUH = a.Where(x => x.arrival.Equals("RUH") && x.q2 == score).Count();
            s.CAI = a.Where(x => x.arrival.Equals("CAI") && x.q2 == score).Count();
            return s;
        }

        public SurveyResult GetSurveyResult_Q3(List<Airline> a, int score)
        {
            SurveyResult s = new SurveyResult();
            s.All = a.Where(x => x.q3 == score).Count();
            s.Male = a.Where(x => x.gender.Equals("M") && x.q3 == score).Count();
            s.Female = a.Where(x => x.gender.Equals("F") && x.q3 == score).Count();
            s.A_18_24 = a.Where(x => x.age >= 18 && x.age <= 24 && x.q3 == score).Count();
            s.A_25_39 = a.Where(x => x.age >= 25 && x.age <= 39 && x.q3 == score).Count();
            s.A_40_59 = a.Where(x => x.age >= 40 && x.age <= 59 && x.q3 == score).Count();
            s.A_60P = a.Where(x => x.age >= 60 && x.q3 == score).Count();
            s.Economy = a.Where(x => x.cabintype.Equals("Economy") && x.q3 == score).Count();
            s.Business = a.Where(x => x.cabintype.Equals("Business") && x.q3 == score).Count();
            s.First = a.Where(x => x.cabintype.Equals("First") && x.q3 == score).Count();
            s.AUH = a.Where(x => x.arrival.Equals("AUH") && x.q3 == score).Count();
            s.BAH = a.Where(x => x.arrival.Equals("BAH") && x.q3 == score).Count();
            s.DOH = a.Where(x => x.arrival.Equals("DOH") && x.q3 == score).Count();
            s.RUH = a.Where(x => x.arrival.Equals("RUH") && x.q3 == score).Count();
            s.CAI = a.Where(x => x.arrival.Equals("CAI") && x.q3 == score).Count();
            return s;
        }

        public SurveyResult GetSurveyResult_Q4(List<Airline> a, int score)
        {
            SurveyResult s = new SurveyResult();
            s.All = a.Where(x => x.q4 == score).Count();
            s.Male = a.Where(x => x.gender.Equals("M") && x.q4 == score).Count();
            s.Female = a.Where(x => x.gender.Equals("F") && x.q4 == score).Count();
            s.A_18_24 = a.Where(x => x.age >= 18 && x.age <= 24 && x.q4 == score).Count();
            s.A_25_39 = a.Where(x => x.age >= 25 && x.age <= 39 && x.q4 == score).Count();
            s.A_40_59 = a.Where(x => x.age >= 40 && x.age <= 59 && x.q4 == score).Count();
            s.A_60P = a.Where(x => x.age >= 60 && x.q3 == score).Count();
            s.Economy = a.Where(x => x.cabintype.Equals("Economy") && x.q4 == score).Count();
            s.Business = a.Where(x => x.cabintype.Equals("Business") && x.q4 == score).Count();
            s.First = a.Where(x => x.cabintype.Equals("First") && x.q4 == score).Count();
            s.AUH = a.Where(x => x.arrival.Equals("AUH") && x.q4 == score).Count();
            s.BAH = a.Where(x => x.arrival.Equals("BAH") && x.q4 == score).Count();
            s.DOH = a.Where(x => x.arrival.Equals("DOH") && x.q4 == score).Count();
            s.RUH = a.Where(x => x.arrival.Equals("RUH") && x.q4 == score).Count();
            s.CAI = a.Where(x => x.arrival.Equals("CAI") && x.q4 == score).Count();
            return s;
        }

        public List<SurveyResult> GetListSurveyResult_Q1(List<Airline> a)
        {
            List<SurveyResult> results = new List<SurveyResult>();
            for(int i = 1; i <= 7; i++)
            {
                results.Add(GetSurveyResult_Q1(a, i));
            }
            return results;
        }

        public List<SurveyResult> GetListSurveyResult_Q2(List<Airline> a)
        {
            List<SurveyResult> results = new List<SurveyResult>();
            for (int i = 1; i <= 7; i++)
            {
                results.Add(GetSurveyResult_Q2(a, i));
            }
            return results;
        }

        public List<SurveyResult> GetListSurveyResult_Q3(List<Airline> a)
        {
            List<SurveyResult> results = new List<SurveyResult>();
            for (int i = 1; i <= 7; i++)
            {
                results.Add(GetSurveyResult_Q3(a, i));
            }
            return results;
        }

        public List<SurveyResult> GetListSurveyResult_Q4(List<Airline> a)
        {
            List<SurveyResult> results = new List<SurveyResult>();
            for (int i = 1; i <= 7; i++)
            {
                results.Add(GetSurveyResult_Q4(a, i));
            }
            return results;
        }
    }
}
