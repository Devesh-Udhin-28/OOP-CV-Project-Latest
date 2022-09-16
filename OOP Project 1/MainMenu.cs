using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    public class Introduction
    {
        public Introduction() {
            Console.WriteLine("-------------------------INTRODUCTION-------------------------");
            Console.WriteLine("My name is Devesh, I am a Level 2 Computer Science student, currently enrolled in the JEDI training program at Ceridian");
            Console.WriteLine();
        }
    }

    public class MainMenu : subMenus
    {
        public MainMenu()
        {
            Console.WriteLine("-------------------------MAIN MENU-------------------------");
            Console.WriteLine("1. Experience / Job History");
            Console.WriteLine("2. Training / Education");
            Console.WriteLine("3. Skills");
            Console.WriteLine("4. Technological Skills");
            Console.WriteLine("5. Contact Details");
            Console.WriteLine("0. Exit");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Select one of the above to see in more details");

        }

        public override int Description(int choice)
        {
            throw new NotImplementedException();
        }

        public override int Display()
        {
            throw new NotImplementedException();
        }

        public override int select()
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                while (!Enum.IsDefined(typeof(MainMenuChoices), num))
                {
                    num = backToMenu();
                }

                setChoice(num);

            }catch(System.FormatException)
            {
                new MainMenu();
                select();
            }

            return getChoice();
        }

    }

}
