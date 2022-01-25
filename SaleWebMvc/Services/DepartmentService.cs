using System;
using System.Collections.Generic;
using SaleWebMvc.Data;
using System.Linq;
using SaleWebMvc.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace SaleWebMvc.Services
{
    public class DepartmentService
    {
        private SaleWebMvcContext _context;
        public DepartmentService(SaleWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
