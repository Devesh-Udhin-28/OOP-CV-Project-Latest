using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    public class ContactDetail : nonSubMenus
    {
        public override int printDetails()
        {
            Console.WriteLine("-------------------------CONTACT DETAILS---------------------");
            Console.WriteLine("-Phone Number : +230 58343689");
            Console.WriteLine("-Company Email : devesh.udhin@ceridian.com");
            Console.WriteLine("-Personal Email : udhindevesh@gmail.com");
            Console.WriteLine();

            return backToMainMenu();

        }
    }
}
