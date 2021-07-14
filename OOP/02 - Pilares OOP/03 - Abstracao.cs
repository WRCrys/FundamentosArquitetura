namespace OOP
{
    /**
     * Super Class
     * Create generic concepts that you can abstract in other classes
     */
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        /**
         * This method has an optional override because it's virtual, not abstract
         * and because this we have to implement some behavior
         */
        public virtual void Testar()
        {
            // teste do equipamento
        }
    }
}