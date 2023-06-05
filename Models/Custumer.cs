using EcomerceApp.enums;

namespace EcomerceApp.Models
{
    public class Custumer:Users
    {
        public string Address{get;set;}
        public double Wallet{get;set;}
        public Custumer(string firstName,string lastName,string email,string password, Gender gender, string address,double wallet) :base(firstName,lastName,email,password,gender)
        {
          Address = address;
          Wallet = wallet;
        }
    }
}