using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] rastgeleSayilar = new int[10];
            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {
                rastgeleSayilar[i] = rnd.Next(1, 10);
                Console.WriteLine(rastgeleSayilar[i]);

            }
            int puan = 0;
            int puan2 = 0;


            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {
                Console.WriteLine("1. Oyuncunun Tahmini");
                int tahmin1 = Convert.ToInt32(Console.ReadLine());
                if (tahmin1 == rastgeleSayilar[i])
                {
                    puan += 10;
                }
                else 
                {
                    if (rastgeleSayilar[i] > tahmin1)
                    {
                        puan += 10 - (rastgeleSayilar[i]);

                    }
                    else
                    {
                        puan += - (tahmin1 - rastgeleSayilar[i]);

                    }


                }
                Console.Clear();


                Console.WriteLine("2. Oyuncunun Tahmini");
                int tahmin2 = Convert.ToInt32(Console.ReadLine());
                if (tahmin2 == rastgelesayilar[i])
                {

                    puan2 += 10;

                }
                else
                {
                    if (rastgelesayilar[i] > tahmin2)
                    {
                        puan2 += 10 - (rastgelesayilar[i] - tahmin2);

                    }
                    else
                    {
                        puan2 += 10 - (tahmin2 - rastgelesayilar[i]);


                    }

                    Console.ReadKey();
                  

                }
                Console.ReadKey();




            }
            Console.Clear();
            Console.WriteLine("1. Oyuncunun Puanı " + puan);
            Console.WriteLine("2. Oyuncunun Puanı " + puan2);
            Console.ReadKey();





        }
    }
}
