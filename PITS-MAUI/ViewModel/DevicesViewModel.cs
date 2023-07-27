using PITS_MAUI.Model;
using PITS_MAUI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITS_MAUI.ViewModel
{
    public class DevicesViewModel : BaseViewModel
    {
        GetDevicesService deviceService;
        GenerateJwtToken jwtToken;
        public ObservableCollection<Devices> Devices { get; } = new();

        public DevicesViewModel(GetDevicesService devicesService, GenerateJwtToken jwtToken) 
        {
            this.deviceService = devicesService;
            this.jwtToken = jwtToken;
         
        }

        async Task<ObservableCollection<Devices>> GetDevicesAsync()
        {
           // if(IsBusy) return;

            try
            {
                IsBusy = true;
                List<Devices> devices = await deviceService.GetDataFromApi("https://pits.api.connerpanaro.com/", jwtToken.Generate());
                foreach(var device in devices)
                {
                    Devices.Add(device);
                    
                }
                

            }catch(Exception ex) 
            {
                return null; 
            }
            finally
            {
                IsBusy = false;
               
            }

            return Devices;

        }
     }
}
