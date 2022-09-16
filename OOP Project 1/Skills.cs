using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    public class Skills : nonSubMenus
    {
        public override int printDetails()
        {
            Console.WriteLine("-------------------------SKILLS-------------------------------");
            Console.WriteLine("->Fluent in Java, SQL, C++, HTML, PHP, JavaScript, CSS, C");
            Console.WriteLine("->Confident in Presentations");
            Console.WriteLine();

            return backToMainMenu();
        }

    }
}
