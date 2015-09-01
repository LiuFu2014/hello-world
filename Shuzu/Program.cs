using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuzu
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    #region MyRegion
        //    //// Two-dimensional array.
        //    //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        //    //// The same array with dimensions specified.
        //    //int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        //    //// A similar array with string elements.
        //    //string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
        //    //                            { "five", "six" } };

        //    //// Three-dimensional array.
        //    //int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
        //    //                     { { 7, 8, 9 }, { 10, 11, 12 } } };
        //    //// The same array with dimensions specified.
        //    //int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
        //    //                           { { 7, 8, 9 }, { 10, 11, 12 } } };

        //    //// Accessing array elements.
        //    //Console.WriteLine(array2D[0, 0]);
        //    //System.Console.WriteLine(array2D[0, 1]);
        //    //System.Console.WriteLine(array2D[1, 0]);
        //    //System.Console.WriteLine(array2D[1, 1]);
        //    //System.Console.WriteLine(array2D[3, 0]);
        //    //System.Console.WriteLine(array2Db[1, 0]);
        //    //Console.WriteLine(array3Da[1, 0, 1]);
        //    //Console.WriteLine(array3D[1, 1, 2]);
        //    //Console.Read(); 
        //    #endregion

        //    #region MyRegion

        //    int[][] a =
        //    {
        //        new int[2]{1,2 },
        //        new int [3] {3,2,1}
        //    };

        //    Test(a);

        //    Console.WriteLine(a[1][1]);
        //    Console.Read();

        //    #endregion

        //}

        //public static void Test(int[][] a)
        //{
        //    Console.WriteLine(a[1][1]);
        //    a[1][1] = 10;
        //}

            /// <summary>
            /// 闲的蛋疼！！！
            /// </summary>
            /// <param name="args"></param>
        static void Main(string[] args)
        {
            //string a = "12312|324|54|";
            //string[] aa = a.Split('|');
            
            var reserveSomeRam = new byte[1024 * 1024 * 100];
            Console.WriteLine("{0:u} - Building a bigHeapOGuids.", DateTime.Now);
            // Fill up memory with guids.   
            var bigHeapOGuids = new HashSet<Guid>();
            try
            {
                do
                {
                    bigHeapOGuids.Add(Guid.NewGuid());
                }
                while (true);
            }
            catch (OutOfMemoryException)
            {
                // Release the ram we allocated up front.             
                GC.KeepAlive(reserveSomeRam);
                GC.Collect();
            }
            Console.WriteLine("{0:u} - Built bigHeapOGuids, contains {1} of them.", DateTime.Now, bigHeapOGuids.LongCount());
            // Spool up some threads to keep checking if there's a match.         
            // Keep running until the heat death of the universe.          
            for (long k = 0; k < Int64.MaxValue; k++)
            {
                for (long j = 0; j < Int64.MaxValue; j++)
                {
                    Console.WriteLine("{0:u} - Looking for collisions with {1} thread(s)....", DateTime.Now, Environment.ProcessorCount);
                    System.Threading.Tasks.Parallel.For(0, Int32.MaxValue, (i) =>
                    {
                        if (bigHeapOGuids.Contains(Guid.NewGuid()))
                            throw new ApplicationException("Guids collided! Oh my gosh!");
                    });
                    Console.WriteLine("{0:u} - That was another {1} attempts without a collision.", DateTime.Now, ((long)Int32.MaxValue) * Environment.ProcessorCount);
                }
            }
            Console.WriteLine("Umm... why hasn't the universe ended yet?");
        }

    }
}
