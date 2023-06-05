using EcomerceApp.Models;

namespace EcomerceApp.interfaces
{
    public interface IProductManager
    {
        public List<Product> ViewAllProduct();
        public  Product GetProduct(string name);
        public void DeleteProduct(string name);
        public void AddProduct(string name,string price,string quantity);
        public void updateProduct();


        
    }
}