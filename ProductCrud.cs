using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProduct
{
    internal class ProductCrud
    {
        private List<Product> productlist;

        public ProductCrud()
        {
            productlist = new List<Product>()
            {
                new Product() {Id=1 ,Name="Pencil",Price=10,Company="Apsara"},
                new Product() {Id=2 ,Name="Mobile",Price=80000 ,Company="Iphone"}
            };
        }

        public List<Product> GetProducts()
        {
            return productlist;
        }
        public Product GetProductsByID(int id)
        {
            Product product = new Product();
            foreach (Product p in productlist)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }

        public void ProductAdd(Product p)
        {
            productlist.Add(p);
        }

        public void ProductUpdate(Product p)
        {
            foreach (Product pdata in productlist)
            {
                if (pdata.Id == p.Id)
                {
                    pdata.Name = p.Name;
                    pdata.Price = p.Price;
                    pdata.Company = p.Company;
                    break;
                }
            }
        }

        public void ProductDelete(int id)
        {
            foreach (Product pdata in productlist)
            {
                if (pdata.Id == id)
                {
                    productlist.Remove(pdata);
                    break;
                }
            }
        }

    }
}
    

