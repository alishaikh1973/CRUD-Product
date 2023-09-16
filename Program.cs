using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            ProductCrud crud = new ProductCrud();
            do
            {
                Console.WriteLine("1.Display Product");
                Console.WriteLine("2.Display Product By ID");
                Console.WriteLine("3.Add Product");
                Console.WriteLine("4.Update Product");
                Console.WriteLine("5.Delete Product");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        List<Product> list = crud.GetProducts();
                        foreach (Product record in list)
                        {
                            Console.WriteLine($"{record.Id}\t{record.Name}\t{record.Price}\t{record.Company}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Id of Product which Details you want to Display");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p = crud.GetProductsByID(id);
                        Console.WriteLine($"{p.Id}\t{p.Name}\t{p.Company}\t{p.Price}");
                        break;
                    case 3:
                        Product p1 = new Product();
                        Console.WriteLine("Enter Product ID");
                        p1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        p1.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Company");
                        p1.Company = Console.ReadLine();
                        crud.ProductAdd(p1);
                        Console.WriteLine("ADDED");
                        break;
                    case 4:
                        Product p2 = new Product();
                        Console.WriteLine("Enter ID You want to update");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Company");
                        p2.Company = Console.ReadLine();
                        crud.ProductUpdate(p2);
                        Console.WriteLine("UPDATED");
                        break;
                    case 5:
                        Product p3 = new Product();
                        Console.WriteLine("Enter ID of product you want to Delete");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        crud.ProductDelete(id1);
                        Console.WriteLine("DELETED");
                        break;

                }

                Console.WriteLine("Press 1 To Continue");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a == 1);
        }

    }
}
        
    

