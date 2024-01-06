using TrilhaNetPooDdesafio.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("╔══════════════════════════════════════════════════════╗");
        Console.WriteLine("║                Smartphone Nokia                      ║");
        Console.WriteLine("╠══════════════════════════════════════════════════════╣");

        Nokia nokia = new Nokia(numero: "55992345897", modelo: "Nokia G60", imei: "356926092796388", memoria: 256);
        
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Waze");

        Console.WriteLine("╚══════════════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("╔══════════════════════════════════════════════════════╗");
        Console.WriteLine("║                Smartphone iPhone                     ║");
        Console.WriteLine("╠══════════════════════════════════════════════════════╣");

        Iphone iphone = new Iphone(numero: "55997843574", modelo: "iPhone 15 Pro Max", imei: "356728118819636", memoria: 512);
        
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Spotify");

        Console.WriteLine("╚══════════════════════════════════════════════════════╝");

        Console.ResetColor();
    }
}