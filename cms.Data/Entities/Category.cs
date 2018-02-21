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
    [Table("Categories")]
    public class Category : DomainEntity<int>, ISwitchable, IDateTracking, 
        IHasSeoMetaData, ISortable, IHasOwner
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public Category(string name, string description, int? parentId, string friendlyURL, Status status, string metaKeyword,
            string metaDescription, int sortOrder, DateTime dateCreated, Guid ownerId, DateTime dateModified, Guid modifiedOwnerId)
        {
            Name = name;
            Description = description;
            ParentId = parentId;
            FriendlyURL = friendlyURL;
            Status = status;
            MetaKeyword = metaKeyword;
            MetaDescription = metaDescription;
            SortOrder = sortOrder;
            DateCreated = dateCreated;
            OwnerId = ownerId;
            DateModified = DateModified;
            ModifiedOwnerId = modifiedOwnerId;
        }
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public string FriendlyURL { get; set; }
        public Status Status { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime DateModified { get; set; }
        public Guid ModifiedOwnerId { get; set; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
