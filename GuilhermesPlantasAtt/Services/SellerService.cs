﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuilhermesPlantasAtt.Models;

namespace GuilhermesPlantasAtt.Services
{
    public class SellerService
    {
        private readonly GuilhermesPlantasAttContext _context;

        public SellerService(GuilhermesPlantasAttContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}