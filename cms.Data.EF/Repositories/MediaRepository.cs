using cms.Data.Entities;
using cms.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.EF.Repositories
{
    public class MediaRepository : EFRepository<Media, int>, IMediaRepository
    {
        public MediaRepository(AppDbContext context) : base(context)
        {
        }
    }
}
