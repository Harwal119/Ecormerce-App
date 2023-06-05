using EcomerceApp.enums;
using EcomerceApp.interfaces;
using EcomerceApp.menu;
using EcomerceApp.Models;

namespace EcomerceApp.implementations
{
    public class ManagerManager : IManagerManager
    {
        public static List<Manager> managerDatabase = new List<Manager>();
        public Manager Login(string email, string password)
        {
            
            foreach (Manager manager in managerDatabase)
            {
                if(manager.Email == email && manager.Password == password)
                {
                    Console.WriteLine($"Welcome {manager.FirstName} Login susessful");
                    return manager;
                }
            }
            
            return null;
        }

        public void Register(string firstName, string lastName, string email, string password, Gender gender)
        {
            Manager manager = CheckIfManagerExists(email);
            if ( manager == null)
            {
                double wallet = 0;
                Manager newManager = new Manager(firstName, lastName, email, password, gender, wallet);
                managerDatabase.Add(newManager);
                Console.WriteLine($"Registration Successful");
            }
            else
            {
                Console.WriteLine($"Account already exist!");
            }
        }

        private Manager CheckIfManagerExists(string email)
        {
            foreach (Manager manager in managerDatabase)
            {
                if(manager.Email == email)
                {
                    return manager;
                }
            }
            return null;
        }
    }
}