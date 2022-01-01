using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Admin
    {
        [Key]
        public int adminID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string kullaniciAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string sifre { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string yetki { get; set; }
        
    }
}