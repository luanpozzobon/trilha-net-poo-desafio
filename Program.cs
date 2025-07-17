using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia("11", "Tijolão", "2023256245", 4);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Gmail");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("21", "X", "2025975763", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Gmail");