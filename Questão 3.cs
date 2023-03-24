//3)Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a
//possuir o valor da variável B, e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.


using System;

public class Valores_inteiros
{
    public static void Troca_valores()
    {
        int a, b, c;
        Console.WriteLine("Informe o primeiro valor: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo valor: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nAntes da troca os valores no momento são A: {0} e o B: {1}" ,a,b);
        
        c = a;
        a = b;
        b = c;

        Console.WriteLine("\nApós a troca o valor de A é: {0} e o B: {1}" ,a,b);
    }
}
    
