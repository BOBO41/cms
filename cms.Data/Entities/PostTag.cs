using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    public class PostTag : DomainEntity<int>
    {
        public int PostId { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string TagId { set; get; }

        [ForeignKey("PostId")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
