using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string? Documento { get; set; }
        public Pessoa()
    {
        Nome = string.Empty; // Inicializar com uma string vazia para evitar nulos
    }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }

}