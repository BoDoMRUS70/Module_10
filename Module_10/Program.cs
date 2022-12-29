namespace Module_10

{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            CalculateSum calculateSum = new CalculateSum(Logger);
            int a, b;
            try
            {
                Console.WriteLine("Введите число:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                b = Convert.ToInt32(Console.ReadLine());

                var result = ((ISum)calculateSum).Sum(a, b);
                Console.WriteLine("Результат:" + result);
            }
            catch (Exception ex)
            {
                Logger.Error("Исключение:"); 
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
