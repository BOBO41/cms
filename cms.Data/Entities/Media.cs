using cms.Data.Enum;
using cms.Data.Interfaces;
using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("Medias")]
    public class Media : DomainEntity<int>, IDateTracking, IHasOwner, ISwitchable
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string ThumbURL { get; set; }
        public string Size { get; set; }

        public int? ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product ProductMedia { set; get; }

        public int? PostId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post PostMedia { set; get; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category CategoryMedia { set; get; }

        public Guid OwnerId { get; set; }
        public Guid ModifiedOwnerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public string Description { get; set; }

        public string Caption { get; set; }
        public Status Status { get; set; }

    }
}
