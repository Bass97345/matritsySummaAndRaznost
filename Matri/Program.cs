namespace Matri
{
    internal class Program
    {
        static void Main()
        {

            Program program = new Program();
            Random rnd = new Random();

            Console.WriteLine("Введите размерность матрицы");
            string N = Console.ReadLine();

            while (program.examForInvalid(N) == false || (int.Parse(N) < 0))
            {
                if (program.examForInvalid(N) && int.Parse(N) < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Длина массива не может быть отрицательной!");
                    Console.ResetColor();
                }
                N = Console.ReadLine();
            }


            Console.WriteLine("Введите начало диапозона:");
            string min = Console.ReadLine();

            while (program.examForInvalid(min) == false)
            {
                min = Console.ReadLine();
            }


            Console.WriteLine("Введите конец диапозона:");
            string max = Console.ReadLine();

            while (program.examForInvalid(max) == false || int.Parse(max) < int.Parse(min))
            {
                if (program.examForInvalid(N) && int.Parse(max) < int.Parse(min))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Конец диапозона не может быть меньше начала");
                    Console.ResetColor();
                }
                max = Console.ReadLine();
            }


            int[,] A = new int[int.Parse(N), int.Parse(N)];
            int[,] B = new int[int.Parse(N), int.Parse(N)];
            int[,] sum = new int[int.Parse(N), int.Parse(N)];
            int[,] raz = new int[int.Parse(N), int.Parse(N)];

            Console.WriteLine("Ваш массив A");
            
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(int.Parse(min), int.Parse(max)+1);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ваш массив B");

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rnd.Next(int.Parse(min), int.Parse(max)+1);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Результат сложения:");

            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = A[i, j] + B[i, j];
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Результат вычитания:");

            for (int i = 0; i < raz.GetLength(0); i++)
            {
                for (int j = 0; j < raz.GetLength(1); j++)
                {
                    raz[i, j] = A[i, j] - B[i, j];
                    Console.Write(raz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }


        public bool examForInvalid(string number)
        {
            int juk;
            if (int.TryParse(number, out juk))
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите число");
                Console.ResetColor();
                return false;
            }
        }
    }
}
