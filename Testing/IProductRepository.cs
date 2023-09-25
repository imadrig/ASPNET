using System;
using System.Collections.Generic;
using System.Drawing;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        
    }

}
