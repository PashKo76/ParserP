namespace Парсер
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кординаты: ");
            string? str = Console.ReadLine();
            int? X = null;
            int? Y = null;
            Parser.LetsParse(str, ref X, ref Y);
            if (X == null || Y == null)
            {
                Console.WriteLine($"ПЕРЕПИСЫВАЙ");
            }
            else
            {
                Console.WriteLine($"Финальный выход {X} {Y}");
            }
            Console.ReadKey();
        }
    }
}