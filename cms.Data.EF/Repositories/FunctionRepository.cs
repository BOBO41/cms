using cms.Data.Entities;
using cms.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
