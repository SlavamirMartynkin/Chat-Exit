namespace ConsoleApp6
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            /*
            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            ints.ForEach(Console.WriteLine);
            Console.WriteLine("-------------------------");
            List<int> newList =  ReverceList(ints);
            newList.ForEach(Console.WriteLine);
            */
            /*
            foreach (var x in new CustomEmumerable())
            {
                Console.WriteLine(x);
            }
            foreach (var x in new CustomEmumerable())
            {
                Console.WriteLine(x);
            }
            */
        }

        /*Используя стек инвертируйте порядок следования элементов в спиcке
        Пример списка
        List<int> ints = new List<int> {1,2,3,4,5};
        Пример результата
        {5,4,3,2,1}
        */
        public static List<int> ReverceList(List<int> ints)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int i in ints)
            {
                stack.Push(i);
            }

            ints.Clear();
            List<int> newList = new();

            while (stack.Count > 0) 
            {
                newList.Add(stack.Pop());
            }
            return newList;
            
        }


    }
}
