using ProjetoVertice;


namespace Triangulo
{

    public enum TipoTriangulo
    {
        Equilatero,
        Isosceles,
        Escaleno
    }

    internal class Triangulo
    {
        private Vertice _V1,_V2,_V3;
        private double L1,L2,L3;


        public Vertice V1 { get { return _V1; } }
        public Vertice V2 { get { return _V2; } }
        public Vertice V3 { get { return _V3; } }
        public Triangulo(Vertice V1, Vertice V2, Vertice V3){

            calculaLados(V1,V2,V3);

            if (!ehTrianguloPossivel())
            {
                throw new Exception("Os vértices providos não formam um triângulo");
            }
            this._V1 = V1;
            this._V2 = V2;
            this._V3 = V3;

        }


        public double Perimetro
        {
            get
            {
                return L1 + L2 + L3;
            }
        }

        public double Area
        {
            get
            {
                double s = Perimetro / 2;

                double area = Math.Sqrt(s * (s - L1) * (s - L2) * (s - L3));
                return area;
            }
        }

        public TipoTriangulo Tipo
        {
            get
            {
                if (L1 == L2 && L2 == L3)
                {
                    return TipoTriangulo.Equilatero;
                }
                else if (L1 == L2 || L2 == L3 || L1 == L3)
                {
                    return TipoTriangulo.Isosceles;
                }
                else
                {
                    return TipoTriangulo.Escaleno;
                }
            }
        }


        public bool SaoIguais(Triangulo t)
        {
            double[] lados = { L1, L2, L3 };
            double[] ladosT2 = { t.L1, t.L2, t.L3 };

            Array.Sort(lados);
            Array.Sort(ladosT2);

            return lados[0] == ladosT2[0] &&
                   lados[1] == ladosT2[1] &&
                   lados[2] == ladosT2[2];
        }


        private bool ehTrianguloPossivel()
        {
            return L1 + L2 > L3 && L1 + L3 > L2 && L2 + L3 > L1;
        }

        private void calculaLados(Vertice V1, Vertice V2, Vertice V3)
        {
            L1 = V1.Distancia(V2);
            L2 = V1.Distancia(V3);
            L3 = V2.Distancia(V3);
        }



    }
}
