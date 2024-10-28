using static System.Math;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Triangulo")]
[assembly: InternalsVisibleTo("Poligono")]

namespace ProjetoVertice
{


    internal class Vertice
    {
        private float _X;
        private float _Y;

        public float X
        {
            get { return _X; }
        }

        public float Y
        {
            get { return _Y; }
        }

        public Vertice(float X, float Y) { 
            this._X = X;
            this._Y = Y;
        }

        public double Distancia(Vertice V)
        {
            return Sqrt(Pow(V.X - this._X,2) + Pow(V.Y - this._Y, 2)) ;
        }

        public void Move(float X, float Y)
        {
            this._X = X;
            this._Y = Y;
        }

        public bool ehIgual(Vertice V) {
            return this.Distancia(V) == 0;    
        }

    }
}
