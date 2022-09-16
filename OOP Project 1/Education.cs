using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    public class Education : subMenus
    {

        public void EducationList()
        {
            Console.WriteLine("-------------------------EDUCATION-------------------------");
            Console.WriteLine("1. Computer Science (Year 1)");
            Console.WriteLine("2. Computer Science (Year 2)");
            Console.WriteLine("0. Go Back");
            Console.WriteLine();
            Console.WriteLine("Please select an option for Educational details or 0 to go back to Main Menu");
        }

        public override int select()
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                setChoice(num);

            }
            catch (System.FormatException)
            {
                new Education().EducationList();
                select();
            }

            return getChoice();
        }


        public override int Display()
        {

            int choice = select();

            if (choice != (int)GoBack.mainMenu)
            {
                do
                {
                    choice = Description(choice);
                } while (choice != (int)MainMenuChoices.exit);

            }
            if (choice == (int)GoBack.mainMenu)
            {
                MainMenu mainMenu = new MainMenu();
                //here the new value that will be captured in choice when the user redo a selection in main menu
                return mainMenu.select();
            }
            else
            {
                return backToMenu();
            }

        }

        public override int backToMenu()//override function so that it will go back to the sub menu of Education
        {
            EducationList();
            setChoice(select());
            return getChoice();
        }

        public override int Description(int choice)
        {

            switch (choice)
            {

                case (int)ChoiceEducation.ComputerScience1:
                    {
                        Console.WriteLine("-------------------------Modules Taken-------------------------");
                        Console.WriteLine("1. Computer Programming");
                        Console.WriteLine("2. Databases");
                        Console.WriteLine("3. Computer Architecture");
                        Console.WriteLine("4. Communication Skills");
                        Console.WriteLine("5. Computational Mathematics");
                        Console.WriteLine("6. Computational and Formal Systems");
                        Console.WriteLine();
                        Console.WriteLine("-------------------------Projects Done-------------------------");
                        Console.WriteLine("1. Translation Program in C++");
                        Console.WriteLine("2. Database BackEnd for Cinema Ticketing system");
                        Console.WriteLine("3. Traffic lights system using Logisim");
                        Console.WriteLine();

                        return backToMenu();

                    };
                case (int)ChoiceEducation.ComputerScience2:
                    {
                        Console.WriteLine("-------------------------Modules Taken-------------------------");
                        Console.WriteLine("1. Operating Systems");
                        Console.WriteLine("2. User Interface and Graphic Design");
                        Console.WriteLine("3. Algorithm and Complexities");
                        Console.WriteLine("4. Object Oriented Techniques");
                        Console.WriteLine("5. Software Engineering and Program Management");
                        Console.WriteLine("6. Web and Technologies");
                        Console.WriteLine();
                        Console.WriteLine("-------------------------Projects Done-------------------------");
                        Console.WriteLine("1. Fully Functional FrontEnd & BackEnd Website using PHP, JavaScript, CSS, Laravel");
                        Console.WriteLine("2. Toddler's Application for drawing using JAVA SWING");
                        Console.WriteLine("3. Attendence Application using JAVA SWING");
                        Console.WriteLine();

                        return backToMenu();

                    };
                default://if any other choice is made, we just display the sub menu and wait for another selection
                    {
                        return backToMenu();
                    }
            }
        }

    }

}

