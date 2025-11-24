using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Nov21
{
     class Program
    {
        static void Main(string[] args)
        {

            GameCharacter warriorPrototype = new GameCharacter
            {
                Health = 150,
                Attack = 50,
                Defense = 40,
                Skills = new List<string> { "Slash", "Shield Block" }
            };

            GameCharacter warrior1=warriorPrototype.Clone();
            warrior1.Skills.Add("Power Strike");

            GameCharacter warrior2 = warriorPrototype.Clone();
            warrior2.Skills.Add("Battle Cry");

            Console.WriteLine("warrior 1:");
            warrior1.Show();

            Console.WriteLine("warrior 2:");
            warrior2.Show();

        }
    }
}
