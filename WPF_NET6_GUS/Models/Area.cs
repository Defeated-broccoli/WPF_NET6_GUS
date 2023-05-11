using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_NET6_GUS.Models
{
    public class Area
    {
        public int? Id;
        public string? Nazwa;
        public int? IdNadrzednyElement;
        public int? IdPoziom;
        public string? NazwaPoziom;
        public bool? CzyZmienne;
    }
}
