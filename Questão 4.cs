//4)Faça um programa que exiba as opções: 
//1 – Conversão de Graus Celsius em Graus Fahrenheit 
//2 – Conversão de Graus Fahrenheit em Graus Celsius 
//3 – Peso ideal do homem 
//4 – Peso ideal da mulher
//O programa só deve encerrar quando o usuário digitar ´S´ para a pergunta “Deseja encerrar o programa?”
//Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.

using System;

public class Conversao
{
    public static void Conversão()
    {
		bool continuar = true;
		int opcao;

		do
		{
			do
			{
				Console.WriteLine("Digite uma das opções: \n\n===================================================\n1 – Conversão de Graus Celsius em Graus Fahrenheit\n=================================================== \n2 – Conversão de Graus Fahrenheit em Graus Celsius\n===================================================\n3 – Peso ideal do homem \n===================================================\n4 – Peso ideal da mulher \n===================================================\n\n");
				opcao = Convert.ToInt32(Console.ReadLine());
				} while (opcao < 1 || opcao > 4) ;
				if (opcao < 1 || opcao > 4)
				{
					Console.WriteLine("Opção Errada, insira uma das opções corretas.\n");
				}
				float Celsius, Fahrenheit;
				float Altura, PesoIdeal;
				Console.Clear();
				switch (opcao)
				{
					case 1:
						Console.WriteLine("\nDigite a temperatura em °C: ");
						Celsius = float.Parse(Console.ReadLine());
						Fahrenheit = (Celsius * 1.8F) + 32;
						Console.WriteLine("A temperatura convertida é: " + Fahrenheit + "°F.\n");
						break;
					case 2:
						Console.WriteLine("Digite a temperatura em °F: ");
						Fahrenheit = float.Parse(Console.ReadLine());
						Celsius = (Fahrenheit - 32) / 1.8F;
						Console.WriteLine("A temperatura convertida é: " + Celsius + "°C.\n");
						break;
					case 3:
						Console.WriteLine("Digite a altura: ");
						Altura = float.Parse(Console.ReadLine());
						PesoIdeal = (72.7F * Altura) - 58;
						Console.WriteLine("Seu peso ideal é: " + PesoIdeal + "kg");
						break;
					case 4:
						Console.WriteLine("Digite a altura: ");
						Altura = float.Parse(Console.ReadLine());
						PesoIdeal = (62.1F * Altura) - 44.7F;
						Console.WriteLine("Seu peso ideal é: " + PesoIdeal + "kg");
						break;
						Console.WriteLine("Opção Errada.\n");
				}

				Console.WriteLine("\nDeseja encerrar o programa? (s/N) ");
				string letra = Console.ReadLine();
				if (letra == "S" || letra == "s")
				{
					continuar = false;
				}
			} 
		while (continuar);
	}
}