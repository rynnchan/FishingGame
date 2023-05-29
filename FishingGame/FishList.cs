using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    internal class FishList
    {
        private Random rnd = new Random();
        private List<Fish> box = new List<Fish>();

        public FishList()
        {
            box = new List<Fish>()
            {
                new Fish("マグロ", 100),
                new Fish("タイ", 120),
                new Fish("サケ", 80),
                new Fish("ブリ", 70),
                new Fish("イカ", 30),
                new Fish("ホタテ", 20),
                new Fish("アジ", 15),
                new Fish("メダカ", 3),
                new Fish("ゴミ", 0),
                new Fish("おじさん", -50),
            };
        }

        public Fish RondomFish()
        {
            return box[rnd.Next(box.Count)];
        }

        public static void ListTest()
        {
            FishList fl = new FishList();

            foreach (Fish f in fl.box)
            {
                Console.WriteLine(f);
            }
        }

        public static void RandTest(int num)
        {
            FishList fl = new FishList();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(fl.RondomFish());
            }
        }
    }
}
