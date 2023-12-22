using TrilhaNetPooDdesafio.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Iphone iphone = new("(XX) 9XXXX - XXXX", "iPhone 15 Pro Max", "559954321321", 512);
        Nokia nokia = new("(XX) 9XXXX - XXXX", "Nokia G60 5G", "559956789789", 256);

        iphone.Ligar();
        nokia.Ligar();
        Console.WriteLine("===============");
        iphone.ReceberLigacao();
        nokia.ReceberLigacao();
        Console.WriteLine("===============");
        iphone.InstalarAplicativo("Spotify");
        nokia.InstalarAplicativo("Waze");
        Console.WriteLine("===============");
        Console.WriteLine();
    }
}