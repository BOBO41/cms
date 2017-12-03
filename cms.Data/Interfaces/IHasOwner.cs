using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.Interfaces
{
    public interface IHasOwner
    {
        Guid OwnerId { set; get; }
        Guid ModifiedOwnerId { get; set; }
    }
}
