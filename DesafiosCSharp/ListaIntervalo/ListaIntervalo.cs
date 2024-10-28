using IntervaloC = Intervalo.Intervalo;


namespace ListaIntervalo
{
    internal class ListaIntervalo
    {
        private List<IntervaloC> listInter;

        public IReadOnlyList<IntervaloC> Intervalos { 
            get
            {

                listInter.Sort((i, i2) => i.Inicio.CompareTo(i2.Inicio));
                return listInter.AsReadOnly();
            }
        }

        public void Add(IntervaloC inter)
        {
            bool temIntersecao = false;

            foreach (IntervaloC c in Intervalos) { 
                if(c.TemIntersecao(inter))
                    temIntersecao = true;
            }

            if (!temIntersecao) { 
                listInter.Add(inter);
            }   

        }
    }
}
