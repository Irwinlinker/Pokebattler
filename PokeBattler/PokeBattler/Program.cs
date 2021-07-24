//Robert Marsh
//Program simulates simple Pokemon battle


using System;

namespace PokeBattler
{
    class Program
    {
        static void Main(string[] args)
        {
            //create pokeman objects
            Pokeman pokeman1 = new Pokeman("Pikachu", 35, "Charge", "Thunderbolt", 15, 15);
            Pokeman pokeman2 = new Pokeman("Charmander", 50, "Bite", "Flamethrower", 10, 15);

            //get trainer names
            Console.Write("Enter Trainer 1 name: ");
            string trainer1 = Console.ReadLine();
            Console.Write("Enter Trainer 2 name: ");
            string trainer2 = Console.ReadLine();
            Console.WriteLine("\n");
            //toss out pokeman
            Console.WriteLine(trainer1 + " chooses " + pokeman1.name + "!");
            Console.WriteLine("\n");
            Console.WriteLine(trainer2 + " chooses " + pokeman2.name + "!");
            Console.WriteLine("\n");

            //while loop for battle
            while (pokeman1.hp > 0 && pokeman2.hp > 0)
            {

                //second pokeman attacks first
                pokeman1.hp -= pokeman2.Attack(pokeman2.name);

                //check for fainted pokeman and declare winner
                if (pokeman1.hp <= 0)
                {
                    //Console.WriteLine(pokeman1.hp + " " + pokeman2.hp);
                    Console.WriteLine(pokeman1.name + " fainted. " + trainer2 + " and " + pokeman2.name + " win!");
                    break;
                }

                //first pokeman attacks
                pokeman2.hp -= pokeman1.Attack(pokeman1.name);

                //check for fainted pokeman and declare winner
                if (pokeman2.hp <= 0)
                {
                    //Console.WriteLine(pokeman1.hp + " " + pokeman2.hp);
                    Console.WriteLine(pokeman2.name + " fainted. " + trainer1 + " and " + pokeman1.name + " win!");
                    break;
                }

            }
        }
    }
}
