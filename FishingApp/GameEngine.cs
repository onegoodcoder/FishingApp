using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp
{
    class GameEngine
    {
        public Fish CatchFish()
        {

            int r = GetRandomNum();

            //create a fish object the return;
            Fish fish = new Fish();

            if (r == 1) // bass
            {
                fish.FishType = "bass";
                    fish.Points = 10;
            }
            else if (r == 2)
            {
                fish.FishType = "perch";
                    fish.Points = 2;
            }
            else if (r == 3)
            {
                fish.FishType = "walleye";
                fish.Points = 20;
            }
            else if (r == 4)
            {
                fish.FishType = "sunfish";
                fish.Points = 5;
            }
            else if (r == 5)
            {
                fish.FishType = "pike";
                fish.Points = 30;
            }
            else
            {
                fish.FishType = "No fish try again ";
                fish.Points = 0;
            }


            return fish;
        }
        public int GetRandomNum()
        {

            Random num = new Random();
            int computerchoice = num.Next(1, 8);
            return computerchoice;

        }
    }
}
