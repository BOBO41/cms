using cms.Data.Interfaces;
using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("DisplayContents")]
    public class DisplayContent: DomainEntity<int>, IDateTracking
    {
        public int ContentId { get; set; }
        public int PositionID { get; set; }
        public int CategoryID { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime DateModified { get; set; }
        public Guid ModifiedOwnerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DisplayOrder { get; set; }
    }
}
