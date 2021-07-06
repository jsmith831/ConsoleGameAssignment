using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameAssignment
{
    public class ProgramUI
    {
        public enum Item { safecode, windowkey}
        public List<Item> inventory = new List<Item>();

        Dictionary<string, Room> Rooms = new Dictionary<string, Room>
        {
            {"Front Door", frontDoor},
            {"Dining Room", diningRoom},
            {"Up Stairs", upStairs },
            {"Living Room", livingRoom },
            {"Table", table },
            {"Kitchen", kitchen },
            {"Loft", loft },
            {"Master", master },
            {"Down Stairs", downStairs },
            {"Laundry Room", laundryRoom },
            {"Window", window },
            {"Phone", phone },
        };
        public static Room frontDoor = new Room(
             "\n\n\n\n\nYou're at the front door. It locked behind you from the outside.\n\n" +
            "Quick, choose between the DINING ROOM, UP STAIRS, or the LIVING ROOM\n",
            new List<string> { "dining room", "up stairs", "living room" }
            );

        // Option 1: Dining Room                                                            // If move to kitchen - death. How to code that?
        public static Room diningRoom = new Room(
            "\n\n\n\n\nYou entered the dining room just as the \n" +
            "psychopath entered from the other side!\n\n" +
            "Quick - hide under the TABLE or go to the KITCHEN\n",
            new List<string> { "table", "kitchen" }
            );
        public static Room table = new Room(
            "\n\n\n\n\nWhew! That was close. Hurry up and make your move! \n" +
            "Go back to the FRONT DOOR or make a run for the KITCHEN\n\n",
            new List<string> { "front door", "kitchen" }
            );       
        public static Room kitchen = new Room(
            "\n\n\n\n\nSeriously? Who can eat at a time like this? \n" +
            "Pick up window key\n" +                                                            // How do I pick up an item?
            "Go to the LIVING ROOM\n\n" +
            new List<string> { "living room" },
            new List<string> { "windowkey"}
            );

        // Option 2: Up Stairs
        public static Room upStairs = new Room(
            "\n\n\n\n\nYou went up the stairs. The coast is clear. \n" +
            "Search the LOFT or enter the MASTER BEDROOM\n\n",
            new List<string> { "loft", "master" }
            );
        public static Room loft = new Room(
            // If they have opened the safe...
            "\n\n\n\n\nWho hangs out in lofts? You do! Go to the window to escape! \n",
            new List<string> { "window" });
        public static Room window = new Room (
            "\n\n\n\nYou nearly got boxed up! Great job on being a sneaky, debt-ridden theif!\n" +
            "Go pay off those bookies you degenerate!",                                         // This is the end. How do I make it the end/

            //If they haven't opened the safe...                                                // How do I code it to know if they have opened the safe?
            //"\n\n\n\n\nBrr... Who left that window open? And who hangs out in lofts anyway? \n" +
            //"Go back DOWN STAIRS or go into the MASTER\n\n",
            new List<string> { "downStairs", "master"}
            ); 
        public static Room master = new Room(
            // If they have the code...
            "\n\n\n\n\nYou found the safe! Enter the code and get out of here!.\n",             // How do I make it so that you have to enter something before moving on? If / else?

            // After entering the code...

            //"\nGood job. Head back DOWN STAIRS and let's get out of here! \n" +
            //"Go back DOWNSTAIRS.\n\n",
            //new List<string> { "down stairs" },

            //// If they do NOT have the code...                                                  // How do I make it so that it knows you don't have the code?
            //"\n\n\n\nYou found the safe but don't have the code!\n" +
            //"Search the house and come back.\n" +
            //"Go to the LOFT or back DOWN STAIRS\n\n",
            new List<string> { "loft", "down stairs" }
            );
        public static Room downStairs = new Room(
            "\n\n\n\n\nYou went down the stairs. \n" +
            "Enter the LAUNDRY ROOM or the LIVING ROOM.\n\n",
            new List<string> { "laundry room", "living room" }
            ); 
        public static Room laundryRoom = new Room(                                              // How do I pick up an item?
            "\n\n\n\n\nYou found a piece of paper with the numbers 8520 on it. Find the safe and escape! \n" +
            "Go back UP STAIRS or go into the LIVING ROOM\n\n",
            new List<string> { "up stairs", "living room" },
            new List<string> { "safecode" }
            );

        // Option 3: Living Room
        public static Room livingRoom = new Room(
            "\n\n\n\n\nYou took your chances and it seems to have paid off. \n" +
            "Pick up the PHONE and call for help or go to the KITCHEN or LAUNDRY ROOM. \n\n",
            new List<string> { "phone", "kitchen", "laundry room" }
            );
        public static Room phone = new Room(
            "\n\n\n\n\nOw! the phone has been rigged with a needle in the ear piece! \n" +
            "Go to the KITCHEN or LAUNDRY ROOM. \n\n",
            new List<string> { "kitchen", "laundry room" }
            );
            Room currentRoom = frontDoor;

        public void Run()
        {
            if (currentRoom == frontDoor)
            {

            }

            Console.Clear();
            Console.WriteLine("You've got debt up to your ears, you're out of time \n" +
                "and you are flat broke. But you just broke into the wrong home.\n\n" +
                "There is a masked psychopath terrorizing the family who lives in this house. \n" +
                "Keep your wits about you and don't punk out. Find the combination \n" +
                "to the safe, find the safe and escape while dodging all of the traps.");

            bool alive = true;
            while (alive)
            {
                string command = Console.ReadLine().ToLower();
                Console.Clear();

                Console.WriteLine(currentRoom.Splash);

                if (command.StartsWith("go "))
                {
                    if (command.Contains("front door"))
                    {
                        currentRoom = frontDoor;
                    }
                    else if (command.Contains("dining room"))
                    {
                        currentRoom = diningRoom;
                    }
                    else if (command.Contains("up stairs"))
                    {
                        currentRoom = upStairs;
                    } 
                    else if (command.Contains("living room"))
                    {
                        currentRoom = livingRoom;
                    }
                    else if (command.Contains("table"))
                    {
                        currentRoom = table;
                    }
                    else if (command.Contains("kitchen"))
                    {
                        currentRoom = kitchen;
                    }
                    else if (command.Contains("loft"))
                    {
                        currentRoom = loft;
                    }
                    else if (command.Contains("master"))
                    {
                        currentRoom = master;
                    }
                    else if (command.Contains("down stairs"))
                    {
                        currentRoom = downStairs;
                    }
                    else if (command.Contains("laundry"))
                    {
                        currentRoom = laundryRoom;
                    }
                    else if (command.Contains("window"))
                    {
                        currentRoom = window;
                    }
                    else if (command.Contains("phone"))
                    {
                        currentRoom = phone;
                    }
                    else
                    {
                        Console.WriteLine("Are you trying to get boxed up? Try again, genius.");
                    }
                }
                else
                {
                    Console.WriteLine("It's going to be a bloodbath if you don't pull youself together.");
                }
            }
        }

        public void Inventory()
        {
            if (currentRoom == kitchen)
            {
                Console.WriteLine(kitchen.Splash);
                
            }
        }
    }
}
