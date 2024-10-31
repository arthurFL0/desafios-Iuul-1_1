
namespace CertidaoNascimento
{
    internal class Certidao
    {
        public Pessoa Pessoa { get; }
        public DateTime DataEmissao {  get; }

        public Certidao(DateTime data, Pessoa p) {
            Pessoa Pessoa = p ?? throw new ArgumentNullException("Uma certidão precisa estar associada a uma pessoa");

            if(data == DateTime.MinValue) 
                 throw new ArgumentNullException("Uma certidão precisa ter uma data de Emissao");

            DataEmissao = data;

            p.Certidao = this;
        }
    }
}
