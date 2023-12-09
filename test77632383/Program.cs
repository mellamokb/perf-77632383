using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test77632383
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                var sw = new Stopwatch();
                sw.Start();
                var list = Loader.List;
                sw.Stop();

                Console.WriteLine($"Found {list.Count} items {sw.ElapsedMilliseconds} ms");
            }

            {
                var sw = new Stopwatch();
                sw.Start();
                var list = Loader.List;
                sw.Stop();

                Console.WriteLine($"Found {list.Count} items {sw.ElapsedMilliseconds} ms");
            }

            Console.ReadLine();
        }

    }

}
