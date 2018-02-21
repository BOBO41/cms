using cms.Application.ViewModels.Product;
using cms.Application.ViewModels.Utility;
using cms.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cms.Application.ViewModels.Content
{
    public class PostViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string FriendlyURL { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public CategoryViewModel PostCategory { set; get; }

        public ICollection<MediaViewModel> Medias { set; get; }

        public int? ParentId { get; set; }

        [DefaultValue(0)]
        public int ViewCount { get; set; }

        [DefaultValue(0)]
        public int LikeCount { get; set; }

        [DefaultValue(false)]
        public bool IsCommentEnabled { get; set; }

        public Status Status { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid OwnerId { get; set; }
        public Guid ModifiedOwnerId { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
