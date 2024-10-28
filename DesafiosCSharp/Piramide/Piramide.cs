using static System.Console;

namespace Piramide
{
    internal class Piramide
    {
        private int _N;

        public int N { 
            get { return _N; } 
        }

        public Piramide(int N)
        {
           if(N < 1)
            {
                throw new Exception("O valor N deve ser maior ou igual a 1");
            }

            this._N = N;
        }

        public void Desenha()
        {

            for(int i = 1; i <= this.N; i++)
            {
                string txt = "";
                string txtInvertido = "";

                for(int j = 1; j <i; j++)
                {
                    txt += j;
                    txtInvertido = j + txtInvertido;
                   
                }

                string completa = txt + i + txtInvertido;


                WriteLine(completa.PadLeft(completa.Length+this.N-i));
            }
        }
    }
}
