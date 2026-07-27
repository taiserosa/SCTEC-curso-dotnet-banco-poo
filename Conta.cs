namespace BancoPOO
{
    public class Conta
    {
        // atributos
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        private decimal saldo;
        private List<Transacao> transacoes = new List<Transacao>();

        // construtores
        public Conta()
        {
        }
        public Conta(string titular)
        {
            NumeroConta = new Random().Next();
            Titular = titular;
        }

        // métodos
        public void Depositar(decimal valor)
        {
            transacoes.Add(new Transacao (valor, "Depósito"));
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficientepara saque!");
            } else
            {
                Transacao saque = new Transacao(valor, "Saque");
                transacoes.Add(saque);
                saldo -= valor;
            }
        } 

        public decimal ObterSaldo()
        {
            return saldo;
        }
        public void ImprimirTransacoes()
        {
            Console.WriteLine("Transações: ");
            foreach(var transacao in transacoes)
            {
                transacao.ImprimirTransacao();
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Saldo: {saldo}");
            ImprimirTransacoes();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
