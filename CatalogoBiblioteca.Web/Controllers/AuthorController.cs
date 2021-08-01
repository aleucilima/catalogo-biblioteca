using System.Linq;
using System.Threading.Tasks;
using CatalogoBiblioteca.Data;
using CatalogoBiblioteca.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoBiblioteca.Web.Controllers
{
        public class AuthorController : Controller
        {
        private readonly ApplicationDbContext _context;

        public AuthorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var authors = _context.Authors.ToList().OrderBy(a => a.Name);

            return View(authors);
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(Author model)
        {
            if(model.Id == 0)
            _context.Authors.Add(model);
            else {
                var author = _context.Authors.First(a => a.Id == model.Id);
                author.Name = model.Name;
                author.CPF = model.CPF;
                author.Phone = model.Phone;
                author.Email = model.Email;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var author = _context.Authors.First(a => a.Id == id);

            return View("Save", author);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var author = _context.Authors.First(p => p.Id == id);
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("Index");
        }
    }
}