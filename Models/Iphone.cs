namespace TrilhaNetPooDdesafio.Models;

// TODO: Herdar da classe "Smartphone"
public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
        numero = "(XX) 9XXXX - XXXX";
        modelo = "iPhone 15 Pro Max";
        imei = "955624352431";
        memoria = 512;
    }

    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine("Instalando aplicativo {0} no seu iPhone...", nomeApp);
    }
}