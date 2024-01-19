using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"+55(67)9999-9999", modelo:"Nokia 5150", imei:"123456789", memoria:2);
nokia.InformacoesSmartphone();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("---------------------");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"+55(67)9999-9998", modelo:"Iphone 11 Pro", imei:"1111111111111", memoria:64);
iphone.InformacoesSmartphone();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DuoLingo");