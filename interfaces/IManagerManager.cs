using EcomerceApp.enums;
using EcomerceApp.Models;

namespace EcomerceApp.interfaces
{
    public interface IManagerManager
    {
         public void Register(string firstName,string lastName,string email,string password, Gender gender);
         public Manager Login(string email,string password);
    }
}