using System;

namespace magic_square3
{
    class hvmpb3
    {
        public int[] C;
        public int[] X;
        hvmpb3() { }
        static void kiemtra(int x, int y)
        {
            int h, k, dem = 0;
            int[] a = new int[10];
            a[1] = x;
            a[2] = y;
            a[3] = 15 - a[1] - a[2];
            a[9] = 15 - a[1] - 5;
            a[7] = 15 - a[3] - 5;
            a[8] = 15 - a[9] - a[7];
            a[4] = 15 - a[1] - a[7];
            a[6] = 15 - a[3] - a[9];
            a[5] = 5;

            for (h = 1; h <= 8; h++)
            {
                for (k = h + 1; k <= 9; k++)
                {
                    if (a[h] == a[k]) dem++;
                }
            }
            for (h = 1; h <= 9; h++)
            {
                if (a[h] < 1)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.Write("\n");
                for (h = 1; h <= 9; h++)
                {
                    Console.Write(" {0} ", a[h]);
                    if (h % 3 == 0) Console.WriteLine();
                }
                Console.Write("\n");
            }

        }
        static void Test(hvmpb3 hv, int i)
        {
            int j;
            for (j = 1; j <= 9; j++)
            {
                if (hv.C[j] == 1)
                {
                    hv.X[i] = j;
                    hv.C[j] = 0;
                    if (i == 2)
                    {
                        if (hv.X[1] + hv.X[2] < 15)
                        {
                            kiemtra(hv.X[1], hv.X[2]);
                        }
                    }
                    else Test(hv, i + 1);
                    hv.C[j] = 1;
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Nghiem bai toan hinh vuong ma phuong bac 3:");
            hvmpb3 hv = new hvmpb3();
            int i;
            int[] c = new int[10];
            int[] x = new int[10];
            for (i = 1; i <= 9; i++)
            {
                c[i] = 1;
            }
            hv.C = c;
            hv.X = x;
            Test(hv, 1);
            Console.ReadLine();
        }


    }
}