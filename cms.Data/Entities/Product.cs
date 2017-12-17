using cms.Data.Interfaces;
using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData, IHasOwner, IHasIsDelete
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string Content { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category ProductCategory { set; get; }

        public int? ParentId { get; set; }
        public string FriendlyURL { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        public bool? Status { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime DateModified { get; set; }
        public Guid ModifiedOwnerId { get; set; }

        public int? ProductImageId { get; set; }
        public int? ProductPrice { get; set; }
        public int? ProductUnits { get; set; }

        public int? Quantity { get; set; }
        public bool? IsDeleted { get; set; }

        public Guid ApproveUser { get; set; }
        public string ApproveUserName { get; set; }
        public DateTime ApproveDate { get; set; }
    }
}
