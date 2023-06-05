using EcomerceApp.enums;
using EcomerceApp.interfaces;
using EcomerceApp.Models;

namespace EcomerceApp.implementatiolkns
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Custumer> customerDatabase = new List<Custumer>();
        public void DeleteCustomer(string email)
        {

            Custumer cust = CheckIfExists(email);
            if(cust != null)
            {
                customerDatabase.Remove(cust);
            }
        }

        public void FundWallet(string email, double amount)
        {
            Custumer cust = CheckIfExists(email);
            if(cust != null)
            {
                cust.Wallet += amount;
                Console.WriteLine($"{amount} succesfully added to your wallet and new balance is {cust.Wallet}");
            }
        }

        public List<Custumer> GetAllCustomers()
        {
            List<Custumer> listOfCustomer = new List<Custumer>();
            foreach (var customer in customerDatabase)
            {
                listOfCustomer.Add(customer);
                Console.WriteLine($"{customer.FirstName} {customer.LastName} \t {customer.Email}");
            }

            return listOfCustomer;
        }

        public Custumer GetCustomer(string email)
        {
            Custumer cust = CheckIfExists(email);
            if(cust != null)
            {
                return cust;
            }
            return null;

        }

        public Custumer Login(string email, string password)
        {
            foreach (Custumer cust in customerDatabase)
            {
                if(cust.Email == email && cust.Password == password)
                {
                    Console.WriteLine($"Welcome {cust.FirstName}, login successful");
                    return cust;
                }
            }
            return null;
        }

        public void RegisterCustomer(string firstName, string lastName, string email, string password, Gender gender, string address)
        {
            Custumer customerExists = CheckIfExists(email);
            if(customerExists == null)
            {
                double wallet = 0;
                Custumer customer = new Custumer(firstName,lastName,email,password,gender,address, wallet);
                customerDatabase.Add(customer);
                Console.WriteLine($" mr/mrs {customer.FirstName} {customer.LastName} Registration successful");
            }
            else
            {
                Console.WriteLine("Customer already exists");
            }
            
        }

        public void UpdateCustomer(string email)
        {
            
        }

        private Custumer CheckIfExists(string email)
        {
            foreach (Custumer cust in customerDatabase)
            {
                if(cust.Email == email)
                {
                    return cust;
                }
            }
            return null;
        }
    }
}