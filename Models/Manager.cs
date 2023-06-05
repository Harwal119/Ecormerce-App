using EcomerceApp.enums;

namespace EcomerceApp.Models
{
    public class Manager:Users
    {
        public double Wallet{get;set;}
        public Manager(string firstName, string lastName, string email,string password,Gender gender,double wallet)  :base(firstName,lastName,email,password,gender)
        {
            Wallet = wallet;
        }
    }
}