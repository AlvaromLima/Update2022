using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMvc.Data;
using WebSalesMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSalesMvc.Services
{
    public class SellerService
    {
        private readonly WebSalesMvcContext _context;
        
        public SellerService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            //adiciona o objeto seller 
            _context.Add(obj);
            //grava no bd
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

    }
}
