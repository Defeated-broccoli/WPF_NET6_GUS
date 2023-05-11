using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_NET6_GUS.Helpers;
using WPF_NET6_GUS.Interfaces;
using WPF_NET6_GUS.ViewModels;

namespace WPF_NET6_GUS.Services
{
    public class AreaService :IAreaService
    {
        public ObservableCollection<AreaViewModel> GetAreas()
        {
            ObservableCollection<AreaViewModel>? list = new ObservableCollection<AreaViewModel>();
            string url = "https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area?lang=pl";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        if (json.Length > 0)
                        {
                            list = CustomConverter.ConverterStringToListOfAreaViewModel(json);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine(ex);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return list;

        }
    }
}
