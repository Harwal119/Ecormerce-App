using EcomerceApp.enums;

namespace EcomerceApp.Models
{
    public class Order
    {
        public string CustumerDetails{get;set;}
        public OrderStatus OrderStatus{get;set;}
        public double TotalPrice{get;set;}
        public string RefrenceNumber{get;set;} 
        public List<Product> OrderedProducts{get;set;}

        public Order(string custumerDetail, OrderStatus orderStatus,double totalPrice,string refrenceNumbr, List<Product> orderedProducts)
        {
            CustumerDetails = custumerDetail;
            OrderStatus = orderStatus;
            TotalPrice = totalPrice;
            RefrenceNumber = refrenceNumbr;
            OrderedProducts = orderedProducts;
        }
    }
}