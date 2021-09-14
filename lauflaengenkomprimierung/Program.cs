using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lauflaengenkomprimierung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablen werden deklariert und zugewiesen = definieren
            // Variablendeklaration = "string name;"
            int anzahl = 0;
            int index = 0;
            int i = 0;
            string Bilddaten = "QQQQRRRRRRTTTTTTTTTTLLLLLLLLLLLMNNNVVVVVVVVVVVAAAAAAAAAAAAA";
            string KomprimierteDaten = "";

            // kopfgesteuerte Schleife - erst Bedingung prüfen, dann Schleife ausführen
            while (index < Bilddaten.Length)
            {
                // Variablen werden Werte zugewiesen
                anzahl = 0;
                i = index;

                // solange das aktuelle Zeichen und das vorherige Zeichen gleich und nicht alle Zeichen untersucht wurden
                while ((i < Bilddaten.Length) && (Bilddaten[i] == Bilddaten[index]))
                {
                    // erhöhen beide Variable um 1
                    anzahl = anzahl + 1;
                    i = i + 1;
                }

                // Zeichen mehr als dreimal in Folge
                if(anzahl > 3)
                {
                    // Komprimierungsvorschrift umsetzen
                    KomprimierteDaten = KomprimierteDaten + "§" + anzahl.ToString() + Bilddaten[index];

                    // Laufindex
                    index = index + anzahl;
                }

                // Zeichen weniger als 4 mal in Folge
                else
                {
                    // Zeichen ohne Komprimierungsvorschrift ausgeben
                    KomprimierteDaten = KomprimierteDaten + Bilddaten[index];
                    index = index + 1;
                }  
            }

            // Konsolenausgabe
            System.Console.WriteLine(KomprimierteDaten);
        }
    }
}
