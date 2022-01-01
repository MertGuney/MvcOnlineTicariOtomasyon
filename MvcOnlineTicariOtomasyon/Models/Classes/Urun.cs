using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Urun
    {
        [Key]
        public int urunID { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(30)]
        public string urunAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string marka { get; set; }
        public short stok { get; set; }
        public decimal alisFiyati { get; set; }
        public decimal satisFiyati { get; set; }
        public bool durum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string urunGorsel { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }

    }
}