using cms.Data.Entities;
using cms.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.EF.Repositories
{
    public class SizeRepository : EFRepository<Size, int>, ISizeRepository
    {
        public SizeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
