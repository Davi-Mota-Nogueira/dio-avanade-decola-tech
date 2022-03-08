// See https://aka.ms/new-console-template for more information

using System;
using ExemploConstrutor.models;

// Pessoa p1 = new Pessoa();
// Pessoa p2 = new Pessoa("Guilherme", "Silveira");
// p1.Apresentar();
// p2.Apresentar();

Log log = Log.GetInstance();
log.PropriedadeLog = "Teste Instancia";
Log log2 = Log.GetInstance();
Console.WriteLine(log2.PropriedadeLog);