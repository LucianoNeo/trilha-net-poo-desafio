using DesafioPOO.Models;


Console.WriteLine("Utilizando o espertofone Iphone");
Smartphone iphone = new Iphone(numero: "41 98828-1937", modelo: "15", imei: "123456789", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("------------------------");

Console.WriteLine("Utilizando o burrofone Nokia");
Smartphone nokia = new Nokia(numero: "41 98828-1938", modelo: "Tijolo", imei: "987654321", memoria: 2);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Cobrinha");

Console.ReadLine();