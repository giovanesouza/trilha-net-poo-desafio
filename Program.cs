using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone
Console.WriteLine("*** Smartphone Nokia ***");

Smartphone nokia = new Nokia(numero: "NK086", modelo: "C2", imei: "456321741951357", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");


Console.WriteLine("*** Smartphone Iphone ***");

Smartphone iphone = new Iphone(numero: "-", modelo: "iPhone 15 Pro Max", imei: "741159632147896", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Apple Music Classical");
