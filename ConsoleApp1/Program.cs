namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                if (int.TryParse(args[0], out int num1) && int.TryParse(args[1], out int num2)) 
                {
                    Console.WriteLine(num1+ num2);
                }              
            }
            else Console.WriteLine("введите два числа через порбел");
            
        }
    }
}
