using BancoPOO;


Funcionario funcionarioObj = Funcionario.CriarPreencherFuncionario();
funcionarioObj.Imprimir();

// funcionario1.Preencher();
// funcionario1.Imprimir();


Cliente clienteObj = Cliente.CriarPreencherCliente();
clienteObj.Imprimir();

// cliente1.Preencher();
// cliente1.Imprimir();

Cliente clienteObj2 = Cliente.CriarPreencherCliente();
clienteObj2.Imprimir();

// cliente2.Preencher();
// cliente2.Imprimir();



// exemplo de uso de polimorfismo
List<Pessoa> pessoas = new List<Pessoa>();

pessoas.Add(clienteObj);
pessoas.Add(clienteObj2);
pessoas.Add(funcionarioObj);

Pessoa pessoaCliente = clienteObj;
Pessoa pessoaFuncionaria = funcionarioObj;

Cliente cliente2 = (Cliente)pessoaCliente;

Console.WriteLine($"Endereço de cliente recuperado é: {cliente2.Endereco}");
Console.WriteLine($"Matrícula do funcionário é: {((Funcionario)pessoaFuncionaria).Codigo}");

foreach (var pessoa in pessoas)
{
    pessoa.Imprimir();
    if (pessoa.GetType() == typeof(Cliente))
    {
        Console.WriteLine($"{pessoa.Nome} é um cliente e tem o endereço {((Cliente)pessoa).Endereco}");
        
    } else
    {
        Console.WriteLine($"{pessoa.Nome} não é um cliente, é um funcionário, e tem o código {((Funcionario)pessoa).Codigo}");
    }
}




// retomando o sistema bancário
var conta1 = new Conta(clienteObj, funcionarioObj);

conta1.Depositar(1000);
conta1.Sacar(500);
conta1.ImprimirExtrato();


var conta2 = new Conta(clienteObj2, funcionarioObj);

conta2.Depositar(2000);
conta2.Sacar(500);
conta2.ImprimirExtrato();


var saldoConta1 = conta1.ObterSaldo();
Console.WriteLine($"O saldo da conta de {conta1.Titular.Nome} é igual a {saldoConta1}");

conta1.Depositar(5000);
conta1.ImprimirExtrato();
