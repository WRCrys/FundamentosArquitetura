namespace OOP
{
    /*
     * Class Definition
     * Code structure where has as function map an real object.
     *
     * Definição de Classe
     * Estrutura de código que tem como função mapear um objeto do mundo real
     */
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            /*
             * Object Definition
             * When you have your class been instance in memory
             *
             * Definição de Objeto
             * Quando você tem a sua classe sendo instânciada em memória
             */
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}