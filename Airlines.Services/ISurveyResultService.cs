using Airlines.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Airlines.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISurveyResultService" in both code and config file together.
    [ServiceContract]
    public interface ISurveyResultService
    {
        [OperationContract]
        [WebGet(
            UriTemplate = "/AllResult",
            ResponseFormat = WebMessageFormat.Json)]
        SurveyResult AllResult();

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/ResultByDate",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        List<List<SurveyResult>> ResultByDate(int month, int year);

        [OperationContract]
        [WebInvoke(
            UriTemplate = "/ResultFilter",
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        List<List<SurveyResult>> ResultFilter(int month, int year, int gender, int age);
    }
}
