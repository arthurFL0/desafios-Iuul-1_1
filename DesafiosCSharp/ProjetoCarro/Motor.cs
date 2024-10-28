
namespace ProjetoCarro
{


    internal class Motor
    {
        public Carro ?Carro { get; set; }
        public double Cilindrada { get; }

        public Motor(Carro carro, double cilindrada)
        {
            Carro = carro;
            Cilindrada = cilindrada;
        }

        public Motor(double cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }
}
