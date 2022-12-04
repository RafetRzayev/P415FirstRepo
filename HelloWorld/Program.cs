namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 100;
            //int count = 0;

            //for (int i = 3; i < n; i+=3)
            //{
            //    count++;
            //}

            //Console.WriteLine(count);

            //int n = Convert.ToInt32(Console.ReadLine());
            //string input = Console.ReadLine();
            //int n = Convert.ToInt32(input);
            //int count = 0;
            //int i = 1;
            //for (int i = 3; i < n; i += 3)
            //{
            //    count++;
            //}

            //while (i < n)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine();

            //string correctPassword = "1234";
            //string password;
            ////do
            //{
            //    Console.WriteLine("Password:");
            //    password = Console.ReadLine();

            //} while (password!=correctPassword);


            //Console.WriteLine("Password:");
            //password = Console.ReadLine();

            //while (password != correctPassword)
            //{
            //    Console.WriteLine("Password:");
            //    password = Console.ReadLine();
            //}

            //Console.WriteLine("Success");
            //int a = 4;
            //bool aIs3 = (a == 3);
            int number1, number2;
            do
            {
                Console.Write("Number1:");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number2:");
                number2 = Convert.ToInt32(Console.ReadLine());
            } while (number2 < number1);
            
            int count = 0;
            //for (int i = number1; i <= number2; i++)
            //{
            //    //if (i % 12 == 0)
            //    //{
            //    //    Console.WriteLine(i);
            //    //    count++;
            //    //}

            //    //if (i % 3 == 0 && i % 4 == 0)
            //    //    Console.WriteLine(i);

            //    //if (i % 3 == 0)
            //    //{
            //    //    if (i % 4 == 0)
            //    //    {
            //    //        Console.WriteLine(i);
            //    //    }
            //    //}
            //}
            bool isDivide4;
            bool isDivide3;
            System.Int32 x = 4;
            for (int i = number1; i <= number2; i++)
            {
                //if (i % 12 == 0)
                //{
                //    Console.WriteLine(i);
                //    count++;
                //}

                isDivide3 = i % 3 == 0;
                isDivide4 = i % 4 == 0;

                if (isDivide3 || isDivide4)
                    Console.WriteLine(i);

                //if (i % 3 == 0)
                //{
                //    Console.WriteLine(i);
                //}

                //if (i % 4 == 0)
                //{
                //    Console.WriteLine(i);
                //}
            }

        }
    }
}