using ProjetoVertice;

namespace Poligono
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Vertice> lv = new List<Vertice>();
            lv.Add(new Vertice(0,0));
            lv.Add(new Vertice(4,0));
            lv.Add(new Vertice(4, 4));
            lv.Add(new Vertice(0, 4));
            Poligono p = new Poligono(lv);
            Console.WriteLine(p.CalculaPerimetro());
        }
    }
}
