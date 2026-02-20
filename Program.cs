internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("input operation:");
        System.Console.WriteLine("1: +, 2: -, 3: *, 4: /");
        int inp = int.Parse(Console.ReadLine()); 
        while(inp != 0)
        {
            if (inp == 1)
            {
                int a1 = int.Parse(Console.ReadLine()); 
                int b1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine(a1 + b1);
            }
            else if (inp == 2)
            {
                int a2 = int.Parse(Console.ReadLine()); 
                int b2 = int.Parse(Console.ReadLine());
                System.Console.WriteLine(a2 - b2);
            }
            else if (inp == 3)
            {
                int a3 = int.Parse(Console.ReadLine()); 
                int b3 = int.Parse(Console.ReadLine());
                System.Console.WriteLine(a3 * b3);
            }
        }
        
        //int a = int.Parse(Console.ReadLine()); 
        //int b = int.Parse(Console.ReadLine());
        //System.Console.WriteLine(a + b);
    }
}