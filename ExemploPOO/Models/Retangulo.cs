using System;
using System.Collections.Concurrent;
using System.Diagnostics.Contracts;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        //propriedades        
        private double comprimento;
        private double largura;

        private bool valido;
        
        //Método capaz de alterar as duas propriedades, que será exposto publicamente
        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
               System.Console.WriteLine("Valores inválidos"); 
            }
            
        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Por favor, informe valores válidos");
                return 0;
            }
        }
    }
}