namespace CsharpPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá, sou {Nome}, tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}