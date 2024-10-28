
namespace CertidaoNascimento
{
    internal class Pessoa
    {


        public string Nome { get; }
        public Certidao? Certidao { get; }

        public Pessoa(string nome, Certidao? c) {
            Nome = nome ?? throw new ArgumentNullException("Uma pessoa precisa ter nome.");
            Certidao = c;
        }

        public Pessoa(string nome)
        {
            Nome = nome ?? throw new ArgumentNullException("Uma pessoa precisa ter nome.");
        }
    }
}
