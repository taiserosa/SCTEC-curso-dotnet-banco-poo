using BancoPOO;

var conta1 = new Conta("Taíse");

conta1.Depositar(400);
conta1.Sacar(100);
conta1.MostrarInfo();
conta1.ImprimirTransacoes();

var conta2 = new Conta("Tânia");

conta2.Depositar(800);
conta2.Sacar(350);
conta2.MostrarInfo();
conta2.ImprimirTransacoes();

var saldoConta1 = conta1.ObterSaldo();
Console.WriteLine($"O saldo da conta 1 é igual a {saldoConta1}");
conta1.Depositar(200);
conta1.MostrarInfo();
