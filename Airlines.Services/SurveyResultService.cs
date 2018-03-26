using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Airlines.Business.Manager;
using Airlines.Services.Adaptor;
using Airlines.Services.Dto;

namespace Airlines.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SurveyResultService" in both code and config file together.
    public class SurveyResultService : ISurveyResultService
    {
        private SurveyResultAdaptor _surveyResultAdaptor = new SurveyResultAdaptor();
        private AirlineManager _airlineManager;

        public AirlineManager AirlineManager => _airlineManager ??
            (_airlineManager = new AirlineManager());
        

        public SurveyResult AllResult()
        {
            return _surveyResultAdaptor.GetSurveyResult_Summary(
                AirlineManager.GetAllResult()
                );
        }

        public List<List<SurveyResult>> ResultByDate(int month, int year)
        {
            List<List<SurveyResult>> results = new List<List<SurveyResult>>();
            results.Add(_surveyResultAdaptor.Q1(AirlineManager.GetResultByDate(month, year)));
            results.Add(_surveyResultAdaptor.Q2(AirlineManager.GetResultByDate(month, year)));
            results.Add(_surveyResultAdaptor.Q3(AirlineManager.GetResultByDate(month, year)));
            results.Add(_surveyResultAdaptor.Q4(AirlineManager.GetResultByDate(month, year)));
            return results;
        }

        public List<List<SurveyResult>> ResultFilter(int month, int year, int gender, int age)
        {
            List<List<SurveyResult>> results = new List<List<SurveyResult>>();
            results.Add(_surveyResultAdaptor.Q1(AirlineManager.GetResultFilter(month, year, gender, age)));
            results.Add(_surveyResultAdaptor.Q2(AirlineManager.GetResultFilter(month, year, gender, age)));
            results.Add(_surveyResultAdaptor.Q3(AirlineManager.GetResultFilter(month, year, gender, age)));
            results.Add(_surveyResultAdaptor.Q4(AirlineManager.GetResultFilter(month, year, gender, age)));
            return results;
        }
    }
}
