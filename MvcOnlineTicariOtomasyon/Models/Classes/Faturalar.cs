using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Faturalar
    {
        [Key]
        public int faturaID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string faturaSiraNo { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string faturaSeriNo { get; set; }
        public DateTime tarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string vergiDairesi { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(5)]
        public string saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string teslimEden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string teslimAlan { get; set; }

        public decimal toplam { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}