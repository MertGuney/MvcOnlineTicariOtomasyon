using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Uruns.Where(x => x.durum == true).ToList();

            return View(urunler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.kategoriAd,
                                               Value = x.kategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun u)
        {
            u.durum = true;
            c.Uruns.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var deger = c.Uruns.Find(id);
            deger.durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = c.Uruns.Find(id);
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.kategoriAd,
                                               Value = x.kategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View("UrunGetir", urun);
        }
        public ActionResult UrunGuncelle(Urun u)
        {
            var urun = c.Uruns.Find(u.urunID);
            urun.urunAd = u.urunAd;
            urun.marka = u.marka;
            urun.stok = u.stok;
            urun.alisFiyati = u.alisFiyati;
            urun.satisFiyati = u.satisFiyati;
            urun.urunGorsel = u.urunGorsel;
            urun.KategoriID = u.KategoriID;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult UrunListesi()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}