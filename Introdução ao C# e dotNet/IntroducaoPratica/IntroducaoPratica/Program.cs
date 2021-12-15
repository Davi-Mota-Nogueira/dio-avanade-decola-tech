// See https://aka.ms/new-console-template for more information
using IntroducaoPratica;
using Introducao2;

Console.WriteLine("Hello, World!");

var classe1 = new IntroducaoPratica.Classe();
var classe2 = new Introducao2.Classe();

Mamifero cachorro = new Mamifero();
Mamifero baleia = new Mamifero();

cachorro.Nome = "Maxwell";
cachorro.Patas = 4;
cachorro.Reino = "Animalia";

baleia.Nome = "Moby";
baleia.Reino = "Animalia";
baleia.Patas = 0;

Restaurante restaurante1 = new Restaurante();
Restaurante restaurante2 = new Restaurante();

restaurante1.Nome = "McDonovan";
restaurante1.Localizacao = "Esquina";
restaurante1.Categoria = "Fitness";
restaurante1.MetrosQuadrado = 78;

restaurante2.Nome = "SandwichQueen";
restaurante2.Localizacao = "Esquina COntrária";
restaurante2.Categoria = "Sanduicheira";
restaurante2.MetrosQuadrado = 94;

var primeiraSinfonia = (Estacoes)0;
Estacoes segundaSinfonia = Estacoes.PRIMAVERA;
Estacoes terceiraSinfonia = (Estacoes)2;
var quartaSinfonia = Estacoes.OUTONO;

