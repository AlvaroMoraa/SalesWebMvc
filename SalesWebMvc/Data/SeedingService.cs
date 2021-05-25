using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public void Seed()
        {
            if (_context.Department.Any() ||
              _context.Seller.Any() ||
              _context.salesRecord.Any()) ;
            {
                return;
            }
            Department d1 = new Department(1 , "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Animes");
            Department d4 = new Department(4, "Games");

            Seller s1 = new Seller(1, "Paulo Honorio", "paulinho@gmail.com", new DateTime(1998,4,12), 6000.0, d3);

        }


        
    }
}