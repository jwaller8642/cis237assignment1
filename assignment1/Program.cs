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
            Console.WriteLine("type load to Load the list");
            Console.WriteLine("Type list to print list");
            Console.WriteLine("type seach to search list");
            Console.WriteLine("type add to add wine ");
            Console.WriteLine("Exit");

            Console.Write("Choose an option: ");
            UserInputMenu = Console.ReadLine();
            Console.WriteLine("");
            WineItemCollection wineCollection = new WineItemCollection();
            CSVProcessor listWine = new CSVProcessor();

            while (UserInputMenu != "exit")
            {
 if (UserInputMenu == "load")

          {
              //loadWine();
              listWine.load(wineCollection);
              loadMenu();
          }
          else if (UserInputMenu == "list")
            {
              //  printWine();
               
                Console.Write("You typed in list");
              
                   Console.WriteLine(wineCollection.getWineCollection());
                   loadMenu();
               
            }
            else if (UserInputMenu == "search")
            {
                Console.Write("You typed in search");
            }
            else if (UserInputMenu == "add")
            {
                Console.WriteLine("You typed in add");
                loadMenu();
            }
            
            else if (UserInputMenu == "exit")
            {
                End();
            }
            }
        }

private static void End()
{
    //Closes the program
}

        
            private static void loadMenu()
            {
                Console.WriteLine("type load to Load the list");
                Console.WriteLine("Type list to print list");
                Console.WriteLine("type seach to search list");
                Console.WriteLine("type add to add wine ");
                Console.WriteLine("Exit");
                Console.WriteLine("");
                Console.Write("Choose an option: ");
                UserInputMenu = Console.ReadLine();
             }


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

