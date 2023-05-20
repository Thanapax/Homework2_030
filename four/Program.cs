class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.Write("pls input road block : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("pls input road span : ");
        int k = int.Parse(Console.ReadLine());

        int[] block = new int[n];
        Console.WriteLine();
        Console.WriteLine("block : {0} and span : {1} ", n, k);
        Console.WriteLine("----------------------------------------------------");
        int x = 0, y = 0;

        if (n >= 1 && n <= 10000 || k >= 1 && k <= 100)
        {

            for (int i = 0; i < n; i++)
            {
                Console.Write("Number of people in each road block {0} : ", i + 1);
                block[i] = int.Parse(Console.ReadLine());
            }
            for (int j = k; j < (n - k); j++)
            {
                x = block[j];
                for (int i = 1; i <= k; i++)
                {
                    x = x + block[j - i] + block[j + i];
                    y = Max(x, y);
                }
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("result : {0}", y);
            Console.WriteLine("----------------------------------------------------");
        }
    }
    static int Max(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        return y;
    }
}