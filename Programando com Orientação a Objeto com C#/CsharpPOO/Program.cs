// See https://aka.ms/new-console-template for more information
using CsharpPOO.Interfaces;
using CsharpPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Davi";
// p1.Idade = 23;
// p1.Apresentar();

// Retangulo r1 = new Retangulo();
// r1.DefinirMedidas(4.2, 5.7);
// var area = r1.ObterArea();
// Console.WriteLine($"A área do retângulo é de {area}m²");

// Retangulo r2 = new Retangulo();
// r2.DefinirMedidas(-4.7, -5.7);
// var area2 = r2.ObterArea();
// Console.WriteLine($"A área do retângulo é de {area2}m²");

// Aluno a1 = new Aluno();
// a1.Nome = "Rabelo";
// a1.Idade = 32;
// a1.Nota = 7;
// a1.Apresentar();

// Professor pr1 = new Professor();
// pr1.Nome = "Sérgio";
// pr1.Idade = 64;
// pr1.Salario = 10000;
// pr1.Apresentar();

// Calculadora c1 = new Calculadora();
// System.Console.WriteLine("Resultado da primeira soma: " + c1.Somar(10,2));
// System.Console.WriteLine("Resultado da segunda soma: " + c1.Somar(10,23,5));

// ContaCorrente conta1 = new ContaCorrente();
// conta1.Creditar(400);
// conta1.ExibirSaldo();

// Computador computer = new Computador();
// System.Console.WriteLine(computer.ToString());

ICalculadora calculadora = new Calculadora();
int num1 = 4;
int num2 = 2;
calculadora.Somar(num1, num2);
calculadora.Subtrair(num1, num2);
calculadora.Multiplicar(num1, num2);
calculadora.Dividir(num1,num2);