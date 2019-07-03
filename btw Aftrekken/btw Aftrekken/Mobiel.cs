using System;

namespace btw_Aftrekken
{

    public class Mobiel
    {
        private int BTWPercentage;
        private string type;
        private string soort;
        private string merk;
        private string os;

        public Mobiel(int nBTWPercentage, string nType, string nSoort, string nMerk, string nOs)
        {
            BTWPercentage = nBTWPercentage;
            type = nType;
            soort = nSoort;
            merk = nMerk;
            os = nOs;
        }

        public int GetBTWPercentage()
        {
            return BTWPercentage;
        }
    }
}