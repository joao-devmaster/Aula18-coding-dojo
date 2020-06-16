using System;

namespace Aula18_Coding_Dojo_de_fixação
{
    public class Jogador
    {
                public string Nome { get;set; }
        public int Idade { get;set; }
        public string Nacionalidade { get;set; }
        public string Posicao { get;set; }
        public DateTime DataDeNascimento { get;set; }
        public float Peso { get;set; }
        public float Altura { get;set; }
        
        public int CalcularIdade(){

            int AnoAtual = Int32.Parse(DateTime.Now.ToString().Split ("/") [2].Split (" ") [0]);
            int DataNascimento = Int32.Parse(DataDeNascimento.ToString().Split("/")[2].Split(" ") [0]  );

            Idade = AnoAtual - DataNascimento;

            return Idade;
        
        }

        public string VerificarAposentadoria(){
            
            string Mensagem = "";

            if (Idade >= 35 && Posicao == "Atacante")
            {
                Mensagem = "O Atacante pode se aposentar";

            }else if (Idade >= 38 && Posicao == "Meio-Campista"){

                Mensagem = "O Meio Campista pode se aposentar";

            }else if (Idade >= 40 && Posicao == "Defensor"){

                Mensagem = "O Defensor pode se aposentar"; 

            }else{

                Mensagem = "O jogador não atingiu a idade suficiente para se aposentar!";
            }
            return Mensagem; 
        }

    }
}