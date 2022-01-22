using System;
using System.Collections.Generic;
using SaleWebMvc.Data;
using System.Linq;
using SaleWebMvc.Models;
namespace SaleWebMvc.Services
{
    public class DepartmentService
    {
        private SaleWebMvcContext _context;
        public DepartmentService(SaleWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
