namespace ContaCorrente.ConsoleApp
{
    public static class GeradorId
    {
        private static int contadorContasCriadas = 0;

        public static int GerarNovoIdConta()
        {
            return ++contadorContasCriadas;
        }
    }
}