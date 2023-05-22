using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIrd_app_for_traning_with_overriding_classes
{
    internal class Pigeon:Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs= new Egg[numberOfEggs];
            for(int i = 0;i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Randomizer.NextDouble);
            }
            return eggs;
        }
    }
}
