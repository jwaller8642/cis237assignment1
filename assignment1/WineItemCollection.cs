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

        public void WineAdd()
        {
            string nWineId = string.Empty;
            string nWineDesritipon = string.Empty;
            string nWinePack = string.Empty;

            Console.WriteLine("Please enter an desription of new wine for the wine");
            nWineDesritipon = Console.ReadLine();
            Console.WriteLine("Please enter wine pack for the new wine");
            nWinePack = Console.ReadLine();
            Console.WriteLine("Please enter an id for the new wine");
            nWineId = Console.ReadLine();
            
            WineItem newWine = new WineItem(nWineId, nWinePack, nWineDesritipon);
            AddWine(newWine);

        }
    }
}