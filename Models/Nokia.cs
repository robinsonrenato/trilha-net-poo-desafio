namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI) : base(numero, modelo, iMEI)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando App {nomeApp} no Smartphone Nokia");
        }
    }
}