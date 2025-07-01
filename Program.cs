using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "192645387", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Nubank");

        Console.WriteLine();

        Smartphone iphone = new Iphone("987654321", "iPhone 15", "954382617", 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");

        
        Console.WriteLine($"\nNúmero do Nokia: {nokia.Numero}");
        Console.WriteLine($"Número do iPhone: {iphone.Numero}");
    }
}