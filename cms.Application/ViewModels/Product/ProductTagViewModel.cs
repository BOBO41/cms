using cms.Application.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Application.ViewModels.Product
{
    public class ProductTagViewModel
    {
        public int ProductID { set; get; }

        public string TagID { set; get; }

        public ProductViewModel Product { set; get; }

        public TagViewModel Tag { set; get; }
    }
}
