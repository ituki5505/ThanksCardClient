#nullable disable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ThanksCardClient.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ThanksCardClient.Services
{
    class RestService : IRestService
    {
        private HttpClient Client;
        private string BaseUrl;
        public RestService()
        {
            // Setting: "Do not use proxy"
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseProxy = false;


            this.Client = new HttpClient(handler);
            this.BaseUrl = "https://localhost:1108";
        }
        
        public async Task<Employee> LogonAsync(Employee employee)
        {
            string jObject = JsonSerializer.Serialize(employee);

            var content = new StringContent(jObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            Employee responseEmployee = null;
            try
            {

                var response = await Client.PostAsync(this.BaseUrl + "/api/Logon", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    responseEmployee = JsonSerializer.Deserialize<Employee>(responseContent);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exception in RestService.LogonAsync: " + e);
            }
            return responseEmployee;
        }
    }
}
