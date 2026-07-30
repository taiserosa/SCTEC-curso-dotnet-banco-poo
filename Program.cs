using BancoPOO;


Funcionario funcionario1 = new Funcionario();
funcionario1.PreencherFuncionario();
funcionario1.ImprimirFuncionario();


Cliente cliente1 = new Cliente();
cliente1.PreencherCliente();
cliente1.ImprimirCliente();

Cliente cliente2 = new Cliente();
cliente2.PreencherCliente();
cliente2.ImprimirCliente();



var conta1 = new Conta(cliente1, funcionario1);

conta1.Depositar(1000);
conta1.Sacar(500);
conta1.ImprimirExtrato();


var conta2 = new Conta(cliente2, funcionario1);

conta2.Depositar(2000);
conta2.Sacar(500);
conta2.ImprimirExtrato();


var saldoConta1 = conta1.ObterSaldo();
Console.WriteLine($"O saldo da conta de {conta1.Titular.Nome} é igual a {saldoConta1}");

conta1.Depositar(5000);
conta1.ImprimirExtrato();
