
namespace ProjetoCarro
{
  

    internal class Carro
    {

        public string Modelo { get; }
        public string Placa { get; }
        public Motor Motor { get; set; }


        public Carro(string modelo, string placa, Motor motor)
        {
            Modelo = modelo;
            Placa = placa;
            Motor = motor;
        }

        public int VelocidadeMaxima()
        {
            double cil = this.Motor.Cilindrada;

            if(cil > 2.0)
            {
                return 220;
            }
            else if(cil >= 1.8)
            {
                return 200;
            }
            else if(cil >= 1.6)
            {
                return 160;
            }
            else {
                return 100;
            }
        }

        public void TrocarMotor(Motor m)
        {
            if(m.Carro == null)
            {
                Motor aux = Motor;
                Motor = m;
                m.Carro = this;
                aux.Carro = null;

            }
            else
            {
                throw new TrocarMotorException("Motor do parâmetro já está instalado em outro carro");
            }
        }
    }
}
