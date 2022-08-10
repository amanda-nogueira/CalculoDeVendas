using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeVendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bpt, bpe, pm, tf, ct, br, cfp, cfg, res;

            Console.WriteLine("\tOlá, Quitutes D'Line!");

            Console.WriteLine("Quantos bolos no pote de recheio tradicional você vendeu hoje?");
            bpt = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos bolos no pote de recheio especial você vendeu hoje?");
            bpe = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos pães de mel você vendeu hoje?");
            pm = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas trufas tradicional você vendeu hoje?");
            tf = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos cones trufado você vendeu hoje?");
            ct = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos brownies recheado você vendeu hoje?");
            br = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos copos da felicidade pequeno você vendeu hoje?");
            cfp = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos copos da felicidade grande você vendeu hoje?");
            cfg = double.Parse(Console.ReadLine());

            res = ((bpt * 8) + (bpe * 10) + (pm * 4) + (tf * 3) + (ct * 8) + (br * 10) + (cfp * 15) + (cfg * 24));
           
            Console.WriteLine("O total das suas vendas hoje é {0}", res);

            if (res >= 300)
            {
                Console.WriteLine("Parabéns! Você atingiu a meta esperada.");
            }
            else
            {
                Console.WriteLine("Hoje as vendas não foram tão boas, amanhã faremos melhor!");
            }
            Console.ReadKey();
        }
    }
}
