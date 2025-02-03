using System;

class PatternDrawing
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n🌟 Welcome to the C# Pattern Drawing Program!");
            Console.WriteLine("Choose a pattern type:");
            Console.WriteLine("1. Right-angled Triangle");
            Console.WriteLine("2. Square with Hollow Center");
            Console.WriteLine("3. Diamond");
            Console.WriteLine("4. Left-angled Triangle");
            Console.WriteLine("5. Hollow Square");
            Console.WriteLine("6. Pyramid");
            Console.WriteLine("7. Reverse Pyramid");
            Console.WriteLine("8. Rectangle with Hollow Center");

            Console.Write("Enter the number corresponding to your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 8)
            {
                Console.WriteLine("❌ Invalid choice! Please restart the program.");
                continue;
            }

            int rows = 0, width = 0, height = 0;
            if (choice >= 1 && choice <= 7)
            {
                Console.Write("Enter the number of rows: ");
                if (!int.TryParse(Console.ReadLine(), out rows) || rows < 1)
                {
                    Console.WriteLine("❌ Invalid input! Restarting...");
                    continue;
                }
            }
            else if (choice == 8)
            {
                Console.Write("Enter width: ");
                if (!int.TryParse(Console.ReadLine(), out width) || width < 1)
                {
                    Console.WriteLine("❌ Invalid input! Restarting...");
                    continue;
                }
                Console.Write("Enter height: ");
                if (!int.TryParse(Console.ReadLine(), out height) || height < 1)
                {
                    Console.WriteLine("❌ Invalid input! Restarting...");
                    continue;
                }
            }

            switch (choice)
            {
                case 1:
                    for (int i = 1; i <= rows; i++)
                        Console.WriteLine(new string('*', i));
                    break;

                case 2:
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (i == 0 || i == rows - 1 || j == 0 || j == rows - 1)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int i = 1; i <= rows; i++)
                        Console.WriteLine(new string(' ', rows - i) + new string('*', 2 * i - 1));
                    for (int i = rows - 1; i >= 1; i--)
                        Console.WriteLine(new string(' ', rows - i) + new string('*', 2 * i - 1));
                    break;

                case 4:
                    for (int i = 1; i <= rows; i++)
                        Console.WriteLine(new string(' ', rows - i) + new string('*', i));
                    break;

                case 5:
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (i == 0 || i == rows - 1 || j == 0 || j == rows - 1)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 6:
                    for (int i = 1; i <= rows; i++)
                        Console.WriteLine(new string(' ', rows - i) + new string('*', 2 * i - 1));
                    break;

                case 7:
                    for (int i = rows; i >= 1; i--)
                        Console.WriteLine(new string(' ', rows - i) + new string('*', 2 * i - 1));
                    break;

                case 8:
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }

            Console.WriteLine("\nDo you want to restart the program? (y/n)");
            if (Console.ReadLine().ToLower() != "y")
                break;
        }
    }
}
