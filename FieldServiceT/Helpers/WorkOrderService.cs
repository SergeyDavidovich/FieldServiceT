using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FieldServiceT.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

// https://prod-101.westus.logic.azure.com/workflows/a9440d5ccef24b4196e80403fef741f6/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=alJ8h9rhlsnO-saeKFowHYScyGehRHLb6i9oTuyPxGc

namespace FieldServiceT.Helpers
{
    public class WorkOrderService
    {
        WOQuestionnaire _questionnarie;
        private readonly string postUri = 
            "https://prod-101.westus.logic.azure.com:443/workflows/a9440d5ccef24b4196e80403fef741f6/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=alJ8h9rhlsnO-saeKFowHYScyGehRHLb6i9oTuyPxGc";

        public WorkOrderService(WOQuestionnaire questionnarie)
        {
            _questionnarie = questionnarie;
        }
        public string AccessToken { get; set; }

        public async Task<HttpStatusCode> SendWORequestPostAsync()
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token.AccessToken);

                // сериализация объекта с помощью Json.NET
                string json = JsonConvert.SerializeObject(_questionnarie);
                HttpContent content = new StringContent(json);

                HttpRequestMessage request = new HttpRequestMessage();
                request.RequestUri = new Uri(postUri); 
                request.Method = HttpMethod.Post;
                request.Content = content;
                response = await client.SendAsync(request);
            }
            return response.StatusCode;
        }
    }
}
