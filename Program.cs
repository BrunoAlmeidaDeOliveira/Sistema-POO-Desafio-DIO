using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

Iphone Celular1 = new Iphone("8429042", "G21", "Iphone14", 16);  

Nokia Celular2 = new Nokia("45623922", "G21", "93228432", 16);

Console.WriteLine("Iphone: ");

Celular1.Ligar();

Celular1.ReceberLigacao();

Celular1.InstalarAplicativo("Whatsapp");

Console.WriteLine("-------------------------------------");

Console.WriteLine("Nokia: ");

Celular2.Ligar();

Celular2.ReceberLigacao();

Celular2.InstalarAplicativo("Telegram");