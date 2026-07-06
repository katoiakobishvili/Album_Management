using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class AlbumController : Controller
    {
        private ApplicationDbContext _db;

        public AlbumController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Album> albums = _db.Albums.ToList();
            return View(albums);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                _db.Albums.Add(album);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

        [HttpGet] 
        public IActionResult Details(int? id)
        {
            var album = _db.Albums.FirstOrDefault(a => a.Id == id);
            if (album == null || id == null)
            {
                return NotFound();
            }

            return View(album);
        }
        public IActionResult Edit(int id)
        {
            Album album = _db.Albums.FirstOrDefault(m => m.Id == id)!;
            return View(album);
        }

        [HttpPost]
        public IActionResult Edit(int id, Album album)
        {
            if (ModelState.IsValid)
            {
                _db.Albums.Update(album);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(album);
        }
        public IActionResult Delete(int id)
        {
            Album album = _db.Albums.FirstOrDefault(m => m.Id == id)!;
            return View(album);
        }

        [HttpPost]
        public IActionResult Delete(int id, Album album)
        {
            if (album != null)
            {
                _db.Albums.Remove(album);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

    }
}
