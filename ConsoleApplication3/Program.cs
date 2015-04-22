using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    \n    \n    Welcome to The Apocalypse \n    A text based adventure game where you wake up,\n    in the middle of a zombie apocalypse.\n    The adventure is in your hands\n \n    1.Start Game\n    2.Cheat Sheet\n    3.Exit Game");
            int option;
            string input= Console.ReadLine();
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
      
            if (input.Equals("exit")) 
            {
                Environment.Exit(0);
            }
            if (input.Equals("Knight Info"))
            {
                Console.WriteLine(class1 + "\nPress any Key to Return to Class selection");
                Console.ReadLine();
                cclass();
            }
            if (input.Equals("Mage Info", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(class2 + "\nPress any Key to Return to Class selection");
                Console.ReadLine();
                cclass();
            }
            if (input.Equals("Archer Info", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(class3 + "\nPress any Key to Return to Class selection");
                Console.ReadLine();                
                cclass();

            }
            if (input.Equals("Dwarf Info", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(class4 + "\nPress any Key to Return to Class selection");
                Console.ReadLine();
                cclass();
            }
            if (input.Equals("Orc Info", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(class5 + "\nPress any Key to Return to Class selection");
                Console.ReadLine();
                cclass();
            }

            else{
                Console.WriteLine("=========\nSorry, I don't understand that\n=========");
                cclass();
            }
            Console.ReadLine();

        }

    }
}