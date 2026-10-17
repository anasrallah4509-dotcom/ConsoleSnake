using System;
using System.Threading;

namespace _04Grafica
{
    internal class Program
    {
        static Random rnd = new Random();
        static ConsoleColor[] Colori = {
            
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Yellow,
            };
        static void Main(string[] args)
        {
            char scelta = ' ';
            do
            {
                DisegnaMenu("GRAFICA SEMPLIFICAtA");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta.ToString().ToLower())
                {
                    case "a":
                        QuadratoPieno();
                        break;
                    case "b":
                        QuadratoPienoColoreRiga();
                        break;
                    case "c":
                        QuadratoPienoColoreColonna();
                        break;
                    case "d":
                        AlberoDiNatale();
                        break;
                    case "e":
                        QuadratoConColoriAlternati();
                        break;
                    case "f":
                        QuadratoCorniceEsterna();
                        break;
                    case "g":
                        CorniceEsternaColoriAlternati();
                        break;
                    case "h":
                        QuadratoDiagonale();
                        break;
                    case "i":
                        SoloDiagonali();
                        break;
                    case "j":
                        Triangolo();
                        break;
                    case "k":
                        TriangoloAlto();
                        break;
                    case "l":
                        TriangoloBassoDX();
                        break;
                    case "m":
                        TriangoloAltoDX();
                        break;
                    case "n":
                        CorniceFinestra();
                        break;
                    case "o":
                        CorniceFinestraColorataRND();
                        break;
                    case "p":
                        CorniceColorataAnimata();
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("\nHai inserito una scelta non valida.");
                        break;
                }
                AttesaTasto("Premere invio per chiudere");
            }
            while (scelta.ToString().ToLower() != "q");

        }

