using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattler
{
    
    //pokeman constructor
    class Pokeman
    {
        public string name;
        public int hp;
        public string attack1;
        public string attack2;
        public int attack1Damage;
        public int attack2Damage;

        public Pokeman(string aname, int ahp, string aattack1, string aattack2, int aattack1Damage, int aattack2Damage)
        {
            name = aname;
            hp = ahp;
            attack1 = aattack1;
            attack2 = aattack2;
            attack1Damage = aattack1Damage;
            attack2Damage = aattack2Damage;
        }

        //return method for attack
        public int Attack(string aname)
        {
            string attack;
            int attackDamage;
            string name = aname;

            Random rnd = new Random();
            int num = rnd.Next(0, 2);

            if (num == 0)
            {
                attack = attack1;
                attackDamage = attack1Damage;
            }
            else
            {
                attack = attack2;
                attackDamage = attack2Damage;
            }

            Console.WriteLine(name + " used " + attack + " and it did " + attackDamage + " damage.");
            Console.WriteLine("\n");

            return attackDamage;
        }

    }
}
