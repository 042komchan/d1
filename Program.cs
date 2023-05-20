class Program
{
    static void Main()
    {
        int rows;

        while (true)
        {
            Console.Write("Enter the number of rows (0 or greater): ");
            if (int.TryParse(Console.ReadLine(), out rows))
            {
                if (rows >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pascal's Triangle:");

        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int col)
    {
        if (col == 0 || col == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, col - 1) + CalculatePascalValue(row - 1, col);
        }
    }
}

