using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {


        public CSVProcessor()
        {

        }

       Boolean list = false;
        StreamReader InputFile;
        string[] split;
        //string CSVFile;

        //loads csv file from driectory
        public void load(WineItemCollection WineList)
        {
            if (!list)
            {
                InputFile = File.OpenText("WineList.csv");
                while (!InputFile.EndOfStream)
                {
                    split = InputFile.ReadLine().Split(',');
                    //CSVFile = InputFile.ReadLine();
                    //Console.WriteLine(CSVFile);
                    WineItem Wine = new WineItem(split[0], split[1], split[2]);
                    WineList.AddWine(Wine);
                }
               InputFile.Close();
            }
            list = true;
        }
    }
}
