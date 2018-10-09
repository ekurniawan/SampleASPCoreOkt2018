using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id,string alamat,string kota)
        {
            return Content($"Hello {id} Alamat {alamat} Kota {kota}");
        }

        public IActionResult HitungLuas()
        {
            //var lstNama = new List<string> { "Erick", "Budi", "Bambang", "Bejo", "Joko" };
            //ViewBag.ListNama = lstNama;
            ViewBag.Alas = 0;
            ViewBag.Tinggi = 0;
            ViewBag.Hasil = 0;
            return View();
        }

        [HttpPost]
        public IActionResult HitungLuas(double alas,double tinggi)
        {
            double hasil = 0.5 * alas * tinggi;
            ViewBag.Alas = alas;
            ViewBag.Tinggi = tinggi;
            ViewBag.Hasil = hasil;
            return View();
        }



        public IActionResult About()
        {
            return Content("Halaman About");
        }
    }
}