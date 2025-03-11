class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("podaj liczbe a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("podaj liczbe b ");
        int b = int.Parse(Console.ReadLine());

       if (a == b)
        {
            Console.WriteLine(a);

        }

        if (a > b)
        {
            a /= a - b;
            Console.WriteLine(a);
        }
        else
        {
            b /= b - a;
            Console.WriteLine(b);
        }
        
    }
}