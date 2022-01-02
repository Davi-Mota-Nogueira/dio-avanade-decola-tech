namespace CsharpPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public sealed override void Apresentar(){
            Console.WriteLine($"Olá, sou o professor {Nome}, tenho {Idade} anos e meu salário é de {Salario}");
        }
    }
}