using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa p1 = new Pessoa();
            p1.Nome = "João";
            p1.Idade = 21;
            p1.Apresentar();
            
            Aluno al1 = new Aluno(); //obj aluno herda da classe pessoa nome e idade;
            al1.Nome = "Marcelo";
            al1.Idade = 21;
            al1.Nota = 7;
            al1.Apresentar();
            

            Professor prof1 = new Professor(); //obj professor herda da classe pessoa nome e idade, e contém salário
            prof1.Nome = "Joaquim";
            prof1.Idade = 40;
            prof1.Salario = 1500;
            prof1.Apresentar();
            


            
            //VALORES VÁLIDOS
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(10, 4);
            // System.Console.WriteLine($"Área do Retangulo = {r.ObterArea()}");

            // //VALORES INVÁLIDOS
            // Retangulo r1 = new Retangulo();
            // r1.DefinirMedidas(-10, 4);
            // System.Console.WriteLine($"Área do Retangulo = {r1.ObterArea()}");
            
            
            
            
        }
    }
}
