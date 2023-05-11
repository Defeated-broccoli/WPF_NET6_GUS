using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_NET6_GUS.ViewModels;

namespace WPF_NET6_GUS.Interfaces
{
    public interface IAreaService
    {
        ObservableCollection<AreaViewModel> GetAreas();
    }
}
