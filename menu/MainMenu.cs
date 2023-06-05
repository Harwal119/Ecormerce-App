using EcomerceApp.implementations;

namespace EcomerceApp.menu
{
    public class MainMenu
    {
        CustumerMenu cm = new CustumerMenu();
        ManagerMenu managerMenu = new ManagerMenu();
        DispatchRiderMenu riderMenu = new DispatchRiderMenu();
        public void RealMenu()
        {
            Console.WriteLine("welcome to clh jumia app: ");
            Console.WriteLine("enter 1 as customer: ");
            Console.WriteLine("enter 2 as manager: ");
            Console.WriteLine("enter 3 as rider: ");
            // Console.WriteLine("enter 3 as rider: ");
            int option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                cm.RealCustomerMenu();
            }
            else if(option == 2)
            {
                managerMenu.RealManagerMenu();
            }
            else if(option == 3)
            {
                riderMenu.RealDispatchRiderManager();
            }
            else
            {
               Console.WriteLine("wrong input!"); 
            }
        }
    }
}