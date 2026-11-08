using System.Numerics; // Required for BigInteger
class Program
{

    public static BigInteger Fact(BigInteger n)
    {
        BigInteger res = 1;
        for(BigInteger i = 1; i <= n;++i)
            res *= i;
        return res;
    }
    public static void Main(string[] args)
    {
        try {
            while(true)
            {
                Console.WriteLine("Введите положительное число или {exit/quit}: ");
                string? input = Console.ReadLine();
                if(input is null)
                {
                    throw new Exception("Лажу ввел - Ошибка (критическая)");
                }

                if(input == "quit" || input == "exit")
                    break;

                BigInteger num = 0;
                if (BigInteger.TryParse(input, out num))
                {
                    if(num <= 0)
                    {
                        Console.WriteLine("Нужно положительное число, давай еще раз");
                    }

                    Console.WriteLine($"Факториал: {Fact(num)}");

                }
                else
                {
                    Console.WriteLine("Не число, давай еще раз");
                }
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}