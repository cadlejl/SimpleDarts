using System;

namespace Darts
{
    public class Dart
    {
        public int HitSection { get; set; }
        public bool Bullseye { get; set; }
        public string Ring { get; set; }
        //private Random _random; // Random class instantiation needs review

        public Dart()
        {
            this.HitSection = 21;
            this.Bullseye = false;
            this.Ring = "undefined";
            // _random = new Random(); // Random class instantiation needs review
        }

        public void Throw(Random random) // Random class instantiation needs review
        {
            HitSection = random.Next(0, 21); // 0 = bullseye

            // 1 = inner ring (5% chance); 2 = outer ring (5% chance).
            // If bullseye, determine inner or outer [40% / 60% chance]:
            // (1 -> 8) inner ring *OR* (9 -> 20) = outer ring
            int ringNumber = random.Next(1, 21);

            if (HitSection > 0) SetRingProperty(1, ringNumber);
            else
            {
                Bullseye = true;
                SetRingProperty(2, ringNumber);
            }
        }

        private void SetRingProperty(int key, int ringNumber)
        {
            switch (key)
            {
                case 1:
                    if (ringNumber == 1) Ring = "inner"; // Tripple
                    if (ringNumber == 2) Ring = "outer"; // Double
                    break;
                case 2:
                    if (ringNumber <= 8) Ring = "inner"; // 50 Points
                    else Ring = "outer"; // 25 Points
                    break;
            }
        }
    }
}
