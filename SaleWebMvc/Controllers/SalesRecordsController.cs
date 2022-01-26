using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using SaleWebMvc.Services;
using Microsoft.EntityFrameworkCore;

namespace SaleWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? minDate,DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now.Date;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result  = await _salesRecordService.FindByDateAsync(minDate,maxDate);
            return View(result);
        }
        public async Task<IActionResult> GroupingSearch(DateTime? minDate,DateTime? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now.Date;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordService.FindByDateGroupingAnsyc(minDate, maxDate);
            return View(result);
        }
    }
}
