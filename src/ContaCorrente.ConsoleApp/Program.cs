namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Tiago Santini", "022.232.145-90");

            ContaCorrente contaCorrente = new ContaCorrente(1, 1200, 1000, cliente1);

            //visualização de saldo
            Console.WriteLine("R$ " + contaCorrente.ObterSaldo()); // 1200

            //saques
            contaCorrente.Sacar(200);

            Console.WriteLine("Após saque: R$ " + contaCorrente.ObterSaldo()); // 1000

            //depósitos
            contaCorrente.Depositar(400);

            Console.WriteLine("Após depósito: R$ " + contaCorrente.ObterSaldo()); // 1400

            Cliente cliente2 = new Cliente("Alexandre Rech", "013.550.822-50");

            ContaCorrente contaCorrente2 = new ContaCorrente(2, 5000, 3000, cliente2);

            #region Operações Conta 2
            Console.WriteLine("R$ " + contaCorrente2.ObterSaldo());

            // transferencia
            contaCorrente.Transferir(300, contaCorrente2);

            Console.WriteLine("Após transferência: R$ " + contaCorrente2.ObterSaldo());
            #endregion

            Console.WriteLine("\nExtrato conta 1:");

            for (int i = 0; i < contaCorrente.Historico.Length; i++)
            {
                Movimentacao movimentacao = contaCorrente.Historico[i];

                if (movimentacao != null)
                    Console.WriteLine(movimentacao.Tipo + " " + movimentacao.Valor);
            }

            Console.WriteLine("\nExtrato conta 2:");

            for (int i = 0; i < contaCorrente2.Historico.Length; i++)
            {
                Movimentacao movimentacao = contaCorrente2.Historico[i];

                if (movimentacao != null)
                    Console.WriteLine(movimentacao.Tipo + " " + movimentacao.Valor);
            }

            Console.ReadLine();
        }
    }
}
