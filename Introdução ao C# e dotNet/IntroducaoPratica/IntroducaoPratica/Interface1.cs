using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoPratica
{
    interface IRestaurante
    {
        void Nome(string nome);
        void Categoria(string categoria);
        void Localizacao(string localizacao);
        void MetrosQuadrado(int tamanho);
    }

    class Restaurante : IRestaurante
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Localizacao { get; set; }
        public int MetrosQuadrado { get; set; }

        void IRestaurante.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IRestaurante.Categoria(string categoria)
        {
            this.Categoria = categoria;
        }
        void IRestaurante.Localizacao(string localizacao)
        {
            this.Localizacao = localizacao;
        }
        void IRestaurante.MetrosQuadrado(int tamanho)
        {
            this.MetrosQuadrado = tamanho;
        }
    }
}
