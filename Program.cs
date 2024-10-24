using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace text_game
{
    internal class Program
    {
       
        public static string jumpscare = "           ______\r\n        .-\"      \"-.\r\n       /            \\\r\n      |              |\r\n      |,  .-.  .-.  ,|\r\n      | )(__/  \\__)( |\r\n      |/     /\\     \\|\r\n      (_     ^^     _)\r\n       \\__|IIIIII|__/\r\n        | \\IIIIII/ |\r\n        \\          /\r\n  jgs    `--------`\r\n\r\n";
        public static System.Media.SoundPlayer background = new System.Media.SoundPlayer(@"C:\Users\s240268\Downloads\wavfile.wav");
        public static System.Media.SoundPlayer death_sound = new System.Media.SoundPlayer(@"C:\Users\s240268\Downloads\oof.wav");

        public static string AskUser(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            return response;
        }

        static void Main(string[] args)
        {
            //background.Play();

            string name = AskUser("What is your name? ");
            Console.WriteLine($"Welcome, {name}, to the haunted house");
            Console.WriteLine("You hear a banking noise from the room to your left.");
            Console.WriteLine("" +
                "a) Open the door and investigate\n" +
                "b) Escape from the window\n",
                "c) Stay still");

            string choice = AskUser("What do you do? ");
            while (!"abc".Contains(choice)) {
                choice = AskUser("Bad input. Enter either a, b, or c");
            }
            if (choice == "a")
            {
                Console.WriteLine(jumpscare);
                Console.WriteLine("A ghost has found you.");
                Console.WriteLine("" +
                    "a) Run" +
                    "b) Attack the ghost" +
                    "c) Stand still");
                choice = AskUser("What do you do? ");
                if (choice == "a")
                {
                    Console.WriteLine("You've tripped and the ghost has killed you");
                    Console.WriteLine("BAD ENDING");
                    death_sound.Play();
                }
                else if (choice == "b")
                {
                    Console.WriteLine("The ghost is too powerful for you. You're dead");
                    Console.WriteLine("BAD ENDING");
                    death_sound.Play();
                }
                else if (choice == "c")
                {
                    Console.WriteLine("You've tricked the ghost. It thinks you're not a threat");
                    Console.WriteLine("You now run for the door, and manage to escape.");
                    Console.WriteLine("GOOD ENDING");
                }
            }
            else if (choice == "b")
            {
                Console.WriteLine("You fall to your death");
                Console.WriteLine("BAD ENDING");
                death_sound.Play();
            }
            else {
                Console.WriteLine("The ghost doesn't see you as a threat.");
                Console.WriteLine("he accepts you in the haunted house and doesn't bother to attack you.");
                Console.WriteLine("GOOD ENDING");
            }
            Console.ReadLine();
        }
    }
}
