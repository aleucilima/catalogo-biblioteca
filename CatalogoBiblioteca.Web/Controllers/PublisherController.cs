using System.Linq;
using System.Threading.Tasks;
using CatalogoBiblioteca.Data;
using CatalogoBiblioteca.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoBiblioteca.Web.Controllers
{
    public class PublisherController : Controller
    {
    private readonly ApplicationDbContext _context;

    public PublisherController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var publishers = _context.Publishers.ToList().OrderBy(p => p.Name);

            return View(publishers);
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(Publisher model)
        {
            if(model.Id == 0)
                _context.Publishers.Add(model);
            else {
                var publisher = _context.Publishers.First(p => p.Id == model.Id);
                publisher.CNPJ = model.CNPJ;
                publisher.Name = model.Name;
                publisher.Address = model.Address;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var publisher = _context.Publishers.First(p => p.Id == id);

            return View("Save", publisher);
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            var publisher = _context.Publishers.First(p => p.Id == id);
            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("Index");
        }
    }
}