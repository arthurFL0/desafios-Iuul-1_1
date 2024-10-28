namespace Piramide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
            Piramide p = new Piramide(4);
            p.Desenha();

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
