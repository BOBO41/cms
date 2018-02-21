using cms.Application.ViewModels.Content;
using cms.Application.ViewModels.Product;
using cms.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cms.Application.ViewModels.Utility
{
    public class MediaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string ThumbURL { get; set; }
        public string Size { get; set; }

        public int? ProductId { get; set; }
        public ProductViewModel ProductMedia { set; get; }

        public int? PostId { get; set; }
        public PostViewModel PostMedia { set; get; }

        [Required]
        public int CategoryId { get; set; }
        public CategoryViewModel CategoryMedia { set; get; }

        public Guid OwnerId { get; set; }
        public Guid ModifiedOwnerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public string Description { get; set; }

        public string Caption { get; set; }
        public Status Status { get; set; }
    }
}
