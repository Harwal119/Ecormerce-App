using EcomerceApp.enums;
using EcomerceApp.implementations;
using EcomerceApp.interfaces;

namespace EcomerceApp.menu
{
    public class ManagerMenu
    {
        IManagerManager  managerManager = new ManagerManager();

       public void RealManagerMenu()
       {
            Console.WriteLine("Enter 1 to register:" );
            Console.WriteLine("Enter 2 to login: ");

            int option = int.Parse(Console.ReadLine());

             if(option == 1)
            {
                RegistrationMenu();
            }
            else if(option == 2)
            {
                LoginMenu();
            }


       }

        private void LoginMenu()
        {
            Console.WriteLine("enter your email address: ");
            string email = Console.ReadLine();
            Console.WriteLine("enter your password: ");
            string password = Console.ReadLine();

            managerManager.Login(email, password);

        }

        

        private void RegistrationMenu()
        {
            Console.WriteLine("Enter the first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter the last name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter your email address: ");
            string email =  Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter 1 for male and 2 for female: ");
            Gender gender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine());

              managerManager.Register(fName,lName,email,password,gender);
            RealManagerMenu();
        }
    }
}