using System.Reflection;

using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO


Console.WriteLine("Testando Smartphone Nokia");
Nokia n1 = new Nokia("1", "Nokia1", "00001");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");


Console.WriteLine("---------------------------------------------");
Console.WriteLine("Testando Smartphone Iphone");
var i1 = new Iphone("2", "Iphone 25", "000025'");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("WhatsApp");

Console.WriteLine();
