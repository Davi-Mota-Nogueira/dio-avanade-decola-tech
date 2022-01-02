using System;

namespace CsharpPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura){
            if (comprimento > 0 && largura > 0){
                this.comprimento = comprimento;
                this.largura = largura;
                this.valido = true;
            } else{
                this.valido = false;
                Console.WriteLine("Valores Inválidos!");
            }
            
        }

        public double ObterArea(){
            if (valido){
                return (comprimento * largura);
            } else{
                return 0.0;
            }
            
        }
    }
}