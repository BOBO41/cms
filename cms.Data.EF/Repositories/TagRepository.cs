using cms.Data.Entities;
using cms.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.EF.Repositories
{
    public class TagRepository : EFRepository<Tag, string>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context)
        {
        }
    }
}
