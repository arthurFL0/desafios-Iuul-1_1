
namespace CertidaoNascimento
{
    internal class Pessoa
    {


        public string Nome { get; }
        public Certidao? Certidao { get; set; }

    

        public Pessoa(string nome)
        {
            Nome = nome ?? throw new ArgumentNullException("Uma pessoa precisa ter nome.");
        }
    }
}
