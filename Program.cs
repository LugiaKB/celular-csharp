using DesafioPOO.Models;

Iphone i = new Iphone("40028922", "plus pro 14", "123456", "5 gb");

i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Safari");

Nokia n = new Nokia("4002", "lumia", "1234567", "2 gb");

n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Whatsapp");

// TODO: Realizar os testes com as classes Nokia e Iphone
