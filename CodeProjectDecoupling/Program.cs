using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjectDecoupling
{
    class Program
    {
        static Random rand = new Random();
        static AppPoolWatcher alert = new AppPoolWatcher();
        public static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                int level = rand.Next(3);
                alert.Notify($"Hello there!, {i}, {level}", level);
            }



            Console.ReadKey();
        }
    }
}

