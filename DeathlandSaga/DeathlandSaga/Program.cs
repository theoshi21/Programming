using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathlandSaga
{
    internal class Program
    {
        public static int chapter = 0; public static int[] coord = { 1, 1 };
        static string[,] prompt = { 
            {"a","You went inside the stylist.",""},
            {"You went in the crowd.","You are in prontera. There’s a warp portal in front of you, a stylist to your left, a tool shop to your right, and lots of people at the back.","You went inside the portal. You have been teleported to the Tree of Yggdrasil. It seems magical out here."},
            {"d","You went inside the tool shop.",""} 
        };

        static void Main(string[] args)
        {
            startDeathland();
        }

        static void startDeathland()
        {
            Console.WriteLine("Welcome to Deathland Saga");
            Console.WriteLine("*************************");
            start();
            answer();
        }

        static void commands()
        {
            Console.WriteLine("Your available commands are:\n[1] go\n[2] take\n[3] loc");
        }

        static int[] move(string direction, int[] coord)
        {
            if (direction.ToLower() == "go up")
            {
                coord[1] += 1;
            }
            else if (direction.ToLower() == "go down")
            {
                coord[1] -= 1;
            }
            else if (direction.ToLower() == "go right")
            {
                coord[0] += 1;
            }
            else if (direction.ToLower() == "go left")
            {
                coord[0] -= 1;
            }
            else Console.WriteLine("Invalid direction.\nAgain,");

            return coord;
        }

        static void location(int[] coord, string[,] prompt)
        {
            Console.WriteLine(prompt[coord[0],coord[1]]);
        }

        static void answer()
        {
            bool flag = true;
            while (flag) { 
            Console.Write("ACTION: ");
            string act = Console.ReadLine();

                if ((act.ToLower()).Contains("go"))
                {

                    location(move(act.ToLower(), coord), prompt);
                }
                else if (act.ToLower().Contains("take"))
                {
                    Console.Write("You took ");
                    for (int i = 5; i < act.Length; i++)
                    {
                        Console.Write(act[i]);
                    }
                }
                else if (act.ToLower() == "command" || act.ToLower() == "commands")
                {
                    commands();
                }
                else if (act.ToLower() == "loc" || act.ToLower() == "location")
                {
                    location(coord,prompt);
                }
                else Console.WriteLine("Invalid action, try again.");
                Console.WriteLine();
            }

        }
        static void start()
        {
            Console.WriteLine("\n"+prompt[1, 1]);
        }

    }
}
