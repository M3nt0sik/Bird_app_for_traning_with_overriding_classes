using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIrd_app_for_traning_with_overriding_classes
{
    internal class Bird
    {
        public static Random Randomizer = new Random();
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Metoda Bird.LayEggs nie powinna być wywoływana");4
            return new Egg[0];
        }

    }
}
