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
            Console.WriteLine ("To Veiw Wine List type list");
            Console.WriteLine("To Search Wine Search type search");
            Console.WriteLine("To Add New Wine type add ");
            Console.Write("Choose an option: ");
            UserInputMenu = Console.ReadLine();
            Console.WriteLine("");
            

            if (UserInputMenu == "list")
            {
                Console.Write("You typed ih list");
                CSVProcessor listWine = new CSVProcessor();
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
