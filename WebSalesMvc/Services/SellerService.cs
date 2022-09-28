﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMvc.Data;
using WebSalesMvc.Models;

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
            //Pega o primeiro departamento da tabela department do bd.
            obj.Department = _context.Department.First();
            //adiciona o objeto seller 
            _context.Add(obj);
            //grava no bd
            _context.SaveChanges();
        }
    }
}
