using System;
using System.Collections.Generic;
using static System.Console;
using CustomerInformationSystem;
using System.Linq;

namespace CustomerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set data for customers
            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerId=101, CustomerName="John Doe", CustomerEmail="johndoe@wichita.edu", CustomerPhone="316-123-1234", CustomerAddress="1702 Fairmount"},
                new Customer { CustomerId=102, CustomerName="Adam Crabtree", CustomerEmail="adamcrabtree@wichita.edu", CustomerPhone="316-123-5678", CustomerAddress="1822 Fairmount"},
                new Customer { CustomerId=103, CustomerName="Mary Jane", CustomerEmail="maryjane@wichita.edu", CustomerPhone="316-123-9090", CustomerAddress="1413 Mulberry Drive"},
                new Customer { CustomerId=104, CustomerName="Joe Dirt", CustomerEmail="joedirt@wichita.edu", CustomerPhone="316-123-8888", CustomerAddress="12 barf st"}

            };

            //Set data for products
            List<Product> products = new List<Product>
            {
                new Product { ProductId=201, ProductName="ProductX", ProductCategory="Category1", ProductDescription="Product X dummy description", ProductPrice=19.99m},
                new Product { ProductId=202, ProductName="ProductY", ProductCategory="Category2", ProductDescription="Product Y dummy description", ProductPrice=25.99m},
                new Product { ProductId=203, ProductName="ProductZ", ProductCategory="Category3", ProductDescription="Product Z dummy description", ProductPrice=28.99m},

            };

            //Set data for sales
            List<Sale> sales = new List<Sale>
            {
                new Sale { CustomerId=101, ProductId=201, PurchasePrice=19.99m},
                new Sale { CustomerId=101, ProductId=202, PurchasePrice=25.99m},
                new Sale { CustomerId=102, ProductId=201, PurchasePrice=19.99m},
                new Sale { CustomerId=102, ProductId=202, PurchasePrice=25.99m},
                new Sale { CustomerId=103, ProductId=201, PurchasePrice=19.99m}
            };

            
            Console.WriteLine("a.Search customer by ID");
            Console.WriteLine("b.Search customer by name");
            Console.WriteLine("c.Find product by ID");
            Console.WriteLine("d.Search product by name");
            Console.WriteLine("e.Calculate total sales by product");
            Console.WriteLine("f.Calculate total sales for customer by entering name");
            Console.Write("What information would you like to access? Chose an option from above:");
            string userOption = Console.ReadLine();

            if (userOption == "a")
            {
                 int customerId;
                Console.Write("Enter the Customer Name:");
                string custCheck = Console.ReadLine();
                Customer c = new Customer();
                customerId = c.GetCustomer(customers, custCheck);
                Console.WriteLine("Customer ID: {0}", customerId);
            }
            else if (userOption == "b" || userOption == "B")
            {
                int customerId;
                Console.Write("Enter the Customer Name:");
                string custCheck = Console.ReadLine();
                Customer c = new Customer();
                customerId = c.GetCustomer(customers, custCheck);
                Console.WriteLine("Customer ID: {0}", customerId);
            }

            else if (userOption == "c" || userOption == "C")
            {
                string productName;
                Console.Write("Enter the Product ID:");
                int productId = Convert.ToInt32(Console.ReadLine());
                Product c = new Product();
                productName = c.GetProduct(products, productId);
                Console.WriteLine("Product Name: {0}", productName);
            }

            else if (userOption == "d" || userOption == "D")
            {
                int productId;
                Console.Write("Enter the Product Name:");
                string productName = Console.ReadLine();
                Product c = new Product();
                productId = c.GetProduct(products, productName);
                Console.WriteLine("Product ID: {0}", productId);
            }

            else if (userOption == "e" || userOption == "E")
            {
                decimal totalSales;
                WriteLine("Enter product ID:");
                int pId = Convert.ToInt32(Console.ReadLine());
                Sale s = new Sale();
                totalSales = s.TotalSalesByProduct(sales, pId);
                Console.WriteLine("Total sales: {0}mm", totalSales);
            }
            else if (userOption == "f" || userOption =="F")
            {
                decimal totalSales;
                WriteLine("Enter the Customer ID:");
                int cId = Convert.ToInt32(Console.ReadLine());
                Sale s = new Sale();
                totalSales = s.TotalSalesByCustomer(sales, cId);
                Console.WriteLine("Total sales for customer {0} are {1}mm.", cId, totalSales);

                //Customer c = new Customer();

                //String customerName;
                //int customerId = 104;

                //customerName = c.GetCustomer(customers, customerId);
                //WriteLine("Customer Name; {0}", customerName);



            }
           
        }


    }
}
