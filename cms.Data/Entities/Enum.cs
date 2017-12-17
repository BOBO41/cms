using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("Enums")]
    public class Enum : DomainEntity<int>
    {
        public int? EnumNumber { get; set; }
        public string Name { get; set; }
    }
}
