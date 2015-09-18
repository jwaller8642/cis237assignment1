using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        string Description;
        string WineId;
        string Pack;

        public WineItem(string WineId, string Pack, string Description)
        {
            this.WineId = WineId;
            this.Pack = Pack;
            this.Description = Description;
        }


        public string ID
        {
            get
            {
                return this.WineId;
            }

            set
            {
                this.WineId = value;
            }
        }

        public string WineDescription
        {
            get
            {
                return this.Description;
            }

            set
            {
                this.Description = value;
            }

        }

        public string WinePack
        {
            get
            {
                return this.Pack;
            }

            set
            {
                this.Pack = value;
            }
        }

        public override string ToString()
        {
            string itemOutput = "";

            itemOutput += this.WineId + ", ";
            itemOutput += this.Description + ", ";
            itemOutput += this.Pack;

            return itemOutput;
        }

    }
}

