namespace ParkingLot.Core.ApiHelpers
{
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public static class Helpers
    {
        public static async Task<T> DeserializeResponseAsync<T>(string actionPath, HttpResponseMessage httpResponseMessage,
           string userId, bool json)
        {
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

            if (json)
                return JsonConvert.DeserializeObject<T>(jsonResponse);
            else
            {
                return new Serializer().Deserialize<T>(jsonResponse);
            }
        }

        public static Exception CreateExceptionFromResponseErrors(HttpResponseMessage response)
        {
            var httpErrorObject = response.Content.ReadAsStringAsync().Result;

            return new Exception(httpErrorObject);
        }

        public static async Task SetHeadersAsync(HttpRequestMessage request, RestHeaderParameter headerParam, bool json)
        {
            ObjectNullChecker.Check(request, nameof(request));
            ObjectNullChecker.Check(headerParam, nameof(headerParam));

            headerParam.Validate();

            var token = String.Empty;

            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            else
            {
                throw new MissingTokenException("Invalid token");
            }

            request.Headers.Add("Metadata-RequestId", headerParam.RequestId);
            request.Headers.Add("Metadata-SystemId", headerParam.SystemId);
            request.Headers.Add("Metadata-SenderCountry", headerParam.SenderCountry);
            request.Headers.Add("Metadata-UserId", headerParam.UserId);
            if (!json)
                request.Headers.Add("Accept", "text/xml");
        }
    }
}
