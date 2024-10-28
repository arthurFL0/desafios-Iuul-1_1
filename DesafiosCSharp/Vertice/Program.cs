namespace ProjetoVertice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice vertice1 = new Vertice(3.0f, 4.0f);
            Vertice vertice2 = new Vertice(6.0f, 8.0f);


            double distancia = vertice1.Distancia(vertice2);

            Console.WriteLine("A distância entre os vértices é: " + distancia);
        }
    }
}
