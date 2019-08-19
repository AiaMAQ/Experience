using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAia3A_1_
{
    class Order
    {
       public Order(Guid orderId, int quantity, bool shipped, DateTime dateOfShipping, int productId)
       {
          OrderId = orderId;
          Quantity = quantity;
          Shipped = shipped;
          DateOfShipping = dateOfShipping;
          ProductId = productId;
       }

    public Guid OrderId { get; set; }
         public int Quantity { get; set; }
         public bool Shipped { get; set; }
         public DateTime DateOfShipping { get; set; }
         public int ProductId { get; set; }

    }
}
