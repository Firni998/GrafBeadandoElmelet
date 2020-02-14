using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafBead
{
    class Graf
    {
        int csucsokSzama;

        readonly List<El> elek = new List<El>();

        readonly List<Csucsok> csucsok = new List<Csucsok>();

        public Graf(int csucsok)
        {
            this.csucsokSzama = csucsok;

            for (int i = 0; i < csucsok; i++)
            {
                this.csucsok.Add(new Csucsok(i));
            }
        }

        public void Hozzaad(int cs1, int cs2)
        {
            if (cs1 < 0 || cs1 >= csucsokSzama ||
                cs2 < 0 || cs2 >= csucsokSzama)
            {
                throw new ArgumentOutOfRangeException("Hiba! Rossz csúcs érték");
            }

            foreach (var el in elek)
            {
                if (el.Csucs1 == cs1 && el.Csucs2 == cs2)
                {
                    return;
                }
            }

            elek.Add(new El(cs1, cs2));
            elek.Add(new El(cs2, cs1));
        }

        public override string ToString()
        {
            string str = "Adott csúcsok:" +
                "\n";
            foreach (var cs in csucsok)
            {
                str += cs + "\n";
            }
            str += "Élek:\n";
            foreach (var el in elek)
            {
                str += el + "\n";
            }
            return str;
        }
    }
}

