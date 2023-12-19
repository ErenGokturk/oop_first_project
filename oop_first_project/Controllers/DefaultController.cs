using Microsoft.AspNetCore.Mvc;
using oop_first_project.Ornekler;


namespace oop_first_project.Controllers
{
    public class DefaultController : Controller
    {
        void messages()
        {
            ViewBag.m1 = "Merhaba bu  bir core projesi ";
            ViewBag.m2 = " proje ";
            ViewBag.m3 = " mesaj 3";

        }
        void MesajListesi(string p) {
            ViewBag.v = p;
        }
        public IActionResult Index()
        {

            messages();
            MesajListesi("Parametre İsmi");
            Kullanıcı("Eren123");
            return View();
        }
        void Kullanıcı(string kullanıcıadi) {
            ViewBag.v = kullanıcıadi;
        }
        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }
        int Cevre() {
            
            int kısa = 10;
            int uzun = 20;
            int cevre = 2 * (kısa * uzun);
            return cevre;
        }
       string Cumle() {
            string cumle = "Deneme 1 2 3 ";
            return cumle;   
        }
        public IActionResult Urunler()
        {
            messages();
            ViewBag.t = topla();
            ViewBag.c= Cevre();
            Kullanıcı("member000");
            
            return View();
        }

        public IActionResult Musteriler()
        {
            
            ViewBag.k=Cumle();
            Kullanıcı("admin004");
            return View();
            
        } 
        public IActionResult Deneme() {
            Bayrak bayrak = new Bayrak();   
            Sehirler sehirler = new Sehirler();
            sehirler.AD = "Kiev";
            sehirler.ID = 1;
            sehirler.Nufus = 10000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";
            ViewBag.v1=sehirler.AD;
            ViewBag.v2=sehirler.ID; 
            ViewBag.v3=sehirler.Nufus;
            ViewBag.v4=sehirler.Ulke;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.V7 = sehirler.Renk3;

            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";
            sehirler.ID = 2;
            sehirler.Ulke = "Makedonya";
            sehirler.Nufus = 500000;
            sehirler.AD = "Üsküp";
            ViewBag.z1 = sehirler.AD;
            ViewBag.z2 = sehirler.ID;
            ViewBag.z3 = sehirler.Nufus;
            ViewBag.z4 = sehirler.Ulke;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;     
            ViewBag.z7 = sehirler.Renk3;

            
            return View();
        }


       
    }

}