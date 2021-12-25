using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica mat = new Matematica(10, 20);
            mat.Somar();
            
            
            Operacao op = Calculadora.Somar;
            op += Calculadora.Subtrair;
            op.Invoke(30, 30);
            
            
            const double pi = 3.14;
            System.Console.WriteLine(pi);
            
            
            Data data = new Data();
            data.setMes(20);

            data.Mes = 20;

            data.apresentarMes();
            
            
            Aluno a1 = new Aluno("Flavio", "Nishiyama", "Teste");
            a1.Apresentar();


            Log log = Log.GetInstance();
            log.PropriedadeLog = "teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);
            
            Pessoa p1 = new Pessoa();
            p1.Apresentar();
        }
    }
}
