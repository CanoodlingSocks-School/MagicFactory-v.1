using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory_v._1
{
    class Menu
    {
        public void MenuOptions()
        {
            bool menuLoop = true;
            while (menuLoop)
            {
                Console.Clear();
                Player player = new();
                Console.WriteLine("1. Add materials\n2. See inventory\n");
                ConsoleKey input = Console.ReadKey(true).Key;

                if (input == ConsoleKey.D1)
                {
                    Console.WriteLine("\n\nWhat material do you want to add?\n");
                    string material = Console.ReadLine();

                    if (material == "Metal" || material == "Rubber" || material == "Wood")
                    {
                        Console.WriteLine($"How many {material} do you want to add?");
                        int numberOf = Convert.ToInt32(Console.ReadLine());
                        player.AddInventory(material, numberOf);
                        Console.Clear();
                        Console.WriteLine("Current inventory\n:");
                        player.PrintInventory();
                        Console.WriteLine("\nPress any key to return to menu...");
                        Console.ReadKey(true);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, couldn't recognize command, please try again");
                        Console.ReadKey();
                        continue;
                    }
                    
                }
                else if (input == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("Your current inventory is: ");
                    player.PrintInventory();
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey(true);
                    continue;
                }else if (input == ConsoleKey.D3)
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    menuLoop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, couldn't recognize command, please try again");
                    Console.ReadKey();
                    continue;
                }


            }
            //Måste kalla på min dictionary i Material.

            //foreach (var (key, value) in materials)
            //{
            //    Console.WriteLine(key + " : " + value + "\n");  //Visar högst upp vad som redan finns
            //}
            //Console.Clear();
            //Console.WriteLine("Choose material to add(Metal, Rubber or Wood): ");
            //string materialOption = Console.ReadLine();

            //if(materialOption == "Metal"||materialOption == "metal")
            //{
            //    Material metal = new();
            //    metal.Metal();
            //}
        }
    }
}
