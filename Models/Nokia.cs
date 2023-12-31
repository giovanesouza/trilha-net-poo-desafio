namespace DesafioPOO.Models
{
    // Nokia herda tudo da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor herdado do pai
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Método herdado e sobrescrito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"📲 Instalando o aplicativo '{nomeApp}' no Nokia.");
        }
    }
}