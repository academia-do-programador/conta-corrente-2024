namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal Valor;
        public string Tipo;

        public Movimentacao(decimal valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }
    }
}
