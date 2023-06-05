using EcomerceApp.enums;
using EcomerceApp.implementations;
using EcomerceApp.interfaces;

namespace EcomerceApp.menu
{
    public class DispatchRiderMenu
    {
        IDispatchRiderManager dispatchRiderManager = new DispatchRiderManager();

         public void RealDispatchRiderManager()
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

        private  void RegisterMenu()
        {
            Console.Write("enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();
            Console.Write("enter your plateNumber: ");
            string plateNumber = Console.ReadLine();        
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("enter 1 for male, 2 for female: ");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

           dispatchRiderManager.RegisterDispatchRider(fName,lName,email,password,gender,plateNumber, phoneNumber);

        }

        private  void LoginMenu()
        {
            Console.Write("enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();

            dispatchRiderManager.Login(email, password);

        }

      
    }
}