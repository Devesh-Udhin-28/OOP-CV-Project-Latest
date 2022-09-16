using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;

            Introduction intro = new Introduction();

            MainMenu mainMenu = new MainMenu();
            choice = mainMenu.select();

            while (choice != (int)MainMenuChoices.exit)
            {
                switch (choice) {

                    case (int)MainMenuChoices.experience:
                        {
                            Experience experience = new Experience();
                            experience.ExperienceList();

                            //calling function displayExperience
                            choice = experience.Display();
                        };break;

                    case (int)MainMenuChoices.education:
                        {
                            Education education = new Education();
                            education.EducationList();

                            //calling function displayEducation
                            choice = education.Display();

                        };break;

                    case (int)MainMenuChoices.skills:
                        {
                            Skills skill = new Skills();
                            choice = skill.printDetails();
                        };break;

                    case (int)MainMenuChoices.technologicalSkills:
                        {
                            TechnologicalSkills technologicalSkill = new TechnologicalSkills();
                            choice = technologicalSkill.printDetails();
                        };break;

                    case (int)MainMenuChoices.contactDetails:
                        {
                            ContactDetail contactDetail = new ContactDetail();
                            choice = contactDetail.printDetails();
                        }break;

                }
            }//end of while loop (will exit the loop if go back is selected)

            if(choice == (int)MainMenuChoices.exit)
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }

        /*public static int Display(ref int choice, subMenus myClass)
        {
            if(choice != (int)GoBack.mainMenu)
            {
                do
                {
                    choice = myClass.Description(choice);
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
                return myClass.backToMenu();
            }

        }*/

    }

}
