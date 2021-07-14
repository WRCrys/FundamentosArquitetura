using System;

namespace OOP
{
    /**
     * State and Behavior
     * Both is referencing to one class.
     * The State is the properties class and within it has information
     * The behavior is when you use method to generate a new information through the own class,
     * updating the class property or creating a new value. 
     */
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}