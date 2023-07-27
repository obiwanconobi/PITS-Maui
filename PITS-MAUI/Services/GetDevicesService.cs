using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using PITS_MAUI.Model;

namespace PITS_MAUI.Services
{
    public class GetDevicesService
    {

        public async Task<List<Devices>> GetDataFromApi(string url, string jwtToken)
        {
            // Create an HttpClient object.
            using (var client = new HttpClient())
            {
                // Set the base address of the API.
                client.BaseAddress = new Uri(url);

                // Add the JWT token to the request headers.
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);


                //Model.Devices device = new Model.Devices();
                //device.hostname = "Tst macine";

                //List<Model.Devices> list = new List<Model.Devices>();
                //list.Add(device);
                //return list;



                // Send the request.
                try
                {
                    var response = client.GetAsync("FullDeviceLog/GetAllDevices").Result;

                    // Check the response status code.
                    if (response.IsSuccessStatusCode)
                    {
                        // Deserialize the response body into a generic type.
                        return await response.Content.ReadAsAsync<List<Devices>>();
                    }
                    else
                    {
                        // Throw an exception if the response status code is not a success code.
                        throw new HttpResponseException(response.StatusCode);
                    }
                }catch(Exception ex)
                {
                    var errr = ex.ToString();
                    return null;
                }

                return null;
              
            }
        }

    }
}
