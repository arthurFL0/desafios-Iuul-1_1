namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 1; i <= 10000; i++)
            {
                if (i.IsArmstrong())
                    Console.WriteLine(i);
                    
             }
        }
    }
}
