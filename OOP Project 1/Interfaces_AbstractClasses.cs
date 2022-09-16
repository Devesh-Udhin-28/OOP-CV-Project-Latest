using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{

    interface GoBackToMenu
    {
        //all sub menus must implement this function so that it will validate all the selections made on each of
        //the 3 sub menus available
        int select();
    }

    public abstract class subMenus : GoBackToMenu
    {
        //a property that the Main menu, the experience sub menu and the education sub menu will have
        protected int choice;



        public int getChoice()
        {
            return this.choice;
        }

        protected void setChoice(int choice)
        {
            this.choice = choice;
        }

        //a method that can be overriden that is by default implemented to re-display the Main Menu
        public virtual int backToMenu()
        {
            MainMenu menu = new MainMenu();
            return menu.select();
        }

        //a simple mandatory method that options like experience & education must have to display the
        //requested details
        public abstract int Description(int choice);

        //a function that will validate all inputs made by the user so that the application will be fail-safe
        public abstract int select();

        //a mandatory method that all child classes must implement(especially experience & education so 
        //that it will keep displaying the sub menu until "go back" is selected
        //if "go back" is selected, it will call the "backToMenu" for the Main Menu and return the selected choice
        //made by the user on the main menu
        //the "Description & select methods" are both called within this method and this methos is called within the Main program
        public abstract int Display();

    }

    public abstract class nonSubMenus
    {
        //options like "Skills", "Technological Skills" & "Contact Deatils" will use this to display back the main menu
        public static int backToMainMenu()
        {
            MainMenu menu = new MainMenu();
            return menu.select();
        }

        //options like "Skills", "Technological Skills" & "Contact Deatils" will use this to display the details
        abstract public int printDetails();

    }

}
