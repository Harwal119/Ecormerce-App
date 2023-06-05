using EcomerceApp.enums;

namespace EcomerceApp.Models
{
    public class DispatchRider:Users
    {
        public string PlateNumber{get;set;}
        public string PhoneNumber{get;set;}

        public DispatchRider(string firstName,string lastName,string email,string password,Gender gender,string plateNumber,string phoneNumber) :base(firstName,lastName,email,password,gender) 
        {
            PlateNumber = plateNumber;
            PhoneNumber = phoneNumber;
        }
    }
}