        private static void DisegnaMenu(string titolo)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"--- {titolo} ---");
            DisegnaLinea(titolo.Length + 8);
            Console.ResetColor();
            Console.WriteLine("a) Quadrato Pieno");
            Console.WriteLine("b) Quadrato Pieno Colorato");
            Console.WriteLine("c) Quadrato Pieno Colorato Colonna");
            Console.WriteLine("d) Albero di natale");
            Console.WriteLine("e) Quadrato Con Colori Alternati");
            Console.WriteLine("f) Quadrato Solo Con Cornice Esterna");
            Console.WriteLine("g) Cornice Esterna Colori Alternati");
            Console.WriteLine("h) Cornice Esterna e Diagonale");
            Console.WriteLine("i) Solo Diagonali");
            Console.WriteLine("j) Triangolo");
            Console.WriteLine("k) Triangolo dall'alto");
            Console.WriteLine("l) Triangolo basso dx");
            Console.WriteLine("m) Triangolo alto dx");
            Console.WriteLine("n) Cornice finestra");
            Console.WriteLine("o) Cornice colorata");
            Console.WriteLine("p) Cornice colorata animata");
            DisegnaLinea(titolo.Length + 8);
            // .PadLeft serve a mettere tanti caratteri messi nel secondo parametro (-) quanti il numero della variabile che li passi
            Console.ResetColor();
            Console.WriteLine("q) ESCI");
            
        }
        private static void QuadratoPieno()
        {
            Console.WriteLine("--- QUADRATO PIENO ---");
            int n = IntroduciInteroPositivo("Inserire la lungheza dei lati per il quadrato: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        private static void QuadratoPienoColoreRiga()
        {
            Console.WriteLine("--- QUADRATO PIENO COLORATO RIGA ---");
            int n = IntroduciInteroPositivo("Inserire la lungheza dei lati per il quadrato: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                    // if (i % 2 == 0)
                    //  Console.ForegroundColor = ConsoleColor.Green;
                    // else
                    //    Console.ForegroundColor = ConsoleColor.Red;

                    // soluzione migliore e più compatta: 
                    Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Green;
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void QuadratoPienoColoreColonna()
        {
            Console.WriteLine("--- QUADRATO PIENO COLORATO COLONNA ---");
            int n = IntroduciInteroPositivo("Inserire la lungheza dei lati per il quadrato: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.ForegroundColor = j % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Green;
                    Console.Write("* ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void AlberoDiNatale()
        {
            Console.Clear();
            Console.WriteLine("--- ALBERO DI NATALE ---\n");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 - i; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k < 2 * i + 1; k++)
                {

                    if (k % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 6 - i; j++)
                    {
                        Console.Write(" ");

                    }
                    for (int k = 0; k < 2 * i + 1; k++)
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("|");
                    }
                }
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void QuadratoConColoriAlternati()
        {
            Console.WriteLine("--- QUADRATO PIENO COLORATO ALTERNATO ---");
            int n = IntroduciInteroPositivo("Inserire la lungheza dei lati per il quadrato: ");
            Console.WriteLine();
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    cont++;
                    Console.ForegroundColor = cont % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Green;
                    Console.Write("* ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void QuadratoCorniceEsterna()
        {
            Console.WriteLine("--- QUADRATO CORNICE ---");
            int n = IntroduciInteroPositivo("Inserire la lungheza dei lati per il quadrato: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                        Console.Write("* "); 
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        private static void CorniceEsternaColoriAlternati()
        {
            Console.Clear();
            Console.WriteLine("--- CORNICE ESTERNA COLORATO ---");
            int n = IntroduciInteroPositivo("Inserire una lungheza per i lati per il quadrato: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                int cont = i;
                for (int j = 0; j < n; j++)
                {
                    cont++;
                    Console.ForegroundColor = cont % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Green;
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void QuadratoDiagonale()
        {
            Console.Clear();
            Console.WriteLine("--- QUADRATO CORNICE DIAGONALE ---");
            int n = IntroduciInteroPositivo("Inserire la lungheza dei lati per il quadrato: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1 || i == j)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void SoloDiagonali()
        {
            Console.Clear();
            Console.WriteLine("--- QUADRATO CORNICE DIAGONALE ---");
            int n = IntroduciInteroPositivo("Inserire la lungheza dei lati per il quadrato: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i == n - j - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void Triangolo()
        {
            Console.WriteLine("--- TRIANGOLO ---");
            int n = IntroduciInteroPositivo("Inserire altezza del triangolo: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private static void CorniceFinestra()
        {
            Console.Clear();
            Console.Write("".PadLeft(Console.WindowWidth, '*'));
            for (int i = 0; i < Console.WindowHeight - 1; i++)
            { 
                Console.WriteLine("\n*" + "".PadLeft(Console.WindowWidth - 2) + "*");
            }
                Console.Write("".PadLeft(Console.WindowWidth, '*'));
        }

        private static void CorniceFinestraColorataRND()
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    if (i == 0 || i == Console.WindowHeight - 1
                       || j == 0 || j == Console.WindowWidth - 1)
                    {
                        int nColore = rnd.Next(0, 4);
                        Console.ForegroundColor = Colori[nColore];
                        Console.Write('*');
                    }
                    else
                        Console.Write(" ");
                }
            }
            Console.ResetColor();
            Console.ReadKey();
        }

        private static void CorniceColorataAnimata()
        {
            Console.Clear();

            // fa la prima riga il primo for
            for (int j = 0; j < Console.WindowWidth; j++)
            {
                Thread.Sleep(5);
                int nColore = rnd.Next(0, 4);
                Console.ForegroundColor = Colori[nColore];
                Console.SetCursorPosition(j, 0);
                Console.Write('*');
            }

            // parto dalla 2 riga (i = 1) fino alla penultima (-1)
            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                DisegnaAsterisco(Console.WindowWidth - 1, i);
            }

            for (int j = Console.WindowWidth - 1; j >= 0 ; j--)
            {
                DisegnaAsterisco(j, Console.WindowHeight - 1);
            }

            for (int i = Console.WindowHeight - 1; i >= 0 ; i--)
            {
                DisegnaAsterisco(0, i);
            }

            Console.ResetColor();
            Console.ReadKey();
        }

        private static void DisegnaAsterisco(int left, int top)
        {
            Thread.Sleep(5);
            int nColore = rnd.Next(0, 4);
            Console.ForegroundColor = Colori[nColore];
            Console.SetCursorPosition(left, top);
            Console.Write('*');
        }

        private static void TriangoloAlto()
        {
            Console.WriteLine("--- TRIANGOLO ---");
            int n = IntroduciInteroPositivo("Inserire altezza del triangolo: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }

        private static void TriangoloBassoDX()
        {
            Console.WriteLine("--- TRIANGOLO ---");
            int n = IntroduciInteroPositivo("Inserire altezza del triangolo: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("".PadLeft((n - i) * 2));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private static void TriangoloAltoDX()
        {
            Console.WriteLine("--- TRIANGOLO ---");
            int n = IntroduciInteroPositivo("Inserire altezza del triangolo: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("".PadLeft(i * 2));
                for (int j = i; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }

        private static void DisegnaLinea(int lunghezza)
        {
            Console.WriteLine("".PadLeft(lunghezza, '-'));
        }

        static int IntroduciInteroPositivo(string messaggio)
        {
            int n;
            bool isNumOk;
            do
            {
                Console.Write("Introduci un numero intero positivo: ");
                isNumOk = int.TryParse(Console.ReadLine(), out n);
                if (!isNumOk) // il (!Nome_Variabile) il ! va a dire NOT quindi if NOT isNumOK fai questo
                    Console.WriteLine("ATTENZIONE: hai introdotto una stirnga o un numero decimale");
                else if (n <= 0)
                    Console.WriteLine("ATTENZIONE: hai introdotto un numero non positivo (>= 0)");
            }
            while (!isNumOk || n <= 0); // non usare (isNumOk == false) non è elegante usa sempre ! (NOT) è più elegante
            return n;
        }

        static int IntroduciIntero(string messaggio)
        {
            int n;
            bool isNumOk;
            do
            {
                Console.Write(messaggio);
                isNumOk = int.TryParse(Console.ReadLine(), out n);
                if (!isNumOk) // il (!Nome_Variabile) il ! va a dire NOT quindi if NOT isNumOK fai questo
                    Console.WriteLine("ATTENZIONE: hai introdotto una stirnga o un numero decimale");
            }
            while (!isNumOk); // non usare (isNumOk == false) non è elegante usa sempre ! (NOT) è più elegante
            return n;
        }

        static double NumeroPotenza(int b, int e)
        {
            double a;
            a = Math.Pow(b, e);
            return a;
        }

        static void AttesaTasto(string messaggio)
        {
            Console.WriteLine(messaggio);
            Console.ReadLine();
        }
    }
}
