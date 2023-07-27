using PITS_MAUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PITS_MAUI.Services
{
    public class GetScriptsForDeviceTypeService
    {
        public async Task<List<Scripts>> GetDataFromApi(string url, string jwtToken, string machineType)
        {
            // Create an HttpClient object.
            using (var client = new HttpClient())
            {
                // Set the base address of the API.
                client.BaseAddress = new Uri(url);

                // Add the JWT token to the request headers.
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);


                // Send the request.
                try
                {
                    var response = client.GetAsync("Scripts?machineType=" + machineType).Result;

                    // Check the response status code.
                    if (response.IsSuccessStatusCode)
                    {
                        // Deserialize the response body into a generic type.
                        return await response.Content.ReadAsAsync<List<Scripts>>();
                    }
                    else
                    {
                        // Throw an exception if the response status code is not a success code.
                        throw new HttpResponseException(response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    var errr = ex.ToString();
                    return null;
                }

                return null;

            }
        }
    }
}
