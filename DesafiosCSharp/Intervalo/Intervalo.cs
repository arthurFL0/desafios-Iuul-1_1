using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ListaIntervalo")]

namespace Intervalo
{
    internal class Intervalo
    {
        public DateTime Inicio { get; }
        public DateTime Fim { get; }

        public TimeSpan Duracao { 
            get 
            {
                return Fim - Inicio;
            } 
        }

        public Intervalo(DateTime inicio, DateTime fim)
        {
            Inicio = inicio;
            Fim = fim;
        }

        public bool TemIntersecao(Intervalo inter)
        {
            if(inter.Inicio < Fim && inter.Fim > Inicio)
            {
                return true;
            }

            return false;
        }

        public bool ehIgual(Intervalo inter)
        {
            if(inter.Inicio.CompareTo(Inicio) == 0 && inter.Fim.CompareTo(Fim) == 0)
            {
                return true;
            }

            return false;
        }
    }
}
