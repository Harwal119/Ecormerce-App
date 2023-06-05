using EcomerceApp.enums;
using EcomerceApp.Models;

namespace EcomerceApp.interfaces
{
    public interface IDispatchRiderManager
    {
        public void RegisterDispatchRider(string firstName,string lastName,string email,string password, Gender gender, string plateNumber, string phoneNumber);
        public DispatchRider GetDispatchRaider(string email);
        public List<DispatchRider> GetAllDispatchRider();
        public void UpdateDispatchRider(string email);
        public void DeleteDispatchRider(string email);
        public DispatchRider Login(string email,string password);
    }
}