using System;

namespace Aula18_Coding_Dojo_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
             Jogador ribamar = new Jogador();
            ribamar.Nome = "Ribamar";
            ribamar.Altura = 1.85f;
            ribamar.Peso = 79f;
            ribamar.DataDeNascimento = DateTime.Parse("21/05/1997");
            ribamar.Posicao = "Atacante";
            
            System.Console.WriteLine(ribamar.CalcularIdade());
            System.Console.WriteLine(ribamar.VerificarAposentadoria());
        }
    }
}
