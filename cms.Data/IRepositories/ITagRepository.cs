using cms.Data.Entities;
using cms.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.IRepositories
{
    public interface ITagRepository : IRepository<Tag, string>
    {
    }
}
