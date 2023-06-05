using EcomerceApp.enums;

namespace EcomerceApp.Models
{
    public abstract class Users

    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        public Gender Gender{get;set;}
        


        public Users(string firstName,string lastName,string email,string password,Gender gender)
        {
            FirstName = firstName;
           LastName = lastName;
           Email = email;
            Password = password;
           Gender = gender;
        }

       
    }
}