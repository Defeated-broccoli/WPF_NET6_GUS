using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using WPF_NET6_GUS.ViewModels;

namespace WPF_NET6_GUS.Helpers
{
    public static class CustomConverter
    {
        public static ObservableCollection<AreaViewModel> ConverterStringToListOfAreaViewModel(string json)
        {
            var dynamicObjects = JsonConvert.DeserializeObject<List<dynamic>>(json.Replace("-", "_"));

            var list = new ObservableCollection<AreaViewModel>();

            foreach(var obj in dynamicObjects)
            {
                list.Add(new AreaViewModel()
                {
                    Id = obj.id,
                    Nazwa = obj.nazwa,
                    IdNadrzednyElement = obj.id_nadrzedny_element,
                    IdPoziom = obj.id_poziom,
                    NazwaPoziom = obj.nazwa_poziom,
                    CzyZmienne = obj.czy_zmienne,
                }); ;
            }


            return list;
        }
        
    }
}
