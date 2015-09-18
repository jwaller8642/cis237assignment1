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
            WineArray = new WineItem[3967];
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
    }
}
