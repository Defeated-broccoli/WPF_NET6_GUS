using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_NET6_GUS.Interfaces;
using WPF_NET6_GUS.Services;
using WPF_NET6_GUS.ViewModels;

namespace WPF_NET6_GUS.Pages
{
    /// <summary>
    /// Interaction logic for AreaListViewModel.xaml
    /// </summary>
    public partial class AreaListView : Page
    {
        public AreaListView(IAreaService areaService)
        {
            InitializeComponent();

            DataContext = new AreaListViewModel(areaService);
            
            
        }
    }
}
