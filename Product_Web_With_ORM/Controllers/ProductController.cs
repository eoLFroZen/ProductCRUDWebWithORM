using Microsoft.AspNetCore.Mvc;
using Product_Web_With_ORM.Models;
using Product_Web_With_ORM.Services;
using System.Collections.Generic;

namespace Product_Web_With_ORM.Controllers
{
    public class ProductController : Controller
    {
        private ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = productService.GetAll();

            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Product product = productService.GetById(id);

            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productService.Create(product);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = productService.GetById(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            productService.Edit(product);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product product = productService.GetById(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            productService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
