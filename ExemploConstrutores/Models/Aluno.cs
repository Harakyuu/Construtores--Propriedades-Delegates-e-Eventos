namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string Nome, string Sobrenome, string Disciplina) : base(Nome, Sobrenome)
        {
            System.Console.WriteLine("Construtor Classe Aluno!");
        }
    }
}