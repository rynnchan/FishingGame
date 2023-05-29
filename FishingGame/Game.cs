using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    internal class Game
    {
        public int Total { get; set; } = 0;
        public int Kaisu { get; set; } = 3;

        public Game()
        {
        }

        public Game(int kaisu)
        {
            Kaisu = kaisu;
        }

        public void Play()
        {
            Start();
            
            for(int i = 1; i <= Kaisu; i++)
            {
                Place place = new Place();
                //place.Test();

                Console.WriteLine("----------------------------");
                Console.WriteLine($"{i}回目のチャレンジ！");
                
                int num;
                while(true)
                {
                    try
                    {
                        Console.Write("スポット選択：0～4の半角数字を入力して選びましょう：");
                        num = int.Parse(Console.ReadLine());
                        if (num >= 0 && num <= 4) break;
                    }
                    catch (Exception)
                    {
                        //Console.WriteLine(e.Message);
                    }
                    Console.WriteLine("【エラー】入力が不正です。再度入力してください");
                }
                Console.WriteLine($"選んだスポット：{num}");
                Console.WriteLine($"釣れた魚：{place.GetFish(num)}");
                Total += place.GetFish(num).Point;

                Console.WriteLine("============================");
                Console.WriteLine($"合計点は{Total}点です！");
            }

            Finish();
        }

        private void Start()
        {
            Total = 0;
            Console.WriteLine("【釣りアプリ】");
            Console.WriteLine($"挑戦回数は{Kaisu}回！");
        }

        private void Finish()
        {
            Console.WriteLine("【ゲーム終了】");
            //Console.WriteLine($"最終得点は{Total}です！");
        }
    }
}
