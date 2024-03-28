
namespace ExerciciosClasses.FabricaDeCarros.CarroEspecificacoes
{
    public class Carro
    {
        public static void CarroModelo()
        {
            var carro = new CarroEspecificacoes
            {
                Marca = "Audi",
                Modelo = "A4",
                Cilindros = "4 cilindros",
                Cilindradas = "2.0",
                VelocidadeMaxima = 220.0,
                ArranqueZeroACem = "2 segundos"
            };

            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Cilindros: {carro.Cilindros}");
            Console.WriteLine($"Cilindradas: {carro.Cilindradas}");
            Console.WriteLine($"Velocidade Maxima: {carro.VelocidadeMaxima}");
            Console.WriteLine($"Arranque Zero a Cem: {carro.ArranqueZeroACem}");
        }
    }
}