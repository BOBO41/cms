using cms.Application.ViewModels.Utility;
using cms.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cms.Application.ViewModels.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public CategoryViewModel ProductCategory { set; get; }

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

        public ICollection<MediaViewModel> Medias { set; get; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        [Required]
        public decimal OriginalPrice { get; set; }

        public int? Unit { get; set; }

        public Guid ApproveUser { get; set; }
        public string ApproveUserName { get; set; }
        public DateTime ApproveDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
