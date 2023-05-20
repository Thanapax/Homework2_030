class program
{
    static void Main(string[] args)
    {
        bool x = true;
        while (x)
        {
            Console.WriteLine("------------------------------");

            Console.Write("pls input +/- : ");
            string how = Console.ReadLine();

            Console.WriteLine("------------------------------");

            if (how == "+" || how == "-")
            {
                Console.Write("pls input row : ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("pls input col : ");
                int col = int.Parse(Console.ReadLine());
                float[,] set1 = new float[row, col];
                float[,] set2 = new float[row, col];

                Console.WriteLine("------------------------------");

                for (int i = 0; i <= (row - 1); i++)
                {
                    for (int j = 0; j <= (col - 1); j++)
                    {
                        Console.Write("pls input num set1 : ");
                        set1[i, j] = float.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("------------------------------");

                for (int i = 0; i <= (row - 1); i++)
                {
                    for (int j = 0; j <= (col - 1); j++)
                    {
                        Console.Write("pls input num set2 : ");
                        set2[i, j] = float.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("------------------------------");

                if (how == "+")
                {
                    for (int i = 0; i <= (row - 1); i++)
                    {
                        for (int j = 0; j <= (col - 1); j++)
                        {
                            Console.Write(" {0} ", set1[i, j] + set2[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (how == "-")
                {
                    for (int i = 0; i <= (row - 1); i++)
                    {
                        for (int j = 0; j <= (col - 1); j++)
                        {
                            Console.Write(" {0} ", set1[i, j] - set2[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                x = false;
            }
        }
    }
}