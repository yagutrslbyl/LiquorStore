using LiquorStore.Areas.Admin.ViewModels.Product;
using LiquorStore.DAL;
using LiquorStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LiquorStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products
                .Include(c => c.Categories)
                .Include(t => t.Tags)
                .ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }
        [HttpPost]

        [HttpPost]
        public IActionResult Create(CreateProductVM productVM)
        {
            Product product = new Product
            {
                Name = productVM.Name,
                Description = productVM.Description,
                Price = productVM.Price,
                Categories = new List<Category>(),
                Tags = new List<Tag>()
            };

            if (productVM.CategoryIds != null)
            {
                foreach (var catId in productVM.CategoryIds)
                {
                    product.Categories.Add(new Category { ID = catId });
                }
            }

            if (productVM.TagIds != null)
            {
                foreach (var tagId in productVM.TagIds)
                {
                    product.Tags.Add(new Tag { ID = tagId });
                }
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }

    }
