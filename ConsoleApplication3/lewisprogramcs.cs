using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class lewisprogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================\n    \n    Welcome to Infinity. \n    A text based adventure game where you take,\n    control of your character.\n    Choices you make affect the game content.\n    The adventure is now yours\n    1.Start Game\n    2.Cheat Sheet\n    3.Exit Game\n\n=======================");
            int option;
            string input = Console.ReadLine();
            option = Int32.Parse(input);
            string startgame = ("Beginning Game");
            string cs = ("Opening Cheat Sheet");
            string exit = ("Thanks for Playing!");

            switch (option)
            {
                case 1:
                    Console.WriteLine(startgame);
                    cclass();
                    break;
                case 2:
                    Console.WriteLine(cs);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine(exit);
                    Console.ReadLine();
                    break;
            }
        }

        static void cclass()
        {
            Console.WriteLine("=========\nPlease choose Class between 1-5.\n1.Knight \n2.Mage\n3.Archer\n4.Dwarf\n5.Orc\nFor class Stats, type the class name\n followed by 'info'. E.g Orc Info\n=========");
            string input = Console.ReadLine();
            string class1 = ("The Knight is a soldier trained in protecting the royal family.\nNow elderly, and spending most time in Taverns, the knight\nSpends their days slaying monsters and other creatures\nfor bags of gold.\nPreferred Weapon: Sword");
            string class2 = ("The Mage is a mysterious character, the face covered a dark hood.\nThe mage knows when and when not to attack, \nand spends time roaming the land, rarely returning home.\nPreferred Weapon: Staff/Spells");
            string class3 = ("The Archer is an elf-like creature, preferring to stay in the shadows and remaining unknown.\nThe archer learns to survive and adapt, probably\nfrom previous generations living in the wild.\nThe Archer has great skill in craftman ship\nPreferred Weapon: Bow&Arrow");
            string class4 = ("The Dwarf is a small, wide character with a deep, unsatisfiable desire for gold.\nThe dwarf is the most loyal Class, and almost fearless\nThe dwarf loves to fight, drink, sing, then fight some more. \nPreferred weapon: Axes- Crafted from Molten Gold");
            string class5 = ("Known to most as barbaric creatures,The Orcs are actually very civillised. Living in large villages, Orcs live independently. It is a rare for an orc to spend longer than 10 hours outside their village.zn The Orc, once aggrivated, are blinded by a dark rage. The strength of the orcs has no limit. \nPreferred Weapon: Fists/Orc Blades.  ");

            switch (input)
            {
                case "Knight Info":
                case "Knight I":
                case "K I":
                    Console.Clear();
                    Console.WriteLine(class1);
                    break;
                case "Mage Info":
                case "Mage I":
                case "M I":
                    Console.Clear();
                    Console.WriteLine(class2);
                    break;
                case "Archer Info":
                case "Archer I":
                case "A I":
                    Console.Clear();
                    Console.WriteLine(class3);
                    break;
                case "Dwarf Info":
                case "Dwarf I":
                case "D I":
                    Console.Clear();
                    Console.WriteLine(class4);
                    break;
                case "Orc Info":
                case "Orc I":
                case "O I":
                    Console.Clear();
                    Console.WriteLine(class1);
                    break;
                case "Knight":
                case "K":
                    Console.WriteLine("Are you sure you want to choose:" + input);
                    string confirm = Console.ReadLine();
                    switch (confirm)
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                           break;
                    }
                    break;
                case "Mage":
                case "M":
                    Console.WriteLine("Are you sure you want to choose:" + input);
                    string confirm1 = Console.ReadLine();
                    switch (confirm1)
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }
                    break;
                case "Archer":
                case "A":
                    Console.WriteLine("Are you sure you want to choose:" + input);
                    string confirm2 = Console.ReadLine();
                    switch (confirm2)
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }

                    break;
                case "Dwarf":
                case "D":
                    Console.WriteLine("Are you sure you want to choose:" + input);
                    string confirm3 = Console.ReadLine();
                    switch (confirm3)
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }
                    break;
                case "Orc":
                case "O":
                    Console.WriteLine("Are you sure you want to choose:" + input);
                    string confirm4 = Console.ReadLine();
                    switch (confirm4)
                    {
                        case "yes":
                        case "y":
                            begin(input);
                            break;
                        case "no":
                        case "n":
                            Console.WriteLine("Ok! returning to class selection\n\n");
                            cclass();
                            break;
                    }
                    break;
            }
        }

        static void begin(string input)
        {
            Console.WriteLine("You have chosen" + input + "\nBeginning Game\n========");
            Console.ReadLine();
        }
    }
}
		  