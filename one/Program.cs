class program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("pls input num for tri : ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                int k = 1;
                for (int i = 0; i <= num; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == j)
                        {
                            k = 1;
                        }
                        else
                        {
                            k = k * (i - j + 1) / j;
                        }
                        Console.Write(k + " ");
                    }
                    Console.WriteLine("");
                }
                break;
            }
            else
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                break;
            }
        }

    }
}