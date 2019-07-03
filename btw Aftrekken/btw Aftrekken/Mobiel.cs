using System;

namespace btw_Aftrekken
{

    public class Mobiel
    {
        private int BTWPercentage;
        private string Type;
        private string Soort;
        private string Merk;
        private string OS;

        public Mobiel(int nBTWPercentage, string nType, string nSoort, string nMerk, string nOS)
        {
            BTWPercentage = nBTWPercentage;
            Type = nType;
            Soort = nSoort;
            Merk = nMerk;
            OS = nOS;
        }

        public int GetBTWPercentage()
        {
            return BTWPercentage;
        }
    }
}