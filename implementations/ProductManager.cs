using EcomerceApp.interfaces;
using EcomerceApp.Models;

namespace EcomerceApp.implementations
{
    public class ProductManager : IProductManager
    {
        public static List<Product> productDatabase = new List<Product>(); 
       
        public void AddProduct(string name, string price, string quantity)
        {
            Product product = CheckIfExist(name);
            if(product == null)
            {
                productDatabase.Add(product);
            }
        }

        public void DeleteProduct(string name)
        {
            Product product = CheckIfExist(name);
            if(product != null)
            {
                productDatabase.Remove(product);
            }
        }

        public Product GetProduct(string name)
        {
            Product product = CheckIfExist(name);
            if(product != null)
            {
                return product;
            }
            return null;
        }

        public void updateProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> ViewAllProduct()
        {
            List<Product> listOfProduct = new List<Product>();
            foreach(var Product in productDatabase)
            {
                listOfProduct.Add(Product);
                Console.WriteLine($"{Product.Name} {Product.Price} /t {Product.Quantity}");
            }
            return listOfProduct;

        }

        private Product CheckIfExist(string name)
        {
            foreach(var Product in productDatabase)
            {
                if(Product.Name == name)
                {
                    return Product;
                }
            }
            return null;
        } 
    }
}