using cms.Data.Interfaces;
using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("Categories")]
    public class Category : DomainEntity<int>, ISwitchable, IDateTracking, 
        IHasSeoMetaData, ISortable, IHasOwner
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public string FriendlyURL { get; set; }
        public int? Status { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public int SorOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime DateModified { get; set; }
        public Guid ModifiedOwnerId { get; set; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
