using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {

       
        static string UserInputMenu = string.Empty;

        static void Main(string[] args)
        {
            Console.WriteLine("Must load csv file first to print");
            Console.WriteLine("type load to Load the list");
            Console.WriteLine("Type list to print list");
            Console.WriteLine("type seach to search list");
            Console.WriteLine("type add to add wine ");
            Console.WriteLine("Exit");

            Console.Write("Choose an option: ");
            UserInputMenu = Console.ReadLine(); //user input
            
            //objects from diffent classes
            WineItemCollection wineCollection = new WineItemCollection();
            CSVProcessor listWine = new CSVProcessor();
            WineItemCollection wineAdd = new WineItemCollection();
            WineItemCollection searchWine = new WineItemCollection();

            //whlie loops that keep going until users hit exit
     while (UserInputMenu != "exit")
         {
         //loads csv file
           if (UserInputMenu == "load")

          {
              //loadWine();
              listWine.load(wineCollection);
              loadMenu();
          }
               //print csv file
          else if (UserInputMenu == "list")
            {
              //  printWine();
               
                Console.Write("You typed in list");
              
                   Console.WriteLine(wineCollection.getWineCollection());
                   loadMenu();
               
            }
               //seach csv file
            else if (UserInputMenu == "search")
            {
                
                string wineIdInput = string.Empty;
                
                Console.Write("You typed in search");
                Console.WriteLine("Enter wine id");
                wineIdInput = Console.ReadLine();
                Console.WriteLine( searchWine.searchId(wineIdInput));
                loadMenu();
            }
               //add to the csv file
            else if (UserInputMenu == "add")
            {
                Console.WriteLine("You typed in add");
                wineAdd.WineAdd();
                loadMenu();
            }
            
            else if (UserInputMenu == "exit")
            {
                End();
            }
            else //if(UserInputMenu != "eixt" || UserInputMenu != "list" || UserInputMenu != "load" || UserInputMenu != "search")
            {
                Console.WriteLine(UserInputMenu +" is not an option");
                Console.WriteLine("please enter one the following");
                loadMenu();
            }    
         }
       }
                // method that reloads menu
            private static void loadMenu()
            {
                Console.WriteLine("-----");
                Console.WriteLine("type load to Load the list");
                Console.WriteLine("Type list to print list");
                Console.WriteLine("type seach to search list");
                Console.WriteLine("type add to add wine ");
                Console.WriteLine("Exit");
                Console.WriteLine("");
                Console.Write("Choose an option: ");
                UserInputMenu = Console.ReadLine();
             }


        //exits the program
            private static void End()
            {
                //Closes the program
            }


        //Code that is not used
            //private static void loadWine()
            // {
            //   WineItemCollection wineCollection = new WineItemCollection();
            //     CSVProcessor listWine = new CSVProcessor();
            //      listWine.load(wineCollection);
            //  }


            //  public static void printWine()
            //  {
            //       WineItemCollection wineCollection = new WineItemCollection();
            //     Console.WriteLine(wineCollection.getWineCollection());
            //  }

            
    }
    }

