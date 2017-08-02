using System;
using Darts;

namespace SimpleDarts
{
    public class Score
    {
        public int HitScore { get; set; }

        public Score() { this.HitScore = 0; }

        public void CalculateScore(Dart dart)
        {
            if (dart.Bullseye == false) SetHitScoreProperty(1, dart);
            else SetHitScoreProperty(2, dart);
        }

        private void SetHitScoreProperty(int key, Dart dart)
        {
            switch (key)
            {
                case 1:
                    if (dart.Ring == "inner") HitScore = (dart.HitSection * 3);
                    else if (dart.Ring == "outer") HitScore = (dart.HitSection * 2);
                    else HitScore = dart.HitSection;
                    break;
                case 2:
                    if (dart.Ring == "inner") HitScore = 50;
                    else HitScore = 25;
                    break;
            }
        }
    }
}