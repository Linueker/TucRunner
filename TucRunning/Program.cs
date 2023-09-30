using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TucRunning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float kMspring = 0;
            int energy = 0;
            bool isRunning = true;
            int input = 0;

            while (isRunning)
            {

                Console.WriteLine(

                    " #######   #    #   ######           ######    #    #   #    #   #    #   ######  ######  \r" +
                    "\n    #      #    #   #    #           #    #    #    #   ##   #   ##   #   #       #    #  \r" +
                    "\n    #      #    #   #                #    #    #    #   ###  #   ###  #   #       #    #  \r" +
                    "\n   ##     ##    #  ##                #######  ##    #  ## ## #  ## ## #  #####    ####### \r" +
                    "\n   ##     ##    #  ##                ##    #  ##    #  ##  ###  ##  ###  ##       ##    # \r" +
                    "\n   ##     ##    #  ##    #           ##    #  ##    #  ##   ##  ##   ##  ##       ##    # \r" +
                    "\n   ##     #######  #######           ##    #  #######  ##    #  ##    #  #######  ##    #" +
                    "\n" +
                    "\n");

                Console.WriteLine("Välkommen till TUC Running Simulator 2024!" +
                    "\n" +
                    "\n" +
                    "Vilken är din energinivå?");

                energy = Int32.Parse(Console.ReadLine());


                Console.WriteLine(@"Din intiala energinivå är: " + energy);
                Console.WriteLine("\n" +
                    "Du ska slutföra ett 10 km långt lopp " +
                    "\n" +
                    "\n" +
                    "Ange din hastighet för den kommande kilometern:" +
                    "\n" +
                    "\n 1. snabbast " +
                    "\n 2. snabb " +
                    "\n 3. måttlig " +
                    "\n 4. långsam" +
                    "\n 5. promenad" +
                    "\n " +
                    "\n 6. Avsluta");

                input = Int32.Parse(Console.ReadLine());


                while (input < 6)
                {

                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Du har valt *Snabbast*!");
                            kMspring += 2;
                            energy -= 15;
                            Console.WriteLine(@"Du har springit " + kMspring + "km och har " + energy + " energi kvar att disponera");
                            if (kMspring > 9)
                            {
                                Console.WriteLine("Grattis! Du klarade loppet med " + energy + " energi kvar!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else if (energy < 1)
                            {

                                Console.WriteLine("Du har slut på energi!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else
                                input = Int32.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.WriteLine("Du har valt *Snabb*!");
                            kMspring += 1;
                            energy -= 10;
                            Console.WriteLine(@"Du har springit " + kMspring + "km och har " + energy + " energi kvar att disponera");
                            if (kMspring > 9)
                            {
                                Console.WriteLine("Grattis! Du klarade loppet med " + energy + " energi kvar!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else if (energy < 1)
                            {

                                Console.WriteLine("Du har slut på energi!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else
                                input = Int32.Parse(Console.ReadLine());
                            break;

                        case 3:
                            Console.WriteLine("Du har valt *Måttlig*!");
                            kMspring += 1;
                            energy -= 8;
                            Console.WriteLine(@"Du har springit " + kMspring + "km och har " + energy + " energi kvar att disponera");
                            if (kMspring > 9)
                            {
                                Console.WriteLine("Grattis! Du klarade loppet med " + energy + " energi kvar!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else if (energy < 1)
                            {

                                Console.WriteLine("Du har slut på energi!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else
                                input = Int32.Parse(Console.ReadLine());
                            break;

                        case 4:
                            Console.WriteLine("Du har valt *Långsam*!");
                            kMspring += 1;
                            energy -= 5;
                            Console.WriteLine(@"Du har springit " + kMspring + "km och har " + energy + " energi kvar att disponera");
                            if (kMspring > 9)
                            {
                                Console.WriteLine("Grattis! Du klarade loppet med " + energy + "energi kvar!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else if (energy < 1)
                            {

                                Console.WriteLine("Du har slut på energi!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else
                                input = Int32.Parse(Console.ReadLine());
                            break;

                        case 5:
                            Console.WriteLine("Du har valt *Promenad*!");
                            kMspring += 1;
                            energy -= 2;
                            Console.WriteLine(@"Du har springit " + kMspring + "km och har " + energy + " energi kvar att disponera");
                            if (kMspring > 9)
                            {
                                Console.WriteLine("Grattis! Du klarade loppet med " + energy + " energi kvar!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else if (energy < 1)
                            {

                                Console.WriteLine("Du har slut på energi!");
                                isRunning = false;
                                Console.ReadLine();
                                break;

                            }
                            else
                                input = Int32.Parse(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("Tack för att du spelade!");
                            isRunning = false;
                            Console.ReadLine();
                            break;
                    }



                }


                while (input == 6)
                {
                    Console.WriteLine("" +
                        "\n" +
                        "  ######   ######  #######   ######            ######  ##    #   ######  ######  \r" +
                        "\n  #    #   #    #  #  #  #   #                 #   ##  ##    #   #       #    #  \r" +
                        "\n  #        #    #  #  #  #   #                 #   ##  ##    #   #       #    #  \r" +
                        "\n ##  ###  #######  ## #  #  #####             ##    #  ##   ##  #####    ####### \r" +
                        "\n ##    #  ##    #  ##    #  ##                ##    #   ## ##   ##       ##    # \r" +
                        "\n ##    #  ##    #  ##    #  ##                ##    #    ###    ##       ##    # \r" +
                        "\n #######  ##    #  ##    #  #######           #######     #     #######  ##    # ");
                    isRunning = false;
                    break;
                }
                        
            }

        }
    }
}
