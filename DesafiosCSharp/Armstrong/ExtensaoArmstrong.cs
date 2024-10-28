

namespace Armstrong
{
    internal static class ExtensaoArmstrong
    {
        public static bool IsArmstrong(this int n)
        {

            int tam = 1;
            double soma = 0;
            int aux = n;

            List<int> digitos = new List<int>();

            while(aux >= 10)
            { 
                digitos.Add(aux % 10);
                aux = aux / 10;
                tam++;
            }

            if (tam > 1)
            {
                digitos.Add(aux);

                foreach (int digito in digitos)
                {
                    soma  += Math.Pow(digito, tam);
                }
            }
            else
            {
                return true;
            }
            


            return soma == n;
        }
    }
}
