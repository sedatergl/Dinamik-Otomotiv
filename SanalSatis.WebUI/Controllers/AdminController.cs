using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanalSatis.BLL.Abstract;
using SanalSatis.Entities.Concrete;
using SanalSatis.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanalSatis.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IVehicleService _productService;
        private IBrandService _categoryService;
        public AdminController(IVehicleService productService, IBrandService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var productListViewModel = new VehicleAndBrandListViewModel
            {
                Vehicles = _productService.GetAllVehicle(),
            };
            return View(productListViewModel);
        }
        public ActionResult Add()
        {
            var model = new VehicleAddViewModel
            {
                Brand = new Brand(),
                Vehicles = _productService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(Brand brand)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(brand);
            }

            return RedirectToAction("Index");
        }
        public ActionResult Update(int productId)
        {
            var model = new VehicleUpdateViewModel
            {
                Brand = _categoryService.GetById(productId),
                Vehicles = _productService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Brand brand)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(brand);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int productId)
        {
            _categoryService.Delete(productId);
            return RedirectToAction("Index");
        }
    }
}
