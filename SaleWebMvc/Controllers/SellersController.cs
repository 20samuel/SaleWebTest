using Microsoft.AspNetCore.Mvc;
using SaleWebMvc.Models;
using SaleWebMvc.Models.ViewModels;
using SaleWebMvc.Services;
using System.Collections.Generic;
using SaleWebMvc.Services.Exceptions;
using System.Diagnostics;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SaleWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;
        public SellersController(SellerService sellerService, DepartmentService department)
        {
            _sellerService = sellerService;
            _departmentService = department;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _sellerService.FindAllAsync();
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            var department = await _departmentService.FindAllAsync();
            var viewModel = new SellerFormViewModel { Departments = department };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var department = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = department };
                return View(viewModel);
            }
            await _sellerService.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error),new {message = "Id not provided"});
            }
            var obj = await _sellerService.FindByIdAsinc(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _sellerService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }catch(IntegrityExcemption e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
            var obj = await _sellerService.FindByIdAsinc(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" }); 
            }
            var obj = await _sellerService.FindByIdAsinc(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            List<Department> departments = await _departmentService.FindAllAsync();
            SellerFormViewModel vieModel = new SellerFormViewModel() { Seller = obj ,Departments = departments};
            return View(vieModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Seller seller)
        {

            if (!ModelState.IsValid)
            {
                var department = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = department };
                return View(viewModel);
            }
            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismacth" });
            }
            try
            {
                await _sellerService.UpdateAsync(seller);
                return RedirectToAction(nameof(Index));
            }catch(ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message});
            }
            
          
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);

        }

    }
}
