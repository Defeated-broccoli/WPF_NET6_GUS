using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_NET6_GUS.Helpers;
using WPF_NET6_GUS.Interfaces;

namespace WPF_NET6_GUS.ViewModels
{
    public class AreaListViewModel : ObservableObject
    {
        private readonly IAreaService _areaService;
        private ObservableCollection<AreaViewModel> list;
        public ObservableCollection<AreaViewModel> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
                OnPropertyChanged(nameof(List));
            }
        }
        public ICommand GetAllCommand { get; set; }

        public AreaListViewModel(IAreaService areaService)
        {
            _areaService = areaService;
            GetAllCommand = new RelayCommand(GetAll);
        }

        public void GetAll()
        {
            List = _areaService.GetAreas();
            OnPropertyChanged(nameof(List));
        }
    }
}
