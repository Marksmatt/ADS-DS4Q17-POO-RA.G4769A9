using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Aluno
{
    
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Disciplina { get; set; }
    public string Ra { get; set; }

    
    public Aluno(string nome, int idade, string disciplina, string ra)
    {
        Nome = nome;
        Idade = idade;
        Disciplina = disciplina;
        Ra = ra;
    }
}


class Aplicacao
{
    
    static List<Aluno> alunos = new List<Aluno>();

    
    static void Main(string[] args)
    {
        
        alunos.Add(new Aluno("João", 20, "Matemática", "ABC123"));
        alunos.Add(new Aluno("Maria", 19, "Português", "DEF456"));
        alunos.Add(new Aluno("Pedro", 21, "História", "GHI789"));

        
        Console.WriteLine("Digite um ra para validar:");
        string ra = Console.ReadLine();

        
        Aluno aluno = ValidarRa(ra);

       
        if (aluno != null)
        {
            Console.WriteLine("O aluno é válido.");
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Idade: " + aluno.Idade);
            Console.WriteLine("Disciplina: " + aluno.Disciplina);
            Console.WriteLine("Ra: " + aluno.Ra);
        }
        else
        {
            Console.WriteLine("O aluno é inválido.");
        }
    }

   
    static Aluno ValidarRa(string ra)
    {
        
        if (Regex.IsMatch(ra, @"^[A-Z]{3}\d{3}$"))
        {
            
            foreach (Aluno a in alunos)
            {
                
                if (a.Ra == ra)
                {
                    return a;
                }
            }
            
            return null;
        }
        else
        {
            
            return null;
        }
    }
}