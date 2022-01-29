using System;
using ExamploConstrutores.Models;

namespace ExamploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
           
           Matematica m = new Matematica(10, 10);
           m.Somar();
           
           
           
           //Operacao op = new Operacao(Calculadora.Somar);
           //op += Calculadora.Subtrair;
           //op.Invoke(30, 20);
           
           
           
           // Pessoa p1 = new Pessoa("Ronaldo", "Cabral" );
           // p1.Apresentar();
           
           // Aluno A1 = new Aluno("Ronaldo", "Porto", "Teste" );
           // A1.Apresentar();
           
           // Log log =  Log.GetInstace();
           // log.PropriedadeLog = "Teste Instancia";

           // Log log2 = Log.GetInstace();
           // System.Console.WriteLine( log2.PropriedadeLog  );

           // Data mes = new Data();
           // mes.setMes(50);
           // mes.apresentarMes();
           
           // Data mes = new Data();
           // mes.Mes = 2;
           // mes.apresentarMes();

           // const double pi = 3.14;
           // System.Console.WriteLine(pi);
        }
    }
}
