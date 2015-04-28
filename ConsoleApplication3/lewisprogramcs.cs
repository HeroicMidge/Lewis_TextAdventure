using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication3
{
    class lewisprogram
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("=======================\n    \n    Welcome to Infinity. \n    A text based adventure game where you take,\n    control of your character.\n    Choices you make affect the game content.\n    The adventure is now yours\n    1.Start Game\n    2.Cheat Sheet\n    3.Exit Game\n\n=======================");

            string input = Console.ReadLine();
            string startgame = ("Beginning Game");
            string cs = ("Opening Cheat Sheet");
            string exit = ("Thanks for Playing!");

            switch (input.ToLower())
            {
                case "1":
                case "start game":
                case "start":
                    Console.WriteLine(startgame);
                    cclass();
                    break;
                case "2":
                case "cheat Sheet":
                case "cheat":
                    Console.WriteLine(cs);
                    Console.ReadLine();
                    Menu();

                    break;
                case "3":
                case "exit":
                    Console.WriteLine(exit);
                    Console.ReadLine();
                    Menu();

                    break;
                default:
                    Console.WriteLine("=======\nSorry, I don't undertsand that\n=======");
                    Menu();
                    break;

            }
        }



        static void cclass()
        {
            Console.WriteLine("=========\nPlease choose Class between 1-5.\n1.Knight \n2.Mage\n3.Archer\n4.Dwarf\n5.Orc\nFor class Stats, type the class name\nfollowed by 'info'. E.g Orc Info\n=========");
            string input = Console.ReadLine();
            string class1 = ("The Knight is a soldier trained in protecting the royal family.\nNow elderly, and spending most time in Taverns, the knight\nSpends their days slaying monsters and other creatures\nfor bags of gold.\nPreferred Weapon: Sword\nPress Any Key To Return To class selection\n==========");
            string class2 = ("The Mage is a mysterious character, the face covered a dark hood.\nThe mage knows when and when not to attack, \nand spends time roaming the land, rarely returning home.\nPreferred Weapon: Staff/Spells\nPress Any Key To Return To class selection\n==========");
            string class3 = ("The Archer is an elf-like creature, preferring to stay in the shadows and remaining unknown.\nThe archer learns to survive and adapt, probably\nfrom previous generations living in the wild.\nThe Archer has great skill in craftman ship\nPreferred Weapon: Bow&Arrow\nPress Any Key To Return To class selection\n==========");
            string class4 = ("The Dwarf is a small, wide character with a deep, unsatisfiable desire for gold.\nThe dwarf is the most loyal Class, and almost fearless\nThe dwarf loves to fight, drink, sing, then fight some more. \nPreferred weapon: Axes- Crafted from Molten Gold\nPress Any Key To Return To class selection\n==========");
            string class5 = ("The Orc Known to most as barbaric creatures,The Orcs are actually very civillised. Living in large villages, Orcs live independently. It is a rare for an orc to spend longer than 10 hours outside their village.zn The Orc, once aggrivated, are blinded by a dark rage. The strength of the orcs has no limit. \nPreferred Weapon: Fists/Orc Blades.\nPress Any Key To Return To class selection\n==========");

            switch (input.ToLower())
            {
                case "knight info":
                case "knight i":
                case "k i":
                    Console.Clear();
                    Console.WriteLine(class1);
                    Console.ReadLine();
                    cclass();
                    break;
                case "mage info":
                case "mage i":
                case "m i":
                    Console.Clear();
                    Console.WriteLine(class2);
                    Console.ReadLine();
                    cclass();
                    break;
                case "archer info":
                case "archer i":
                case "a i":
                    Console.Clear();
                    Console.WriteLine(class3);
                    Console.ReadLine();
                    cclass();
                    break;
                case "dwarf info":
                case "dwarf i":
                case "d i":
                    Console.Clear();
                    Console.WriteLine(class4);
                    Console.ReadLine();
                    cclass();
                    break;
                case "orc info":
                case "orc i":
                case "o i":
                    Console.Clear();
                    Console.WriteLine(class5);
                    Console.ReadLine();
                    cclass();
                    break;

                case "knight":
                case "k":
                case "1":
                    Console.WriteLine("Are you sure you want to choose:Knight ?");
                    string confirm = Console.ReadLine();
                    switch (confirm.ToLower())
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            Console.Clear();
                            cclass();
                            break;
                    }
                    break;


                case "mage":
                case "m":
                case "2":
                    Console.WriteLine("Are you sure you want to choose:Mage ?");
                    string confirm1 = Console.ReadLine();
                    switch (confirm1.ToLower())
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.Clear();
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }
                    break;
                case "archer":
                case "a":
                case "3":
                    Console.WriteLine("Are you sure you want to choose:Archer ?");
                    string confirm2 = Console.ReadLine();
                    switch (confirm2.ToLower())
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.Clear();
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }

                    break;
                case "dwarf":
                case "d":
                case "4":
                    Console.WriteLine("Are you sure you want to choose:Dwarf ?");
                    string confirm3 = Console.ReadLine();
                    switch (confirm3.ToLower())
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.Clear();
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }
                    break;
                case "orc":
                case "o":
                case "5":
                    Console.WriteLine("Are you sure you want to choose:Orc ?");
                    string confirm4 = Console.ReadLine();
                    switch (confirm4.ToLower())
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.Clear();
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Sorry. I don't understand that, please input your class choice\n========");
                    cclass();
                    break;
            }
        }
        static void room1()
        {
            Console.WriteLine("You have reached Room1");
            Console.ReadLine();
        }


        static void begin(string input)
        {
            Console.WriteLine("==========\nYou have chosen " + input + "\n========\nLoading Game\n");

            for (int i = 0; i < 10; )
            {
                Console.Write("=");
                Thread.Sleep(500);
                i++;
            }
            Console.WriteLine("\nClearing The Console. The game begins now");
            Thread.Sleep(900);
            Console.Clear();
           string exit= Console.ReadLine();
            if (exit.Equals ("exit"))
            {
                Environment.Exit(0);
                
            }
        }


    }
}