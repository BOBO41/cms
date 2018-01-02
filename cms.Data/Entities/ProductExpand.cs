using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("ProductExpands")]
    public class ProductExpand : DomainEntity<int>
    {
        public double Size { get; set; }
        public string Color { get; set; }
        public string Quantity { get; set; }
    }
}
