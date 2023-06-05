using EcomerceApp.enums;
using EcomerceApp.Models;

namespace EcomerceApp.interfaces
{
    public interface ICustomerManager
    {
        public void RegisterCustomer(string firstName,string lastName,string email,string password, Gender gender, string address);
        public Custumer GetCustomer(string email);
        public List<Custumer> GetAllCustomers();
        public void UpdateCustomer(string email);
        public void DeleteCustomer(string email);
        public Custumer Login(string email, string password);
        public void FundWallet(string email, double amount);
        

    }
}