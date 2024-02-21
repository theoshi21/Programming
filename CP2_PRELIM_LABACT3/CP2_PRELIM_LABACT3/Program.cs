using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CP2_PRELIM_LABACT3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int participant = 50;
            string[] name = new string[participant];
            int[] yearlvl = new int[participant];
            int[] block = new int[participant];
            int[] bestbooth = new int[participant];

            //Input for each participants
            for (int i = 0; i < participant; i++)
            {

                header();
                Console.WriteLine($"Participant #{i + 1}");

                Console.Write("Name: ");
                name[i] = Console.ReadLine();

                do
                {
                    Console.Write("Year Level (1-4): ");
                    if (int.TryParse(Console.ReadLine(), out yearlvl[i]))
                    {
                        if (!(yearlvl[i] >= 1 && yearlvl[i] <= 4)) Console.WriteLine("Year level is not valid, try again.");
                    }
                    else Console.WriteLine("Year level should be a number.");

                }
                while (!(yearlvl[i] >= 1 && yearlvl[i] <= 4));

                do
                {
                    Console.Write("Block (ex. 101): ");
                    if (int.TryParse(Console.ReadLine(), out block[i]))
                    {
                        if (!((block[i] >= 101 && block[i] <= 104) || (block[i] >= 201 && block[i] <= 204) || (block[i] >= 301 && block[i] <= 302) || (block[i] >= 401 && block[i] <= 402)))
                        {
                            Console.WriteLine("Block entered is not valid, try again.");
                        }
                    }
                    else Console.WriteLine("Block should be numbers.");

                }
                while (!((block[i] >= 101 && block[i] <= 104) || (block[i] >= 201 && block[i] <= 204) || (block[i] >= 301 && block[i] <= 302) || (block[i] >= 401 && block[i] <= 402)));

                do
                {
                    Console.Write("Best Booth (1-13): ");
                    if (int.TryParse(Console.ReadLine(), out bestbooth[i]))
                    {
                        if (!(bestbooth[i] >= 1 && bestbooth[i] <= 13))
                        {
                            Console.WriteLine("Booth number is not valid, try again.");
                        }
                    }
                    else Console.WriteLine("Best booth should be a number.");
                }
                while (!(bestbooth[i] >= 1 && bestbooth[i] <= 13));
                Console.Clear();
            }
 
            /*
            string[] name = { "Kelvin Ignacio", "Jacob Sierra", "Roshan Santarin", "CK Garcia", "Kim Monteagudo", "Conrado Zaragoza", "Alma Pangilinan", "Neil Fernandez", "Adrian Aclan", "Ethan Loanzon", "Kent Cayayan", "Eyo Buenaventura", "Joshua Narag", "Dann Leyesa", "Vince Emejas", "Renzo Bocalbos", "Viccel Perjes", "Jocelyn Garcia", "Kuh Valenzuela", "Clarence Manahan", "Clarence Benitez", "Charlie Paracale", "Camille Paracale", "Jd Satsatin", "Krystyn Segovia", "Pamela Opiana", "Abby Salas", "Sofhieya Misenas", "Camry Figueroa", "Andrea Beruete", "Monina Varona", "Gabriel Santiago", "Henry Abangon", "Breanne Cayabyab", "Rain Alvarez", "Elijah Salas", "Keyon Francisco", "Erich Hingco", "Ily Laudato", "Kristel Sagum", "Rain Alvarez", "Yerale Tejero", "Mhica Caoile", "Icelle Semper", "Rhydel Salgado", "Rimmuel Fernandez", "Emmanuel Concepcion", "Tracy Loreto", "Vincent Corpuz", "AdUG Theo" };
            int[] bestbooth = { 6, 4, 3, 11, 12, 1, 7, 5, 9, 10, 13, 2, 6, 4, 3, 11, 12, 1, 5, 10, 13, 2, 6, 8, 4, 3, 11, 12, 1, 7, 5, 9, 10, 13, 2, 6, 8, 4, 3, 11, 1, 7, 5, 9, 10, 13, 2, 6, 8 };
            int[] yearlvl = { 1, 2, 1, 3, 4, 2, 1, 3, 2, 4, 1, 3, 4, 2, 1, 3, 2, 4, 1, 3, 4, 2, 1, 3, 2, 4, 1, 3, 4, 2, 1, 3, 2, 1, 3, 4, 2, 1, 3, 2, 4, 1, 3, 4, 2, 1, 3, 4, 2, 1 };
            int[] block = { 101, 202, 103, 301, 401, 203, 102, 301, 201, 401, 101, 302, 402, 202, 102, 301, 203, 401, 104, 401, 103, 201, 302, 402, 104, 202, 301, 401, 101, 202, 301, 402, 103, 203, 302, 401, 102, 203, 301, 401, 101, 202, 302, 401, 104, 201, 301, 402, 103, 102, 302, 401, 202, 101 };
            */


            bool displaying = true;
            while (displaying)
            {
                header();
                Console.WriteLine("Please choose which you want to display: ");
                Console.WriteLine("[Display 1] Best Booth");
                Console.WriteLine("[Display 2] Registered Names");
                Console.WriteLine("[Display 3] Best Booth By Year Level");
                while (true)
                {
                    Console.Write("ACTION: ");
                    string ans = Console.ReadLine().ToLower();

                    if (ans == "display 1" || ans == "1")
                    {
                        Console.Clear();
                        Display1(bestbooth);
                        break;
                    }
                    else if (ans == "display 2" || ans == "2")
                    {
                        Console.Clear();
                        Display2(name, block);
                        break;
                    }
                    else if (ans == "display 3" || ans == "3")
                    {
                        Console.Clear();
                        Display3(bestbooth, yearlvl);
                        break;
                    }
                    else Console.WriteLine("That is not one of the options, please try again.");
                }

                while (true)
                {
                    Console.Write("\nWould you like to see other displays? [Y/N]: ");
                    string disp = Console.ReadLine().ToLower();
                    if (disp == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (disp == "n")
                    {
                        Console.WriteLine("\nThank you for using the program!");
                        displaying = false;
                        break;
                    }
                    else Console.WriteLine("That is not an option, please try again.");
                }
            }
            Console.ReadKey();
        }

        //Function for display 1 (showing the top 1-3 booths)
        static void Display1(int[] bestbooth)
        {
            header();
            Console.WriteLine("DISPLAY 1 [Best Booths]");

            int[,] boothCounts = new int[13, 2];
            for (int i = 0; i < 13; i++)
            {
                boothCounts[i, 0] = i + 1;
                boothCounts[i, 1] = bestbooth.Count(s => s == (i + 1));
            }

            for (int i = 0; i < boothCounts.GetLength(0); i++)
            {
                for (int j = i + 1; j < boothCounts.GetLength(0); j++)
                {
                    if (boothCounts[i, 1] < boothCounts[j, 1])
                    {
                        int votes = boothCounts[i, 1];
                        boothCounts[i, 1] = boothCounts[j, 1];
                        boothCounts[j, 1] = votes;

                        int boothNum = boothCounts[i, 0];
                        boothCounts[i, 0] = boothCounts[j, 0];
                        boothCounts[j, 0] = boothNum;
                    }
                }
            }

            Console.WriteLine($"1st Place: Booth #{boothCounts[0, 0]} with {boothCounts[0, 1]} votes");
            Console.WriteLine($"2nd Place: Booth #{boothCounts[1, 0]} with {boothCounts[1, 1]} votes");
            Console.WriteLine($"3rd Place: Booth #{boothCounts[2, 0]} with {boothCounts[2, 1]} votes");
        }

        //Function for display 2 which prints out the names and block in tabular form.
        static void Display2(string[] name, int[] block)
        {
            header();
            Console.WriteLine("DISPLAY 2 [Registered Names]");

            Console.WriteLine(String.Format("{0,-5} {1,-20} {2,-10}", "#", "NAMES", "BLOCK"));
            for (int i = 0; i < name.Length; i++)
            {
                int num = i + 1;
                string names = name[i];
                string blocks = "CS"+block[i].ToString();
                Console.WriteLine(String.Format("{0,-5} {1,-20} {2,-10}", num, names, blocks));
            }
            Console.WriteLine();
        }

        static void Display3(int[] bestbooth, int[] yearlvl)
        {
            header();
            Console.WriteLine("DISPLAY 3 [Best Booth By Year Level]");

            int[,,] bestBoothYear = new int[4, 13, 2];

            //The loop responsible for counting the votes for each booth, in their year respectively.
            for (int stud = 0; stud < bestbooth.Length; stud++)
            {
                int yr = (yearlvl[stud]) - 1;
                int booth = (bestbooth[stud]) - 1;
                bestBoothYear[yr, booth, 1]++;
            }

            //An algorithm for checking the maximum value in each year then storing them in a two-dimensional array which represents the booth number and the highest vote for each year lvl.
            //Gumawa ako dito ng two-dimensional array that will represent the year level and booth number and number of votes
            int[,] maxBoothNum = new int[4, 2];
            for (int yr = 0; yr < 4; yr++)
            {
                
                //Nag-initialize ng 1d array na paglalagyan ko ng mga number of votes para magamit yung max function.
                int[] singleList = new int[bestBoothYear.GetLength(1)];
                for (int i = 0; i < bestBoothYear.GetLength(1); i++)
                {
                    singleList[i] = bestBoothYear[yr, i, 1];
                }
                int max = singleList.Max();

                //An algorithm that will determine what index has the maximum value and it will depend the booth number from that. (ex. index 3 has the max value, therefore booth 4 has max value)
                for (int i = 0; i < bestBoothYear.GetLength(1); i++)
                {
                    if (max == bestBoothYear[yr, i, 1])
                    {
                        //Storing the determined booth with the max value. Index 0 is the booth, while, index 1 is the number of vote.
                        maxBoothNum[yr, 0] = i+1;
                        maxBoothNum[yr, 1] = max;
                        break;
                    }   
                }
            }

            //A loop for writing all of the results
            for (int i = 0; i < 4; i++)
            {
                if (i == 0) Console.Write($"{i+1}st Year: Booth #{maxBoothNum[i,0]} with {maxBoothNum[i,1]} votes.\n");
                if (i == 1) Console.Write($"{i+1}nd Year: Booth #{maxBoothNum[i, 0]} with {maxBoothNum[i, 1]} votes.\n");
                if (i == 2) Console.Write($"{i+1}rd Year: Booth #{maxBoothNum[i, 0]} with {maxBoothNum[i, 1]} votes.\n");
                if (i == 3) Console.Write($"{i+1}th Year: Booth #{maxBoothNum[i, 0]} with {maxBoothNum[i, 1]} votes.\n");
            }
        }

        static void header()
        {
            Console.WriteLine(@"
  ___               _     _       __   __        _     _                   ___               _                 
 | _ )  ___   ___  | |_  | |_     \ \ / /  ___  | |_  (_)  _ _    __ _    / __|  _  _   ___ | |_   ___   _ __  
 | _ \ / _ \ / _ \ |  _| | ' \     \ V /  / _ \ |  _| | | | ' \  / _` |   \__ \ | || | (_-< |  _| / -_) | '  \ 
 |___/ \___/ \___/  \__| |_||_|     \_/   \___/  \__| |_| |_||_| \__, |   |___/  \_, | /__/  \__| \___| |_|_|_|
                                                                 |___/           |__/                          ");
        }
    }
}
