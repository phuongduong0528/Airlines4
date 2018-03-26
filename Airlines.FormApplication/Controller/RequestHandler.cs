using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.FormApplication.Controller
{
    public class RequestHandler<T>
    {
        private RestClient _client;
        private RestRequest _request;

        public RequestHandler(string Url, Method method)
        {
            _client = new RestClient(new Uri(Url));
            _request = new RestRequest(method);
        }

        public async Task<T> GetData()
        {
            IRestResponse<T> response =
                await _client.ExecuteTaskAsync<T>(_request);
            return response.Data;
        }

        public async Task<T> SubmitData(object obj)
        {
            if (_request.Method == Method.GET)
                throw new Exception("Method not allowed");
            else
            {
                _request.RequestFormat = DataFormat.Json;
                _request.AddBody(obj);
                IRestResponse<T> response =
                    await _client.ExecuteTaskAsync<T>(_request);
                return response.Data;
            }
        }
    }
}
