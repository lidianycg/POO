using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 04 - Polimorfismo em tempo de compilação
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10));
            
            //Aula 04 - Polimorfismo em tempo de execução
            // Aluno a1 = new Aluno();
            // a1.Nome = "Lidiany";
            // a1.Idade = 16;
            // a1.Documento = "12345-X";
            // a1.Nota = 9;

            // a1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Juliano";
            // p2.Idade = 46;
            // p2.Salario = 9000;
            
            // p2.Apresentar();
            
            
            //Aula 03 - Herança
            // Aluno a1 = new Aluno();
            // a1.Nome = "Jonas";
            // a1.Idade = 16;
            // a1.Documento = "12345-X";

            // a1.Apresentar();
            
            
            //Aula 02 - Encapsulamento
            // //Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);

            // System.Console.WriteLine($"Área: {r2.ObterArea()}");    
            
            //Aula 01 - Abstração
            
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            
            // p1.Apresentar();

        }
    }
}
    