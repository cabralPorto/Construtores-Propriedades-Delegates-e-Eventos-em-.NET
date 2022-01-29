using System;

namespace ExamploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;
        
        public Pessoa()
        {
        nome = string.Empty;
        sobrenome = string.Empty;
        } 
        public  Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome= sobrenome;
            System.Console.WriteLine("Construtor da classe pessoa!");
        }  
        public void Apresentar()
        {   
          Console.WriteLine($"Meu nome é: {nome} {sobrenome}"  );
        }
    }
}