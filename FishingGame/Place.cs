using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    internal class Place
    {
        public List<Fish> pbox = new List<Fish>();

        public Place()
        {
            FishList fl = new FishList();
            for(int i = 0; i < 5; i++)
            {
                pbox.Add(fl.RondomFish());
            }
        }

        public Fish GetFish(int index)
        {
            return pbox[index];
        }

        public int NumOfPlaces()
        {
            return pbox.Count;
        }

        public void Test()
        {
            Console.WriteLine($"場所の数:{NumOfPlaces()}");
            for(int i = 0; i < NumOfPlaces(); i++)
            {
                Console.WriteLine(GetFish(i));
            }
        }
    }
}
