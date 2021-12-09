namespace ParkingLot.Core.APIS
{
    using Newtonsoft.Json;
    using ParkingLot.Core.ApiHelpers;
    using ParkingLot.Entity.Entitys;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public static class APIEmployee
    {
        private static readonly HttpClient httpClient;

        public static async Task<T> PostRequestAsync<T>(string actionPath, string content,
         RestHeaderParameter headerParam, CancellationTokenSource cancellationTokenSource, bool json)
        {
            HttpContent hc = new StringContent(content);
            hc.Headers.ContentType = (json) ? new MediaTypeHeaderValue("application/json") : new MediaTypeHeaderValue("application/xml");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, actionPath)
            {
                Content = hc
            };

            await Helpers.SetHeadersAsync(request, headerParam, json);

            if (cancellationTokenSource.IsCancellationRequested)
            {
                throw new TaskCanceledException("cancellationTokenSource alreday cancelled");
            }

            var httpResponseMessage = await httpClient.SendAsync(request, cancellationTokenSource.Token);

            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                // Unwrap the response and throw as an Api Exception:
                var ex = Helpers.CreateExceptionFromResponseErrors(httpResponseMessage);
                throw ex;
            }
            return await Helpers.DeserializeResponseAsync<T>(actionPath, httpResponseMessage, headerParam.UserId, json);
        }

        public static List<EmployeeBase> GetEmployees(string urlToken, string urlBase, string app)
        {
            List<EmployeeBase> response = new List<EmployeeBase>();
            List<EmployeeBase> listEmployee = new List<EmployeeBase>();
            try
            {
                Uri url = new Uri(urlBase);
                                
                using (var client = new HttpClient())
                {
                    if (client.BaseAddress == null)
                        client.BaseAddress = url;

                    var result = client.GetAsync(url).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        response = JsonConvert.DeserializeObject<List<EmployeeBase>>(result.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        string resultJson = result.Content.ReadAsStringAsync().Result;
                    }
                }
                listEmployee = response;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listEmployee;
        }

        public static List<EmployeeBase> PostEmployee(string urlToken, string urlBase, string app)
        {
            EmployeeBase request = new EmployeeBase();
            EmployeeBase response = new EmployeeBase();
            List<EmployeeBase> listEmployee = new List<EmployeeBase>();
            try
            {
                Uri url = new Uri(urlBase);

                using (var client = new HttpClient())
                {
                    if (client.BaseAddress == null)
                        client.BaseAddress = url;
                    var Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                    var result = client.PostAsync(url, Content).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        response = JsonConvert.DeserializeObject<EmployeeBase>(result.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        string resultJson = result.Content.ReadAsStringAsync().Result;
                    }
                }
                listEmployee.Add(response);
                return listEmployee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static X509Certificate2 FindCertificateByThumbprint(string findValue)
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);
                var col = store.Certificates.Find(X509FindType.FindByThumbprint, findValue, false);
                return col[0];
            }
            finally
            {
                store.Close();
            }
        }
    }
}
