using cms.Data.Entities;
using cms.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
