using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using WPF_NET6_GUS.Helpers;
using WPF_NET6_GUS.Models;

namespace WPF_NET6_GUS.ViewModels
{
    public class AreaViewModel
    {
        Area Area { get; set; } = new Area();

        public AreaViewModel()
        {

        }
        public int? Id
        {
            get
            {
                return Area.Id;
            }
            set
            {
                Area.Id = value;
            }
        }
        public string? Nazwa
        {
            get
            {
                return Area.Nazwa;
            }
            set
            {
                Area.Nazwa = value;
            }
        }

        public int? IdNadrzednyElement
        {
            get
            {
                return Area.IdNadrzednyElement;
            }
            set
            {
                Area.IdNadrzednyElement = value;
            }
        }

        public int? IdPoziom
        {
            get
            {
                return Area.IdPoziom;
            }
            set
            {
                Area.IdPoziom = value;
            }
        }

        public string? NazwaPoziom
        {
            get
            {
                return Area.NazwaPoziom;
            }
            set
            {
                Area.NazwaPoziom = value;
            }
        }

        public bool? CzyZmienne
        {
            get
            {
                return Area.CzyZmienne;
            }
            set
            {
                Area.CzyZmienne = value;
            }
        }
    }
}
