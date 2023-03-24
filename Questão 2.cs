//Ei você que chegou até aqui, meus parabéns! Isso demonstra que você tem interesse e está em busca de resultados. 🤩 Você já está apto a desenvolver outros projetos que utilizam os conceitos básicos da Programação Orientada a Objetos.
// 
//    O projeto entregue para a escola Reprograme foi um verdadeiro sucesso, a equipe, como um todo, utilizou o software de gestão dos aparelhos eletrônicos e com isso, perceberam um aumento na performance e dinamismo no empréstimo dos apetrechos tecnológicos. Com esse ganho performático, a escola pediu um novo software que os auxilie a efetuar o cadastro dos funcionários. 
//
//    Após o briefing com o cliente, a equipe responsável efetuou o levantamento e análise dos dados, desta forma, seu supervisor te pediu para que desenvolva um algoritmo que realize o cadastro dos funcionários da escola e exiba um relatório que contenha o nome e sobrenome do funcionário, seu cargo, cidade onde reside, CPF, gênero e por fim, a quantidade de colaboradores nas áreas específicas. 
//
//    As regras de negócio para a implementação do software são: 
//É sabido que 10 novos colaboradores precisarão ser cadastrados no sistema;
//Será necessário informar o nome, sobrenome, CPF (utilize um validador para verificar CPF inválidos, CPF válido possui 11 dígitos), gênero e cidade onde reside;
//É obrigatório criar uma classe para os funcionários (utilize o conceito da abstração);
//Os únicos cargos disponíveis são: Gestores; coordenadores; docentes e secretários;
//Caso um funcionário cadastrado tenha um cargo inválido, o software deverá informar no relatório final para que a equipe técnica possa verificar alguma inconsistência no processo seletivo.
//
//
//
//SUGESTÕES:
//
//  1.Inicie um novo projeto no Visual Studio -> Criar um Projeto -> Filtrar por C#, Plataforma Windows e Aplicativo Console -> Selecionar o "Aplicativo do Console(.NET FrameWork).". Desta forma, a IDE já inicializará com as principais bibliotecas, classe internal Program e a função Main();
//
//  2. A classe deverá estar FORA da Main();
//
//
//3.Criação dos ATRIBUTOS da classe com modificador de acesso private;
//
//Estrutura para criação dos ATRIBUTOS/VARIÁVEIS: 
//ModificadorDeAcesso TipoDoDado NomeDaVariável;
//
//
//4.Criação dos métodos de acesso, serão com os modificadores public. Eles fornecerão acesso às variáveis (get e set);
//
//Estrutura para a criação dos métodos de acesso:
//ModificadorDeAcesso TipoDeDado NomeDaPropriedade(mesmo nome da variável, porém, com Letra Maiúscula);
//
//
//5.Os objetos serão criados na Main();
//
//
//6.Estrutura para criar as instâncias:
//
//NomeDaClasse NomeDoObjeto = new NomeDaClasse();
//
//
//7.Para acessar as propriedades do objeto:
//
//    NomeDoObjeto.NomeDaPropriedade






//Infelizmente foi o que consegui fazer nesse limite de tempo apos entender o problema


//Nome: Wayne P.Silva            Data:23/02/2023




using System;

namespace GerenciamentoDeCadastro
{
    internal class CadrastroNome
    {
        public class Cadastro
        {
            private string nome;
            private string sobrenome;
            private string cpf;
            private string cargos;


            public string Nome
            {
                get { return nome; }

                set { nome = value; }
            }

            public string Sobrenome
            {
                get { return sobrenome; }

                set { sobrenome = value; }
            }
            public string Cpf
            {
                get { return cpf; }

                set
                {
                    if (value.Length < 11)
                    {
                        Console.WriteLine("Cpf inválido, digite um cpf que contenha a quantidade de carácteres correta");
                        return;
                    }
                    else
                    {

                    }
                }
            }
            public string Cargos
            {
                get { return cargos; }

                set
                {
                    if (value == "GESTOR" || value == "COORDENADOR" || value == "DOCENTE" || value == "SECRETARIO")
                    {
                        cargos = value.ToUpper();
                    }
                    else
                    {
                        Console.WriteLine("Cargo inválido, tente novamente");
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            Cadastro cadastro1 = new Cadastro();

            Console.WriteLine("==========================");
            Console.WriteLine("\tCADASTRO");
            Console.WriteLine("==========================");
            Thread.Sleep(2200);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nInforme o {i} nome para cadastro");
                cadastro1.Nome = Console.ReadLine();
                Console.WriteLine("Informe o sobrenome para cadastro");
                cadastro1.Sobrenome = Console.ReadLine().ToUpper();
                Console.WriteLine("Informe um cpf de 11 digitos para o cadastro (Obrigatorio 11 digitos)");
                cadastro1.Cpf = Console.ReadLine().ToUpper();
                Console.WriteLine("Informe o cargo do usuário a ser cadastrado");
                cadastro1.Cargos = Console.ReadLine().ToUpper();
            }
            Console.Clear();
            Console.WriteLine($"\nO cadastro foi concluio.");
        }
    }
}