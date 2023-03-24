//A escola Reprograme possui um acervo de equipamentos eletrônicos disponíveis para reserva. Os funcionários devem efetuar a reserva previamente na secretaria da escola para que seja possível utilizá-los. Neste momento, a Reprograme está enfrentando problemas no que se refere ao gerenciamento dos equipamentos pois seu controle é efetuado por planilhas do Excel, e com o aumento do número de equipamentos, a equipe pedagógica está com dificuldade em saber quantos e quais são os aparelhos disponíveis.
//
//    E você, recém-contratado por uma empresa que desenvolve softwares, ficou encarregado de elaborar um trecho da aplicação que atenda a todos os requisitos/regras de negócio do cliente e que auxilie a escola na gestão dos aparelhos eletrônicos.
//Seu supervisor te orientou a criar um algoritmo/programa no qual o usuário deverá informar a marca e o tipo do aparelho. 
//
//    Será necessário que o programa exiba na tela para que o usuário possa averiguar quantos aparelhos do tipo televisão, notebook e projetor existem no estoque. 
//
//
//    Algumas regras foram estabelecidas para a implementação do algoritmo:
//Os únicos tipos de aparelhos válidos são televisão, notebook e projetor. Caso o usuário informe um tipo diferente, o programa deverá apresentar uma mensagem alertando que o tipo de aparelho é inválido (faça um verificador do TIPO antes de settar o valor na variável tipo.);
//É necessário criar uma classe para representar o PRODUTO
//A classe deverá apresentar atributos privados para representar as características do produto (marca e tipo);
//A classe necessitará de métodos de acesso(Marca e Tipo) para que o usuário possa armazenar/ler os dados privados (propriedades);
//Deverá criar 5 instâncias para materializar a classe.
using System;

namespace GerenciamentoDeEletronicos
{
    internal class Program
    {
        public class Produto
        {
            private string tipo;
            private string marca;

            public string Tipo
            {
                get { return tipo; }
                set
                {
                    if (value == "TELEVISÃO" || value == "NOTEBOOK" || value == "PROJETOR")
                    {
                        tipo = value.ToUpper();
                    }
                    else
                    {
                        Console.WriteLine("Tipo de aparelho inválido, tente novamente");
                    }
                }
            }

            public string Marca
            {
                get { return marca; }

                set { marca = value; }
            }
        }

        static void Main(string[] args)
        {
            //for (int i = 0; i <= 5; i++)
            //{
            //
            //}
            //NomeDaClasse NomeDoObjeto = new NomeDaClasse();

            Produto aparelho1 = new Produto();
            //Produto aparelho2 = new Produto();
            //Produto aparelho3 = new Produto();
            //Produto aparelho4 = new Produto();
            //Produto aparelho5 = new Produto();

            int qtdTv = 0, qtdNotebook = 0, qtdProjetor = 0;

            Console.WriteLine("===========================================");
            Console.WriteLine("GERENCIADOR DE APARELHOS ELETRÔNICOS:");
            Console.WriteLine("===========================================");
            Thread.Sleep(2800);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\nInforme a {i} marca do produto");
                aparelho1.Marca = Console.ReadLine();
                Console.WriteLine($"Informe o {i} tipo do produto");
                aparelho1.Tipo = Console.ReadLine().ToUpper();

                if (aparelho1.Tipo == "TELEVISÃO")
                {
                    qtdTv++;
                }
                else if (aparelho1.Tipo == "NOTEBOOK")
                {
                    qtdNotebook++;
                }
                else if (aparelho1.Tipo == "PROJETOR")
                {
                     qtdProjetor++;
                }
                else
                {
                    
                }
            }
            Console.WriteLine($"\nO consumidor levou para casa {qtdTv} Televisões, {qtdNotebook} Notebooks e {qtdProjetor} Projetores.");
        }
    }
}
