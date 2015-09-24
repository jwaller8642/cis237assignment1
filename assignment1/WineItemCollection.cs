using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
      WineItem[] WineArray;
        int lengthOfArray;

        public WineItemCollection()
        {
            WineArray = new WineItem[5000];
            lengthOfArray = 0;

        }
        //delete wine that was searched for
       // public void DeleteWine(WineItem WineList)
       // {
       //     WineArray[lengthOfArray] = WineList;
     //       lengthOfArray--;
     //   }
        public void AddWine(WineItem WineList)
        {
            WineArray[lengthOfArray] = WineList;
            lengthOfArray++;
        }

        public string getWineCollection()
        {
            string wineOutput = "";

            foreach (WineItem wineLoaded in WineArray)
            {
                if (wineLoaded != null)
                {
                    wineOutput += wineLoaded.ToString() + Environment.NewLine;
                }

            }
            return wineOutput;
        }

        //add new wine to list
        public void WineAdd()
        {
            string nWineId = string.Empty;
            string nWineDesritipon = string.Empty;
            string nWinePack = string.Empty;
            Console.WriteLine("Type d in all three spots to move on ");
            // while(nWineDesritipon != "done" || nWinePack != "done" || nWineId != "done" )
            //   {
            Console.WriteLine("-----");
            Console.WriteLine("Please enter an desription of new wine for the wine");
            nWineDesritipon = Console.ReadLine();
            Console.WriteLine("Please enter wine pack for the new wine");
            nWinePack = Console.ReadLine();
            Console.WriteLine("Please enter an id for the new wine");
            nWineId = Console.ReadLine();
            Console.WriteLine("-----");
            WineItem newWine = new WineItem(nWineId, nWinePack, nWineDesritipon);
            AddWine(newWine);

            Console.WriteLine(newWine);

            //   }

            //PrintNewWine();
        }
        // a print method thats was to print new wine addes
        public void PrintNewWine()
        {

            string newWineInput = string.Empty;

            Console.WriteLine("Type prt to print new wine");
            newWineInput = Console.ReadLine();
            if (newWineInput == "prt")
            {
                Console.WriteLine();
            }
        }
        // How i m trying to earch the arry but not working
        public string searchId(string WineID)
        {

            int WineArraySearch = 0;
            string SearchedWine = "";

            while (WineArraySearch < WineArray.Length) 
            {
                try
                {
                    if (WineArray[WineArraySearch].WineID == WineID)
                    {
                        SearchedWine += WineArray[WineArraySearch].WineID + ",   "
                            + WineArray[WineArraySearch].WineDescription + "   ,"
                            + WineArray[WineArraySearch].WinePack;
                        WineArraySearch = WineArray.Length;
                    }
                    else
                    {
                        WineArraySearch = WineArraySearch + 1;
                    }
                }

                catch
                {
                    Console.WriteLine("???????????????");
                    Console.ReadKey();
                }

            }

            return SearchedWine;
        }


    }
}