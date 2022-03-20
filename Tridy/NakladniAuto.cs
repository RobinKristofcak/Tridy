using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tridy
{
   

    class NakladniAuto
    {
        private string SPZ;
        private int nosnost;
        private int hmotnost = 0;


        public NakladniAuto()
        {
            this.SPZ = "ABNC454";
            this.nosnost = 10;
        }

        public string NalozNaklad(int nosnost, int hmotnost)
        {
            if (hmotnost < nosnost)
            {
                string t = "Bylo naloženo " + hmotnost + "t nákladu.";
                return t;
            }
            else
            {
                string t = "Bylo naloženo " + nosnost + "t nákladu (protoze se vice neveslo)."; ;
                return t;
            }
        }

        public int VylozNaklad(int nosnost, int hmotnost)
        {

            hmotnost = hmotnost - hmotnost;
            return hmotnost;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

   
}
