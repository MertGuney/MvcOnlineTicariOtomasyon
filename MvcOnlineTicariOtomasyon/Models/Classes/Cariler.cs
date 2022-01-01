using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Cariler
    {
        [Key]
        public int cariID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30,ErrorMessage ="En Fazla 30 Karakter Yazabilirsiniz.")]
        public string cariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage ="Bu alanı boş geçemezsiniz!")]
        public string cariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string cariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string cariMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string sifre { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}