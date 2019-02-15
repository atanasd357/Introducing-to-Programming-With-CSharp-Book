using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace AdvertisingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] praisePhrase = {"The product is excellent.", "This is a great product.",
                "I constantly use this product.", "This is the best product in this category." };

            string[] praiseEvents = {"I already feel good.", "I managed to change.", "He did a miracle.",
            "I can't believe it, but i feel great already.", "Try it too. I'm very pleased."};

            string[] firstName = { "Diana", "Petya", "Stela", "Elena", "Katya" };

            string[] lastName = { "Ivanova", "Petrova", "Kirova" };

            string[] town = { "Sofia", "Plovdiv", "Varna", "Ruse", "Burgas" };

            Random rand = new Random();

            Console.WriteLine("{0} {1} - {2} {3}, {4}", praisePhrase[rand.Next(praisePhrase.Length)],
                praiseEvents[rand.Next(praiseEvents.Length)], firstName[rand.Next(firstName.Length)],
                lastName[rand.Next(lastName.Length)], town[rand.Next(town.Length)]);    
        }
    }
}
