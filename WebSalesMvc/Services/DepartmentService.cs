using System.Collections.Generic;
using System.Linq;
using WebSalesMvc.Data;
using WebSalesMvc.Models;

namespace WebSalesMvc.Services
{
    public class DepartmentService
    {
        private readonly WebSalesMvcContext _context;

        public DepartmentService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            // retorna a lista de departments ordenados por nome
            return _context.Department.OrderBy(x => x.Name).ToList();

        }
    }
}
