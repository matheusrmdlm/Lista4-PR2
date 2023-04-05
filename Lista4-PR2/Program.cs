using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exec1
            //Resposta:Uma variavel de int para float é possivel logicamente mas pelo o programa ele não lê,
            //mas de float não é possivel porque o número pode ter
            //virgula ai o int é de número inteiro e dai não vai conseguir ler.


            //int num=10;
            //float num1;
            //num = num1
            //num1 = num;

            //impossivel fazer uma conversão para int para float e em vice-versa diretamente.

            //Exec2

            //O "Console.ReadLine()é usado para ler a linha escrita e o  "Console.Read()"ele lê so um caracter escrito.
            //O console.readline vai dar o dado da linha descrita e o Console.read ele so vai dar o dado do caracter descrito
            //Ele sempre da o mesmo tipo descrito que pode ser um numero ou uma palavra(readline)/caracter(read)

            //Exec3
            //O tipo int é para números interos,então ele não vai ver número com virgulo ou negativo,
            //o float é depois do virgula com ate 32 números depois da virgula e pode ter negativo,
            //e o double é depois da virgula com ate 64 numeros deposi da virgula e pode ter negativo.

            //O cuidado que precisa ter do int é o numero que você desejar dar e receber que não pode ser negativo ou com vírgula,
            //com o float é preciso ter cuidado com a precisção do número que você quer porque ele vai até 32 numero depois da vírgula
            //que no double vai até 64 números depois da vírgula.

            //Exec4

            //int num, num2, num3;
            //Console.WriteLine("entre com um número");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            //    Console.WriteLine("mensagem 1");
            //else
            //    Console.WriteLine("mensagem 2");

            //Esse programa serve para ver se o número digitado pelo usuário é dividido por 2 e menor que 10
            //Com o número 8 a mensagem deu 2,com o número 27 a mensagem 2 ,com o número 28 a mensagem 1 

            //Exec5

            //float pos1, velocidade, tempo, posfinal;

            //Console.WriteLine("qual a velocidade");
            //velocidade=float.Parse(Console.ReadLine());
            //Console.WriteLine("qual a tempo");
            //tempo=float.Parse(Console.ReadLine());
            //Console.WriteLine("qual a posição inicial");
            //pos1 = float.Parse(Console.ReadLine());

            //posfinal = pos1 + (velocidade * tempo);

            //Console.WriteLine("A posição final é : " + posfinal);

            //Exec6

            //int num;
            //Console.WriteLine("digite seu número");
            //num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 5 == 0 && num % 10==0)
            //{
            //    Console.WriteLine("seu número é divisivel por 3 e 5 e 10");
            //}

            //else if (num % 3 == 0 && num % 5 == 0 )
            //{
            //    Console.WriteLine("seu número é divisivel por 3 e 5");
            //}
            //else
            //{
            //    if (num % 3== 0)
            //    {
            //        Console.WriteLine("ele é divisilvel por 3");
            //    }
            //    else if (num %5==0)
            //    {
            //        Console.WriteLine("ele é divisilvel por 5");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("ele não é divisilvel por 3 ou 5");
            //    }

            //}

            //Exec 7

            //int tempo;
            //Console.Write("Digite a distância em km da sua casa até a escola: ");
            //int distancia = int.Parse(Console.ReadLine());
            //if (distancia < 12)
            //{
            //    tempo = 14;
            //}
            //else if (distancia < 29)
            //{
            //    tempo = 17;
            //}
            //else if (distancia < 55)
            //{
            //    tempo = 13;
            //}
            //else if (distancia < 82)
            //{
            //    tempo = 15;
            //}
            //else
            //{
            //    tempo = 12;
            //}

            //int tempoTotal = tempo * (100 - distancia);

            //Console.WriteLine($"Tempo total de viagem: {tempoTotal} minutos ({tempoTotal / 60} horas e {tempoTotal % 60} minutos)");

            //Exec 8

            //string marca;
            //int quantidade;
            //double precoUnitario, custo, imposto, precoTotal, lucroLiquido;

            //Console.WriteLine("Informe a marca do produto (ROYAL, Wiskas, Golden, Nutrien, Special cat, Marba ou Gatus):");
            //marca = Console.ReadLine();
            //Console.WriteLine("Informe a quantidade de unidades:");
            //quantidade = int.Parse(Console.ReadLine());

            //switch (marca)
            //{
            //    case "ROYAL":
            //        precoUnitario = 129.50;
            //        custo = 77.5;
            //        imposto = 33;
            //        break;
            //    case "Wiskas":
            //        precoUnitario = 182.78;
            //        custo = 89.7;
            //        imposto = 27.5;
            //        break;
            //    case "Golden":
            //        precoUnitario = 159.46;
            //        custo = 71.7;
            //        imposto = 22.5;
            //        break;
            //    case "Nutrien":
            //        precoUnitario = 144.80;
            //        custo = 88.9;
            //        imposto = 25;
            //        break;
            //    case "Special cat":
            //        precoUnitario = 205.40;
            //        custo = 83.24;
            //        imposto = 22;
            //        break;
            //    case "Marba":
            //        precoUnitario = 125.10;
            //        custo = 90.4;
            //        imposto = 17.9;
            //        break;
            //    case "Gatus":
            //        precoUnitario = 133.99;
            //        custo = 94.6;
            //        imposto = 20;
            //        break;
            //    default:
            //        Console.WriteLine("Marca inválida.");
            //        return;
            //}

            //precoTotal = quantidade * precoUnitario;
            //lucroLiquido = (precoUnitario - custo) * quantidade - (imposto / 100) * (precoUnitario - custo) * quantidade;

            //Console.WriteLine("Preço total: R$ " + precoTotal.ToString("F2"));
            //Console.WriteLine("Lucro líquido: R$ " + lucroLiquido.ToString("F2"));
        }
    }
}
