using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.SatisHarekets.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            Dropdown();
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(SatisHareket s)
        {
            s.tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SatisHarekets.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SatisGetir(int id)
        {
            Dropdown();
            var deger = c.SatisHarekets.Find(id);
            return View("SatisGetir", deger);
        }
        public ActionResult Guncelle(SatisHareket p)
        {
            var degerler = c.SatisHarekets.Find(p.satisID);
            degerler.CariID = p.CariID;
            degerler.adet = p.adet;
            degerler.fiyat = p.fiyat;
            degerler.toplamTutar = p.toplamTutar;
            degerler.PersonelID = p.PersonelID;
            degerler.tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            degerler.UrunID = p.UrunID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SatisDetay(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.satisID == id).ToList();
            return View(degerler);
        }
        public void Dropdown()
        {
            List<SelectListItem> deger1 = (from x in c.Uruns.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.urunAd,
                                               Value = x.urunID.ToString()

                                           }).ToList();
            ViewBag.urun = deger1;
            List<SelectListItem> deger2 = (from x in c.Carilers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.cariAd + " " + x.cariSoyad,
                                               Value = x.cariID.ToString()
                                           }).ToList();
            ViewBag.cari = deger2;
            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.personelAd + " " + x.personelSoyad,
                                               Value = x.personelID.ToString()
                                           }).ToList();
            ViewBag.pers = deger3;
        }
    }
}