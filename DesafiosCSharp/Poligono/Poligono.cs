using ProjetoVertice;

namespace Poligono
{
    internal class Poligono
    {
        List<Vertice> listaVertices = new List<Vertice>();
        private int _qtdVertices;

        public int QtdVertices { get { return _qtdVertices; } }

        public Poligono(List<Vertice> lv)
        {
            _qtdVertices = lv.Count;

            if (_qtdVertices < 3)
            {
                throw new ArgumentException("Um polígono precisa ter pelo menos 3 vértices para ser criado");
            }

            listaVertices = lv;
        }

        public bool AddVertice(Vertice v)
        {
            foreach (Vertice ve in listaVertices)
            {
                if (ve.ehIgual(v))
                {
                    return false;
                }
            }

            listaVertices.Add(v);
            return true;
        }

        public bool RemoveVertice(Vertice v)
        {
            if (QtdVertices - 1 < 3)
            {
                throw new Exception("Remoção impossibilitada do vértice pois o polígono precisa ter pelo menos 3 vértices");
            }

            int i = listaVertices.IndexOf(v);


            if (i == -1)
            {
                return false;
            }

            listaVertices.RemoveAt(listaVertices.IndexOf(v));
            return true;

        }

        public double CalculaPerimetro()
        {
            double perimetro = 0;

            for (int i = 0; i < listaVertices.Count-1; i++)
            {
         
                perimetro += listaVertices[i].Distancia(listaVertices[i + 1]);
                
            }

            perimetro += listaVertices[listaVertices.Count - 1].Distancia(listaVertices[0]);

            return perimetro;
        }
    }
}
