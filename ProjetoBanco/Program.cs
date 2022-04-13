Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

Console.WriteLine("Codigo c1: {0}", c1.Codigo);

c1.Depositar(1000.00);
c1.Sacar(200.00);
Console.WriteLine("Saldo c1: {0}", c1.Saldo);

c2.Depositar(200.00);
c2.Sacar(150.00);
Console.WriteLine("Saldo c2: {0}", c2.Saldo);

c1.Transferir(250.00, c2);
Console.WriteLine("(Transferência c1 para c2 de 250.00)");
Console.WriteLine("Saldo c1: {0}", c1.Saldo);
Console.WriteLine("Saldo c2: {0}", c2.Saldo);