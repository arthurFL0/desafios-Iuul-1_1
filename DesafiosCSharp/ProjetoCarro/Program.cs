namespace ProjetoCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Motor mt = new Motor(1.0);
                Motor mt2 = new Motor(1.6);

                Carro carro = new Carro("Uno", "KBD10A", mt);
                Console.WriteLine(carro.Modelo + " " + carro.Placa + " " +carro.Motor.Cilindrada+" "+carro.VelocidadeMaxima()+"km/h");
                carro.TrocarMotor(mt2);
                Console.WriteLine(carro.Modelo + " " + carro.Placa + " " + carro.Motor.Cilindrada + " " + carro.VelocidadeMaxima() + "km/h");
            }
            catch (TrocarMotorException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
