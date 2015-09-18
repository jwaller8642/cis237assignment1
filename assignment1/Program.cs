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
            Console.WriteLine ("list");
            Console.WriteLine("search");
            Console.WriteLine("add ");
            Console.Write("Choose an option: ");
            UserInputMenu = Console.ReadLine();
            Console.WriteLine("");
          
            WineItemCollection wineCollection = new WineItemCollection();
            CSVProcessor listWine = new CSVProcessor();

            if (UserInputMenu == "list")
            {
                
                Console.Write("You typed in list");
                

                listWine.load(wineCollection);

                Console.WriteLine(wineCollection.getWineCollection());
            }
            else if (UserInputMenu == "search")
            {
                Console.Write("You typed in search");
            }
            else if (UserInputMenu == "add")
            {
                Console.Write("You typed in add");
            }
            Console.ReadKey();
        }
    }
}
