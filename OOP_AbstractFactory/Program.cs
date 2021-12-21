using System;

namespace AbstractFactory
{
    class Program
    {
        public static int InputCount(int topIndex)
        {
            var error = true;
            int result = 0;
            while (error)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result < topIndex && result > 0)
                    {
                        error = false;
                    }
                    else
                    {
                        Console.Write("Параметра с таким индексом не существет, повторите ввод: ");
                    }
                }
                else
                {
                    Console.Write("Вы ввели не число, попробуйте снова: ");
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            IGraphicsCardFactory factory = null;

            Console.WriteLine("СПИСОК ПРОИЗВОДИТЕЛЕЙ ВИДЕОКАРТ:\n1: MSI\n2: GIGABYTE\n3: ASUS\n4: PALIT\n");
            Console.WriteLine("СПИСОК ТИПОВ ВИДЕОКАРТ:\n1: Discrete\n2: Integrated\n");
            Console.WriteLine("Видеокарту какой фирмы вы предпочитаете?:");
            var choise = InputCount(5);
            if (choise == 1)
            {
                factory = new MSIFactory();
            }
            else if (choise == 2)
            {
                factory = new GIGABYTEFactory();
            }
            else if (choise == 3)
            {
                factory = new ASUSFactory();
            }
            else if (choise == 4)
            {
                factory = new PALITFactory();
            }
            Console.WriteLine("Видеокарту какого типы вы предпочитаете?:");
            choise = InputCount(3);
            if (choise == 1)
            {
                factory.createDiscrete();
            }
            else if (choise == 2)
            {
                factory.createIntegrated();
            }
        }
    }
}
