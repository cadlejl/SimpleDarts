using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThrowDart;

namespace SimpleDarts
{
    public class Score
    {
        public int HitScore { get; set; }

        public Score()
        {
            this.HitScore = 0;
        }

        public void CalculateScore(Dart dart)
        {
            if (dart.Bullseye == true)
            {
                if (dart.Ring == "inner") HitScore = 50;
                else if (dart.Ring == "outer") HitScore = 25;
                else throw new Exception();
            }
            else if (dart.Bullseye == false)
            {
                if (!(dart.HitSection > 0)) throw new Exception();
                if (dart.Ring == "inner") HitScore = (dart.HitSection * 3);
                else if (dart.Ring == "outer") HitScore = (dart.HitSection * 2);
                else HitScore = dart.HitSection;
            }
        }
    }
}