using System.Diagnostics;
namespace BigONotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch t = new Stopwatch();  
            t.Start();
            int m = fun1(1000000000);
            t.Stop();
            TimeSpan ts = t.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes,ts.Seconds,ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");
            Console.ReadLine();
            Stopwatch t2 = new Stopwatch();
            t2.Start();
            int m2 = fun2(10000);
            t2.Stop();
            ts = t2.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");


            Stopwatch t3 = new Stopwatch();
            t3.Start();
            int m3 = fun3(10000);
            t3.Stop();
            ts = t3.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");


            Stopwatch t4 = new Stopwatch();
            t4.Start();
            int m4 = fun4(100000);
            t4.Stop();
            ts = t4.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");

            Stopwatch t5 = new Stopwatch();
            t5.Start();
            int m5 = fun5(1000);
            t5.Stop();
            ts = t5.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");

            Stopwatch t6 = new Stopwatch();
            t6.Start();
            int m6 = fun6(100000);
            t6.Stop();
            ts = t6.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");

            Stopwatch t7 = new Stopwatch();
            t7.Start();
            int m7 = fun7(100000);
            t7.Stop();
            ts = t7.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");

            Stopwatch t8 = new Stopwatch();
            t8.Start();
            int m8 = fun8(1000);
            t8.Stop();
            ts = t8.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");

            Stopwatch t9 = new Stopwatch();
            t9.Start();
            int m9 = fun9(1000);
            t9.Stop();
            ts = t9.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"elapsed time = {elapsedTime}");
        }

        // data = 1000000000
        // avg time = 00:00:00.86
        // O(n)
        public static int fun1(int n)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                m++;
            }
            return m;
        }
        // data = 10000
        // avg time = 00:00:00.08
        //O(n^2)
        public static int fun2(int n)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j<n; j++)
                {
                    m++;

                }
            }
            return m;
        }

        // data = 10000
        // avg time = 00:00:00.03
        //O(n^2)
        public static int fun3(int n)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    m++;

                }
            }
            return m;
        }

        // data = 100000
        // avg time = 00:00:00.00
        // O(logn)
        public static int fun4(int n)
        {
            int m = 0;
            int i = 1;
            while( i < n)
            {
                m++;
                i *= 2;
            }
            return m;
        }

        // data = 1000
        // avg time = 00:00:00.76
        //O(n^3)
        public static int fun5(int n)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                { 
                    for (int k = 0; k < n; k++)
                    {
                        m++;

                    }
                }
            }
            return m;
        }

        // data = 100000
        // avg time = 00:00:00.06
        //O(nlogn)
        public static int fun6(int n)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < Math.Sqrt(n); j++)
                {
                    m++;

                }
            }
            return m;
        }

        // data = 100000
        // avg time = 00:00:00.00
        //O(log(n^2))
        public static int fun7(int n)
        {
            int m = 0;
            for (int i = n; i > 0; i/=2)
            {
                for (int j = 0; j < i; j++)
                {
                    m++;

                }
            }
            return m;
        }

        // data = 1000
        // avg time = 00:00:00.12
        //O(n^3)
        public static int fun8(int n)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    for (int k = j+1; k < n; k++)
                    {
                        m++;

                    }
                }
            }
            return m;
        }

        // data = 10000
        // avg time = 00:00:00.03
        //O(log(n^2))
        public static int fun9(int n)
        {
            int m = 0;
            for (int i = 1; i <= n; i*=2)
            {
                for (int j = 0; j <= i; j++)
                {
                    m++;

                }
            }
            return m;
        }
    }
}
