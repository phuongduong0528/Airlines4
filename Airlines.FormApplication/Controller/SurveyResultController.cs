using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.FormApplication.Controller
{
    public class SurveyResultController
    {
        private const string BaseUrl = "http://localhost:8733/";

        public async Task<SurveyResult> AllResult()
        {
            RequestHandler<SurveyResult> request = 
                new RequestHandler<SurveyResult>(BaseUrl + "/AllResult",RestSharp.Method.GET);
            SurveyResult re = await request.GetData();
            return re;
        }

        public async Task<List<List<SurveyResult>>> SurveyResultFilter(int monthParam, int yearParam, int genderParam, int ageParam)
        {
            RequestHandler<List<List<SurveyResult>>> request =
                new RequestHandler<List<List<SurveyResult>>>(BaseUrl + "/ResultFilter", RestSharp.Method.POST);
            object obj = new
            {
                month = monthParam,
                year = yearParam,
                gender = genderParam,
                age = ageParam
            };
            List<List<SurveyResult>> re = await request.SubmitData(obj);
            return re;
        }
    }
}
