using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Pointer
    {

        public string convertPoint(int pointNumber)
        {

            string pointOutput = "";

            switch (pointNumber)
            {

                case 0: pointOutput = "Amore"; break;
                case 1: pointOutput = "15"; break;
                case 2: pointOutput = "30"; break;
                case 3: pointOutput = "40"; break;

            }

            return pointOutput;

        }

        public string getPoint(int punteggio1, int punteggio2)
        {
            string result = "";

            if(punteggio1 >= 3 && punteggio2 >= 3)
            {
                if (punteggio1 == punteggio2)
                {

                    result = "Deuce";

                }

                else if (punteggio1 - punteggio2 == 1 || punteggio1 - punteggio2 == -1)
                {

                    if (punteggio1 > punteggio2)
                    {

                        
                        result = $"Vantaggio-{punteggio2}";

                    }

                    else
                    {

                        result = $"{punteggio1}-Vantaggio";

                    }

                }

            }

            else{

                 result = $"{convertPoint(punteggio1)}-{convertPoint(punteggio2)}";

            }

            return result;

        }

    }
}
