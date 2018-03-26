using System;
using System.Globalization;
using System.Linq;
using Airlines.Business.Manager;
using Airlines.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airlines.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //SurveyResultService surveyResultService = new SurveyResultService();
            //var x = surveyResultService.ResultFilter(7, 2017, -1, -1);
            //AirlineManager airlineManager = new AirlineManager();
            //var x = airlineManager.GetResultFilter(7, 2017, -1, -1);
            //bool y = x[1].arrival.Equals("CAI");
            //var z = x.Where(a => a.arrival.Equals("RUH")).Count();

            DateTime d = DateTime.ParseExact("2/10/2017 9:00 PM", "d/M/yyyy h\\:mm tt", CultureInfo.InvariantCulture);
            string s = d.ToString("dd/MM/yyyy HH\\:mm");
        }
    }
}
