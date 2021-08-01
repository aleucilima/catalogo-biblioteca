using System.Linq;
using System.Threading.Tasks;
using CatalogoBiblioteca.Data;
using CatalogoBiblioteca.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoBiblioteca.Web.Controllers
{
        public class BookController  : Controller
        {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var book = _context.Books.Include(b => b.Publisher).Include(b => b.Author).ToList().OrderBy(b => b.Name);

            return View(book);
        }

        [HttpGet]
        public IActionResult Save()
        {
            ViewBag.Publishers = _context.Publishers.ToList();
            ViewBag.Authors = _context.Authors.ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(Book model)
        {
            if(model.Id == 0)
                _context.Books.Add(model);
            else {
                var book = _context.Books.First(b => b.Id == model.Id);
                book.Name = model.Name;
                book.Version = model.Version;
                book.Release = model.Release;
                book.PublisherId = model.PublisherId;
                book.AuthorId = model.AuthorId;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Publishers = _context.Publishers.ToList();
            ViewBag.Authors = _context.Authors.ToList();

            var book = _context.Books.First(b => b.Id == id);

            return View("Save", book);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var book = _context.Books.First(b => b.Id == id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("Index");
        }
    }
}