using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG
{
    class Menu
    {
        static int index = 0;
        public static void mainMenu()
        {
            Console.CursorVisible = false;
            List<string> mainMenuItems = new List<string>() {
                "START GAME",
                "CREDITS",
                "EXIT"
            };
            while (true)
            {
                string selectedMenuItem = moveMenu(mainMenuItems);
                if (selectedMenuItem == "START GAME")
                {
                    CharacterCreation.genderMenu();
                    break;

                }
                else if (selectedMenuItem == "CREDITS")
                {
                    // Not working yet!!!
                    Console.ReadKey(false);
                    List<string> Credits = new List<string>()
                        {
                            " _____              _ _ _       ",
                            "/  __ \\            | (_) |      ",
                            "| /  \\/_ __ ___  __| |_| |_ ___ ",
                            "| |   | '__/ _ \\/ _` | | __/ __|",
                            "| \\__/\\ | |  __/ (_| | | |_\\__ \\",
                            " \\____/_|  \\___|\\__,_|_|\\__|___/"

                        };
                    int j = 2;
                    string back = "Back";
                    List<string> Names = new List<string>()
                    {
                    "Krizsanyik Levente",
                    "Rákóczi Levente",
                    "Szóláth Ákos",
                    "Sipos Attila",
                    "Bába Benjámin"
                    };

                    while (!Console.KeyAvailable)
                    {
                        Console.ReadKey(false);
                        Console.Clear();
                        for (int i = 0; i < Credits.Count; i++)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - Credits[i].Length) / 2, Console.CursorTop);
                            Console.WriteLine(Credits[i]);
                        }
                        Console.Write("\n\n\n");
                        for (int i = 0; i < Names.Count; i++)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - Names[i].Length) / 2, Console.CursorTop);
                            Console.WriteLine(Names[i]);
                            Console.Write("\n\n\n");
                        }
                        if (j % 2 == 0)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - back.Length) / 2, Console.CursorTop);
                            Console.WriteLine(back);
                            Thread.Sleep(750);
                            j++;
                        }
                        else
                        {
                            Thread.Sleep(750);
                            j++;
                        }
                    }
                    break;
                }
                else if (selectedMenuItem == "EXIT")
                {
                    Environment.Exit(0);
                    break;
                }
                Console.Clear();
            }


        }
        public static string moveMenu(List<string>mainMenuItems)
        {
            List<string> BlathyLife = new List<string>
            {
        "______ _       _   _             _     _  __     ",
        "| ___ \\ |     | | | |           | |   (_)/ _|    ",
        "| |_/ / | __ _| |_| |__  _   _  | |    _| |_ ___ ",
        "| ___ \\ |/ _` | __| '_ \\| | | | | |   | |  _/ _ \\",
        "| |_/ / | (_| | |_| | | | |_| | | |___| | ||  __/",
        "\\____/|_|\\__,_|\\__|_| |_|\\__, | \\_____/_|_| \\___|",
        "                          __/ |                  ",
        "                         |___/                   ",

            };
            for (int i = 0; i < BlathyLife.Count; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - BlathyLife[i].Length) / 2, Console.CursorTop);
                Console.WriteLine(BlathyLife[i]);
            }
            Console.Write("\n\n");
            for (int i = 0; i < mainMenuItems.Count; i++)
            {
                if (i == index)
                {
                    Console.SetCursorPosition((Console.WindowWidth - mainMenuItems[i].Length) / 2, Console.CursorTop);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(mainMenuItems[i]);
                }
                else
                {
                    Console.SetCursorPosition((Console.WindowWidth - mainMenuItems[i].Length) / 2, Console.CursorTop);
                    Console.WriteLine(mainMenuItems[i]);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == mainMenuItems.Count - 1)
                {
                    index = 0;

                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = 2;

                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return mainMenuItems[index];
            }
            return "";
        }
    }
}
