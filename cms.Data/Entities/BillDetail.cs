using cms.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cms.Data.Entities
{
    [Table("BillDetails")]
    public class BillDetail : DomainEntity<int>
    {
        public BillDetail() { }

        public BillDetail(int id, int billId, int productId, string quantity, decimal price, string color, int size)
        {
            Id = id;
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Color = color;
            Size = size;
        }

        public BillDetail(int billId, int productId, string quantity, decimal price, string color, int size)
        {
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Color = color;
            Size = size;
        }
        public int BillId { set; get; }

        public int ProductId { set; get; }

        public double Size { get; set; }
        public string Color { get; set; }
        public string Quantity { get; set; }
        public decimal Price { set; get; }
        [ForeignKey("BillId")]
        public virtual Bill Bill { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}
