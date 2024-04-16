namespace ContaCorrente.ConsoleApp
{

    // palavra-chave this
    internal class Program
    {
        static ContaCorrente[] contas = new ContaCorrente[10];

        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Tiago Santini", "022.232.145-90");
            ContaCorrente contaCorrente1 = new ContaCorrente(1200, 1000, cliente1);
       
            Cliente cliente2 = new Cliente("Alexandre Rech", "013.550.822-50");
            ContaCorrente contaCorrente2 = new ContaCorrente(5000, 3000, cliente2);

            contas[0] = contaCorrente1;
            contas[1] = contaCorrente2;

            contaCorrente1.Transferir(200, contaCorrente2);

            Console.ReadLine();
        }

        static ContaCorrente BuscarConta(int numeroDaConta)
        {
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i] == null)
                    continue;

                if (contas[i].Numero == numeroDaConta)
                    return contas[i];
            }

            return null;
        }
    }
}
