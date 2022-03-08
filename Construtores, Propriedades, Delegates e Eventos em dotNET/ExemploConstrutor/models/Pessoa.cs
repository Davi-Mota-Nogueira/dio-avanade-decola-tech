namespace ExemploConstrutor.models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar(){
            Console.WriteLine($"Olá, sou {nome} {sobrenome}, prazer lhe conhecer.");
        }
    }
}