using cms.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cms.Application.ViewModels.Product
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

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

        public ICollection<ProductViewModel> Products { set; get; }
    }
}
