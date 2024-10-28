using ProjetoVertice;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var v1 = new Vertice(0, 0);
                var v2 = new Vertice(3, 0);
                var v3 = new Vertice(1.5f, 2);

                var triangulo = new Triangulo(v1, v2, v3);
                Console.WriteLine($"Área do triângulo: {triangulo.Area}");
                Console.WriteLine($"Perímetro do triângulo: {triangulo.Perimetro}");
                Console.WriteLine($"Tipo do triângulo: {triangulo.Tipo}");


                var v4 = new Vertice(0, 0);
                var v5 = new Vertice(3, 4);
                var v6 = new Vertice(6, 0);

                var triangulo2 = new Triangulo(v4, v5, v6);

                if (triangulo.SaoIguais(triangulo2))
                {
                    Console.WriteLine("Os triângulos são iguais.");
                }
                else
                {
                    Console.WriteLine("Os triângulos são diferentes.");
                }
            

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
