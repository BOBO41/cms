using cms.Data.Entities;
using cms.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.EF.Repositories
{
    public class PostRepository : EFRepository<Post, int>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {
        }
    }
}
