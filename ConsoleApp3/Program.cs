namespace homweworkN3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task N1

            Console.WriteLine("sheiyvanet teqsti:");
            string input = Console.ReadLine();

            int vowelCount = 0;

            foreach (char c in input)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine("xmovnebis raodenoba: " + vowelCount);



           // task N2

            //gamravlebis tabula
            Console.Write("sheiyvanet ricxvi: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * num);
            }

            //Task N3(

            int[,] mat1 = new int[3, 3];
            int[,] mat2 = new int[3, 3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.WriteLine("sheiyvanet matricis mnishvneloba");
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("sheiyvanet meore matricis mnishvneloba");
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                    mat2[i, j] = mat1[i, j] + mat2[i, j];

                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine(" ");


            }


            //task N4

            {
                bool keepRunning = true;

                while (keepRunning)
                {
                    Console.WriteLine("Calculator Menu:");
                    Console.WriteLine("1) mimateba");
                    Console.WriteLine("2) gamokleba");
                    Console.WriteLine("3) gamravleba");
                    Console.WriteLine("4) gayofa");
                    Console.WriteLine("5) gatishva");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();

                    if (choice == "5")
                    {
                        Console.WriteLine("kalkulatori gaitisha");
                        keepRunning = false;
                        continue;
                    }

                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    if (choice == "1")
                    {
                        result = num1 + num2;
                        Console.WriteLine("shedegi: " + result);
                    }
                    else if (choice == "2")
                    {
                        result = num1 - num2;
                        Console.WriteLine("shedegi: " + result);
                    }
                    else if (choice == "3")
                    {
                        result = num1 * num2;
                        Console.WriteLine("shedegi: " + result);
                    }
                    else if (choice == "4")
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine("shedegi: " + result);
                        }
                    }
                    else
                    {
                        Console.WriteLine("araswori inputi");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}






