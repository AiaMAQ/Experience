using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAia3A_1_
{
    class Product
    {
       public Product(int productId, string name, decimal price)
       {
        ProductId = productId;
        Name = name;
        Price = price;
       }

    public int ProductId { get; set; }
       public string Name { get; set; }
       public decimal Price { get; set; }

    }
}
