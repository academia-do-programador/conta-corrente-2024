namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public int Numero;
        public decimal Saldo;
        public decimal Limite;

        public Cliente Titular;

        public Movimentacao[] Historico;
        private int qtdMovimentacoes;

        public ContaCorrente(decimal saldo, decimal limite, Cliente titular)
        {
            Numero = GeradorId.GerarNovoIdConta();
            Saldo = saldo;
            Limite = limite;
            Titular = titular;

            Historico = new Movimentacao[100];
        }

        public bool Sacar(decimal valor)
        {
            if (valor > Saldo + Limite)
                return false;

            Saldo -= valor;

            Movimentacao movimentacao = new Movimentacao(valor, "Saque");

            RegistrarMovimentacao(movimentacao);

            return true;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;

            Movimentacao movimentacao = new Movimentacao(valor, "Depósito");

            RegistrarMovimentacao(movimentacao);
        }

        public bool Transferir(decimal valor, ContaCorrente destinatario)
        {
            bool conseguiuSacar = Sacar(valor);

            if (conseguiuSacar == false)
                return false;

            destinatario.Depositar(valor);

            return true;
        }

        public decimal ObterSaldo()
        {
            return Saldo;
        }

        private void RegistrarMovimentacao(Movimentacao movimentacao)
        {
            Historico[qtdMovimentacoes] = movimentacao;
            qtdMovimentacoes++;
        }
    }
}
