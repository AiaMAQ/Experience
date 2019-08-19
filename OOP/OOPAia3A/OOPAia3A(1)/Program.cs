using System;
using System.Collections.Generic;
using System.Linq;



namespace OOPAia3A_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Mikpoli!");
            //Testing my classes

            List<Product> allProducts = new List<Product>()
            {
                new Product(1, "Cooking Chef", 123.55m),
                new Product(2, "Hand Blender", 55.65m),
                new Product(3, "Citrus Press", 12.95m),
                new Product(4, "Glass Kettle", 32.25m),
                new Product(5, "Garlic Press", 18.35m),
                new Product(6, "Pepper Mill", 22.85m),
                new Product(7, "Thermocouple Thermometer", 116.20m),
                new Product(8, "Oven Glove", 43.45m)
            };

            List<Order> orders;

            List<Customer> allCustomers = new List<Customer>()
            {
                new Customer("Donald Duck", "Duckburg", Countries.Finland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 3, true, new DateTime(2017, 4, 15), 1)
                }),
                new Customer("Bigtime Beagle", "Stockholm", Countries.Sweden,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 2, false, new DateTime(2017, 6, 22), 2)
                }),
                new Customer("Droofus Drake", "Oslo", Countries.Norway,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 4, true, new DateTime(2017, 4, 16), 3)
                }),
                new Customer("Elmer Elephant", "Duckburg", Countries.Finland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 1, false, new DateTime(2017, 7, 24), 4)
                }),
                new Customer("Mickey Mouse", "Helsinki", Countries.Finland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 1, true, new DateTime(2017, 4, 17), 5 )
                }),
                new Customer("Ludwig von Drake", "Gothenburg", Countries.Sweden,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 4, true, new DateTime(2017, 4, 18), 6)
                }),
                new Customer("Gyro Gearloose", "Bergen", Countries.Norway,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 5, false, new DateTime(2017, 6, 25), 7)
                }),
                new Customer("Scrooge McDuck", "Reykjavik", Countries.Iceland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 2, true, new DateTime(2017, 4, 19), 8)
                }),
                new Customer("Minnie Mouse", "Mikkeli", Countries.Finland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 2, true, new DateTime(2017, 6, 21), 7)
                }),
                new Customer("Big Bad Wolf", "Sandviken", Countries.Sweden,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 1, true, new DateTime(2017, 7, 1), 6)
                }),
                new Customer("Mortimer Mouse", "Lillehammer", Countries.Norway,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 3, false, new DateTime(2017, 8, 17), 5)
                }),
                new Customer("Lil Bad Wolf", "Trondheim", Countries.Norway,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 4, true, new DateTime(2017, 9, 29), 4)
                }),
                new Customer("Gosalyn Loosey", "Porvoo", Countries.Finland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 5, false, new DateTime(2017, 10, 12), 3)
                }),
                new Customer("Gus Goose", "Stavanger", Countries.Norway,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 4, true, new DateTime(2017, 5, 30), 2)
                }),
                new Customer("Honker Muddlefoot", "Ronneby", Countries.Sweden,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 3, true, new DateTime(2017, 7, 8), 1)
                }),
                new Customer("Horace Horsecollar", "Keflavik", Countries.Iceland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 2, true, new DateTime(2017, 8, 19), 2)
                }),
                new Customer("Gladstone Gander", "Dalvik", Countries.Iceland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 3, true, new DateTime(2017, 8, 21), 3)
                }),
                new Customer("Flintheart Glomgold", "Joensuu", Countries.Finland,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 1, true, new DateTime(2017, 7, 27), 4)
                }),
                new Customer("Fiddler Pig", "Sigtuna", Countries.Sweden,
                orders = new List<Order>
                {
                    new Order(Guid.NewGuid(), 2, false, new DateTime(2017, 9, 5), 5)
                })
            };
            //One simple example when you start to play with queries:
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations
            //var customerInFinland = from Customer cust in allCustomers
            //                       where cust.Country == Countries.Finland
            //                        select cust;
            //foreach (var s in customerInFinland)
            //    Console.WriteLine("Name: " + s.Name + ", City: " + s.City);

            //DateTime threshold = DateTime.Parse("20.6.2017");
            //var newstOrders = from ord in allCustomers
            //                  where ord.Orders[0].DateOfShipping > threshold
            //                  select ord;
            //foreach (var o in newstOrders)
            //    Console.WriteLine("OrderId: " + o.Orders[0].OrderId + ",ProductId: " +
            //        o.Orders[0].DateOfShipping.ToShortDateString());

            //var customersInFinland = from cust in allCustomers
            //                         where cust.Country == Countries.Finland
            //                         orderby cust.Name ascending
            //                         select cust;
            //foreach (var s in customersInFinland)
            //    Console.WriteLine("Name: " + s.Name + "City: " + s.City);

            //string selectionCriterion = "Mouse";
            //var certainCustomers = from cust in allCustomers
            //                       where cust.Name.Contains(selectionCriterion)
            //                       orderby cust.City
            //                       select cust;
            //foreach (var s in certainCustomers)
            //    Console.WriteLine("City: " + s.City + " , Name; " + s.Name);

            //var notYetShipped = from ord in allCustomers
            //                    where ord.Orders[0].Shipped == false
            //                    select ord;
            //foreach (var o in notYetShipped)
            //    Console.WriteLine("OrderId: " + o.Orders[0].OrderId +
            //        " , ProductId: " + o.Orders[0].ProductId +
            //        " , Date of Shipping: " +
            //        o.Orders[0].DateOfShipping.ToShortDateString() +
            //        " , City: " + o.City);

            var result = from cust in allCustomers
                         join prod in allProducts
                         on cust.Orders[0].ProductId equals prod.ProductId
                         where cust.Country == Countries.Finland
                         select new
                         {
                             CustomerName = cust.Name,
                             OrderQuantity = cust.Orders[0].Quantity,
                             ProductName = prod.Name
                         };
            Console.WriteLine("Finnish Clients and their Orders:");
            foreach (var s in result)
                Console.WriteLine("Customer name: " + s.CustomerName + " , Product name: " +
                    s.ProductName + , " , How many ordered: " + s.OrderQuantity);
        }
    }
}
