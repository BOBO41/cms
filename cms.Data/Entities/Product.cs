using cms.Data.Enum;
using cms.Data.Interfaces;
using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData, IHasOwner, IHasIsDelete
    {
        public Product()
        {
            Medias = new List<Media>();
        }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category ProductCategory { set; get; }

        public int? ParentId { get; set; }

        [Required]
        public string FriendlyURL { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        public Status Status { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime DateModified { get; set; }
        public Guid ModifiedOwnerId { get; set; }

        public virtual ICollection<Media> Medias { set; get; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        [Required]
        public decimal OriginalPrice { get; set; }

        public int? Unit { get; set; }

        public int? ProductExpandId { get; set; }
        [ForeignKey("ProductExpandId")]
        public virtual ProductExpand ProductExpand { get; set; }

        public Guid ApproveUser { get; set; }
        public string ApproveUserName { get; set; }
        public DateTime ApproveDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
