using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Personel
    {
        [Key]
        public int personelID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string personelAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string personelSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string personelGorsel { get; set; }
        public int DepartmanID { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public virtual Departman Departman { get; set; }
    }
}