using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Data.Interfaces
{
    public interface IHasSeoMetaData
    {

        string MetaKeywords { set; get; }
        string MetaDescription { get; set; }
    }
}
