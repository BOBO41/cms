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
    [Table("Posts")]
    public class Post : DomainEntity<int>, IDateTracking, IHasOwner, ISwitchable, IHasSeoMetaData, IHasIsDelete
    {
        public Post()
        {
            Medias = new List<Media>();
        }

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

        [ForeignKey("CategoryId")]
        public virtual Category PostCategory { set; get; }

        public virtual ICollection<Media> Medias { set; get; }

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
