namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string Nome = "Flavio";
        private readonly string Sobrenome;

        public Pessoa()
        {
            Nome = string.Empty;
            Sobrenome = string.Empty;
        }

        public Pessoa(string Nome, string Sobrenome)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            System.Console.WriteLine("Construtor Classe Pessoa!");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {Nome} {Sobrenome}!");
        }
    }
}