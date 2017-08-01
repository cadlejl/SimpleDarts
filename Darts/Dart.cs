using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int HitSection { get; set; }
        public bool Bullseye { get; set; }
        public string Ring { get; set; }

        public Dart()
        {
            this.HitSection = 21;
            this.Bullseye = false;
            this.Ring = "None";
        }

        public void Throw(Random random)
        {
            HitSection = random.Next(0, 21); // 0 = bullseye

            // 1 = inner ring (5% chance); 2 = outer ring (5% chance);
            // If bullseye [50% / 50% chance]:
            // (1 -> 10) inner ring *OR* (11 -> 20) = outer ring
            int ringNumber = random.Next(1, 21);

            if (HitSection > 0)
            {
                if (ringNumber == 1) Ring = "inner";
                if (ringNumber == 2) Ring = "outer";
            }
            else if (HitSection == 0)
            {
                Bullseye = true;
                if (ringNumber <= 10) Ring = "inner";
                else Ring = "outer";
            }
        }
    }
}
