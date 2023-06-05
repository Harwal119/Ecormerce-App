using System.Security.Cryptography;
using EcomerceApp.enums;
using EcomerceApp.interfaces;
using EcomerceApp.Models;

namespace EcomerceApp.implementations
{
    public class DispatchRiderManager : IDispatchRiderManager
    {
        public static List<DispatchRider> DispatchRiderDatabase = new List<DispatchRider>();
        public void DeleteDispatchRider(string email)
        {
                DispatchRider ride = CheckIfDispatchRider(email);
                if(ride != null)
            {
                DispatchRiderDatabase.Remove(ride);
            }
        }

        public List<DispatchRider> GetAllDispatchRider()
        {
             List<DispatchRider> listOfDispatchRider = new List<DispatchRider>();
            foreach (var ride in DispatchRiderDatabase)
            {
                listOfDispatchRider.Add(ride);
                Console.WriteLine($"{ride.FirstName} {ride.LastName} \t {ride.Email}");
            }
            return listOfDispatchRider;
        }

        public DispatchRider GetDispatchRaider(string email)
        {
            DispatchRider ride = CheckIfDispatchRider(email);
            if(ride != null)
            {
                return ride;
            }
            return null;

        }

        public DispatchRider Login(string email, string password)
        {
            foreach(var ride in DispatchRiderDatabase)
            {
                if(ride.Email == email && ride.Password == password)
                {
                    Console.WriteLine($"Welcome {ride.FirstName} login successful");
                    return ride;
                }
            }
            return null;
        }

        public void RegisterDispatchRider(string firstName, string lastName, string email, string password, Gender gender, string plateNumber,string phoneNumber)
        {
            DispatchRider dispatchRiderExists = CheckIfDispatchRider(email);
            if( dispatchRiderExists == null)
            {
                DispatchRider newDispatchRider = new DispatchRider(firstName,lastName,email,password,gender, plateNumber, phoneNumber);
                DispatchRiderDatabase.Add(newDispatchRider);
                Console.WriteLine($"Registration succeseful");
            }
            else
            {
                Console.WriteLine("DispatchRider already exist");
            }
        }
      

        public void UpdateDispatchRider(string email)
        {
            // DispatchRider dispatchRider = 
        }

        private DispatchRider CheckIfDispatchRider(string email)
        {
            foreach(DispatchRider ride in DispatchRiderDatabase)
            {
               if(ride.Email == email)
               {
                return ride;
               }
            }
            return null;
        }
    }
}