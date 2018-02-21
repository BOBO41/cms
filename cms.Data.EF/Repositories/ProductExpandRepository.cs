using cms.Data.Entities;
using cms.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.EF.Repositories
{
    public class ProductExpandRepository : EFRepository<ProductExpand, int>, IProductExpandRepository
    {
        public ProductExpandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
