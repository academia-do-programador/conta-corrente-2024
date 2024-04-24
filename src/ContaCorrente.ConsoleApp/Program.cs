namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();

            funcionario1.Nome = "Tiago";
            funcionario1.Cpf = "200.001.220-02";
            funcionario1.Salario = 10_000m;

            funcionario1.Atender();

            Gerente gerente = new Gerente();

            gerente.Nome = "Rech";
            gerente.Cpf = "350.201.290-10";
            gerente.Salario = 50_000m;
            gerente.Senha = "x0Zweqas812MlY_";

            gerente.Atender();
            gerente.Autenticar("abc123");

            TecnicoInformatica tecnicoInformatica = new TecnicoInformatica();
            tecnicoInformatica.PararSistema();

            Console.WriteLine(gerente);

            Console.ReadLine();
        }

        // Superclasse ou classe pai
        // Entidade Base

        // Base = classe pai / superclasse
        class Funcionario : object
        {
            public string Nome { get; set; }

            public string Cpf { get; set; }

            public decimal Salario { get; set; }

            public virtual void Atender()
            {
                Console.WriteLine("Chamando o próximo cliente.");
            }

            // sobrescrita de método
            public override string ToString()
            {
                return $"{Nome}, {Cpf}, {Salario}";
            }
        }

        // Subclasse ou Classe filha
        class Gerente : Funcionario
        {
            public string Senha { get; set; }

            public void Autenticar(string senhaDigitada)
            {
                if (senhaDigitada == this.Senha)
                    Console.WriteLine("Acesso autorizado.");

                else
                    Console.WriteLine("Acesso negado!");
            }

            public override void Atender()
            {
                Console.WriteLine("Chamando o próximo cliente VIP");
            }
        }

        class TecnicoInformatica : Funcionario
        {
            public string SenhaBancoDados { get; set; }

            public void PararSistema()
            {
                Console.WriteLine("O sistema está inativo!");
            }
        }
    }
}
