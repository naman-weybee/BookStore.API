using ConsoleToWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return "From TestRepository";
        }
    }
}
