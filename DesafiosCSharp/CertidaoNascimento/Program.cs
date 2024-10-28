namespace CertidaoNascimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa p = new Pessoa("Joao");
                Certidao c = new Certidao(DateTime.Now, p);
                Console.WriteLine($"{p.Nome} nasceu em {c.DataEmissao}");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
