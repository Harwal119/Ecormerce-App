using EcomerceApp.enums;
using EcomerceApp.implementatiolkns;
using EcomerceApp.implementations;
using EcomerceApp.interfaces;

namespace EcomerceApp.menu
{
    public class CustumerMenu
    {
        ICustomerManager customerManager = new CustomerManager();

        public void RealCustomerMenu()
        {
            Console.WriteLine("Enter 1 to register:" );
            Console.WriteLine("Enter 2 to login: ");

            int option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                RegisterMenu();
            }
            else if(option == 2)
            {
                LoginMenu();
            }
        }

        public void RegisterMenu()
        {
            Console.Write("enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();
            Console.Write("enter your address: ");
            string address = Console.ReadLine();
            Console.Write("enter 1 for male, 2 for female: ");
            Gender gender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine());

            customerManager.RegisterCustomer(fName,lName,email,password,gender,address);
            RealCustomerMenu();
        }

        public void LoginMenu()
        {
            Console.Write("enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();

            customerManager.Login(email,password);

        }
    }
}