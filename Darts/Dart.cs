using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public Random Random { get; set; }

        private int randomInt;
        public int RandomInt
        {
            get { return randomInt; }
            set {
                int RandomInt = Random.Next();

                if (RandomInt <= 20 || RandomInt >= 0)
                    randomInt = RandomInt;
                else
                    throw new Exception();
            }
        }
    }
}
