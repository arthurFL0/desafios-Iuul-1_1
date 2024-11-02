namespace Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt1 = DateTime.Now;
            DateTime dt2 = dt1.AddHours(2);
            Intervalo i = new Intervalo(dt1, dt2);

            DateTime dt3 = dt1.AddHours(-2);
            DateTime dt4 = dt2.AddHours(1);

            Intervalo i2 = new Intervalo(dt3, dt4);

            Console.WriteLine($"{i.Inicio} {i.Fim} | {i2.Inicio} {i2.Fim}");
            Console.WriteLine("Tem interseção? "+i.TemIntersecao(i2));
        }
    }
}
