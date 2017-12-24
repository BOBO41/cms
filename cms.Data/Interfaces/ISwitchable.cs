using cms.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.Interfaces
{
    public interface ISwitchable
    {
        int? Status { set; get; }
    }
}
