using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    public class TechnologicalSkills : nonSubMenus
    {
        public override int printDetails()
        {
            Console.WriteLine("-------------------------TECHNOLOGICAL SKILLS----------------------");
            Console.WriteLine("->Database Management");
            Console.WriteLine("->Computer Literacy skills (Excel, Word)");
            Console.WriteLine("->Website Development skills");
            Console.WriteLine("->Digital Marketing skills");
            Console.WriteLine();

            return backToMainMenu();

        }
    }
}
