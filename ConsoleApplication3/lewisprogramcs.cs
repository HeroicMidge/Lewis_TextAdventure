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
            Console.WriteLine("==========\n    \n    Welcome to Infinity. \n    A text based adventure game where you take,\n    control of your character.\n    Choices you make affect the game content.\n    The adventure is now yours\n    1.Start Game\n    2.Cheat Sheet\n    3.Exit Game\n\n===========");

            string input = Console.ReadLine();
            string startgame = ("Beginning Game");
            string cs = ("Opening Cheat Sheet! (Not Developed yet, Press any key to return to menu)");
            string exit = ("Thanks for Playing!(Not Developed yet, Press any key to return to menu)");

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
            Console.WriteLine("\n==========    \n    Please Enter your Character name below\n==========");
            string cname= Console.ReadLine();
            string input = "";
            int loop = 10;
            while (loop < 100) //this is where I want it to start again, if a user goes to info or say No when asked if they want to confirm.
            {
                Console.WriteLine("==========\n    Please choose Class between 1-5.\n    1.Knight \n    2.Mage\n    3.Archer\n    4.Dwarf\n    5.Orc\n    For class Stats, type the class name\n    followed by 'info'. E.g Orc Info\n==========");
                input = Console.ReadLine();
                {

                    string class1 = ("==========\n    The Knight is a soldier trained in protecting the royal family.\nNow elderly, and spending most time in Taverns, the knight\nSpends their days slaying monsters and other creatures\nfor bags of gold.\nPreferred Weapon: Sword\nPress Any Key To Return To class selection\n==========");
                    string class2 = ("==========\n    The Mage is a mysterious character, the face covered a dark hood.\nThe mage knows when and when not to attack, \nand spends time roaming the land, rarely returning home.\nPreferred Weapon: Staff/Spells\nPress Any Key To Return To class selection\n==========");
                    string class3 = ("==========\n    The Archer is an elf-like creature, preferring to stay in the shadows and remaining unknown.\nThe archer learns to survive and adapt, probably\nfrom previous generations living in the wild.\nThe Archer has great skill in craftman ship\nPreferred Weapon: Bow&Arrow\nPress Any Key To Return To class selection\n==========");
                    string class4 = ("==========\n    The Dwarf is a small, wide character with a deep, unsatisfiable desire for gold.\nThe dwarf is the most loyal Class, and almost fearless\nThe dwarf loves to fight, drink, sing, then fight some more. \nPreferred weapon: Axes- Crafted from Molten Gold\nPress Any Key To Return To class selection\n==========");
                    string class5 = ("==========\n    The Orc Known to most as barbaric creatures,The Orcs are actually very civillised. Living in large villages, Orcs live independently. It is a rare for an orc to spend longer than 10 hours outside their village.zn The Orc, once aggrivated, are blinded by a dark rage. The strength of the orcs has no limit. \nPreferred Weapon: Fists/Orc Blades.\nPress Any Key To Return To class selection\n==========");


                    switch (input.ToLower())
                    {
                        case "knight info":
                        case "knight i":
                        case "k i":
                            Console.Clear();
                            Console.WriteLine(class1);
                            break;
                        case "mage info":
                        case "mage i":
                        case "m i":
                            Console.Clear();
                            Console.WriteLine(class2);
                            Console.ReadLine();
                          
                            break;
                        case "archer info":
                        case "archer i":
                        case "a i":
                            Console.Clear();
                            Console.WriteLine(class3);
                            Console.ReadLine();
                            
                            break;
                        case "dwarf info":
                        case "dwarf i":
                        case "d i":
                            Console.Clear();
                            Console.WriteLine(class4);
                            Console.ReadLine();
                            
                            break;
                        case "orc info":
                        case "orc i":
                        case "o i":
                            Console.Clear();
                            Console.WriteLine(class5);
                            Console.ReadLine();
                            break;

                        case "knight":
                        case "k":
                        case "1":
                        input = "Knight"; //This makes it so the 'input' is actually the class name not the shortcut key.
                        break;


                        case "mage":
                        case "m":
                        case "2":
                          
                           input = "Mage";
                           
                      

                            break;
                        case "archer":
                        case "a":
                        case "3":
                            
                                input = "Archer";
                                break;
                        case "dwarf":
                        case "d":
                        case "4":


                                input = "Dwarf";

                            break;
                        case "orc":
                        case "o":
                        case "5":
                        input = "Orc";                                      
                            break;

                        default:
                            Console.WriteLine("Sorry. I don't understand that, please input your class choice\n========");
                            break;
                    }
                    Console.WriteLine("Are you sure you want to choose:" + input + "?");
                    string confirm6 = Console.ReadLine();
                    if (confirm6.ToLower().Equals("yes") || confirm6.ToLower().Equals("y"))
                    {
                        loop = 500;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ok! returning to class selection\n\n");
                    }
                }
            }
            begin(input, cname);
        }
        static void room1(string choice, string cname)
        {
            Console.WriteLine("==========\n    Welcome "+cname+". I've heard alot about you. The infamous "+choice);
            Console.ReadLine();
        }


        static void begin(string input,string cname)
        {
            Console.WriteLine("==========\nYou have chosen " + input + "\n========\nLoading Game\n");

            for (int i = 0; i < 10; )
            {
                Console.Write("=");
                Thread.Sleep(500);
                i++;
            }
            Console.WriteLine("\nClearing The Console. The game begins now");
            Thread.Sleep(1000);
            Console.Clear();
            room1(input, cname);
          }


    }
}