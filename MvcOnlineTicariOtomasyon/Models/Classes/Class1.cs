using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Class1
    {
        public IEnumerable<Urun> Uruns { get; set; }
        public IEnumerable<Detay> Detays { get; set; }
        public IEnumerable<Kategori> Kategoris { get; set; }
        public IEnumerable<Cariler> Carilers { get; set; }
    }
}