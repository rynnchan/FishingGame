using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fish fish = new Fish("マグロ", 100);
            //Console.WriteLine(fish.Point);
            //Console.WriteLine(fish);

            //FishList.ListTest();
            //FishList.RandTest(11);

            //Place place = new Place();
            //place.Test();

            Game game = new Game(5);
            game.Play();
        }
    }
}
