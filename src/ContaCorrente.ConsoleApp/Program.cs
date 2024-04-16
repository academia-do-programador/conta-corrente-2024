namespace ContaCorrente.ConsoleApp
{
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

            Console.WriteLine(contaCorrente1.Numero);
            Console.WriteLine(contaCorrente2.Numero);
            
            //ContaCorrente contaEncontrada = BuscarConta(1);
            //Console.WriteLine(contaEncontrada.Titular.NomeCompleto);

            Console.ReadLine();
        }

        static ContaCorrente BuscarConta(int indiceParaRetornar)
        {
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i] == null)
                    continue;

                return contas[indiceParaRetornar];
            }

            return null;
        }
    }
}
