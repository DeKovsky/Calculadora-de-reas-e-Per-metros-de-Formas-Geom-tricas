using System;

namespace uc03DesafioCaluladoraTrigronometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string nome, escolha;
                double num1, num2, num3, num4, operacao, calculo, pi = 3.14;
                char continuar;


                Console.WriteLine("Seja bem vindo a nossa calculadora de áreas e perimetros!");
                Console.WriteLine("Por gentileza, nos informe seu nome:");
                nome = Console.ReadLine();

                do // laço de repetição no final perguntando se o cliente quer continuar, repetindo as pergunrtas de área ou perímetro e depois o tipo de desenho geométrico.
                {
                    Console.WriteLine("Digite [a] para calculcar a área ou [p] para calcular o perimetro de uma figura geométrica?");
                    escolha = Console.ReadLine();


                    if (escolha == "a" || escolha == "A") //Nesse if, se o cliente digitar a ou A quando for perguntado se deseja cálcular áerea ou perímetro, ele perguntará o desenho goemétrico e iniciará os cálculos de área.
                    {

                        Console.WriteLine("Digite [1] para triângulo, [2] quadrado, [3] retângulo, [4] círculo, [5] trapézio e [6] losango.");
                        operacao = int.Parse(Console.ReadLine());

                        //no primeiro switch são realizados os cálculos de área a depender da figura geométrica escolhida acima.
                        switch (operacao)
                        {
                            case 1:
                                Console.WriteLine("Digite o valor correspondente a base do triângulo:");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a altura do triângulo:");
                                num2 = double.Parse(Console.ReadLine());
                                calculo = (num1 * num2) / 2;
                                Console.WriteLine(nome + ", a área desse triângulo é " + calculo);
                                break;

                            case 2:
                                Console.WriteLine("Digite o valor correspondente a um dos lados do quadrado");
                                num1 = double.Parse(Console.ReadLine());
                                calculo = num1 * num1;
                                Console.WriteLine(nome + ", a área desse quadrado é " + calculo);
                                break;

                            case 3:
                                Console.WriteLine("Digite o valor correspondente a base do retângulo:");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a altura do retângulo:");
                                num2 = double.Parse(Console.ReadLine());
                                calculo = num1 * num2;
                                Console.WriteLine(nome + ", a área desse retângulo é " + calculo);
                                break;

                            case 4:
                                Console.WriteLine("Digite o valor correspondente ao raio do círculo:");
                                num1 = double.Parse(Console.ReadLine());
                                calculo = pi * (Math.Pow(num1, 2));
                                Console.WriteLine(nome + ", a área desse círculo é " + calculo);
                                break;

                            case 5:
                                Console.WriteLine("Digite o valor correspondente a base maior do trapézio:");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a base menor do trapézio:");
                                num2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a altura do trapézio:");
                                num3 = double.Parse(Console.ReadLine());
                                calculo = ((num1 + num2) * num3) / 2;
                                Console.WriteLine(nome + ", a área desse trapézio é " + calculo);
                                break;

                            case 6:
                                Console.WriteLine("Digite o valor correspondente a diagonal maior do losango:");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a diagonal menor do losango:");
                                num2 = double.Parse(Console.ReadLine());
                                calculo = (num1 * num2) / 2;
                                Console.WriteLine(nome + ", a área desse losango é " + calculo);
                                break;
                        }
                    }

                    else if (escolha == "p" || escolha == "P") //Nesse else if, se o cliente digitar p ou P quando for perguntado se deseja cálcular áerea ou perímetro, ele perguntará o desenho goemétrico e iniciará os cálculos de perímetro.
                    {

                        Console.WriteLine("Digite [1] para triângulo, [2] quadrado, [3] retângulo, [4] círculo, [5] trapézio e [6] losango");
                        operacao = int.Parse(Console.ReadLine());

                        //no segundo switch são realizados os cálculos dos perímetros a a depender da figura geométrica escolhida acima.
                        switch (operacao)
                        {
                            case 1:
                                Console.WriteLine("Digite o valor correspondente a um dos lados do triângulo:");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a um segundo lado do triângulo:");
                                num2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente ao terceiro lado do triângulo:");
                                num3 = double.Parse(Console.ReadLine());
                                calculo = num1 + num2 + num3;
                                Console.WriteLine(nome + ", o perímetro desse triângulo é " + calculo);
                                break;

                            case 2:
                                Console.WriteLine("Digite o valor correspondente a um dos lados do quadrado");
                                num1 = double.Parse(Console.ReadLine());
                                calculo = num1 * 4;
                                Console.WriteLine(nome + ", o perímetro desse quadrado é " + calculo);
                                break;

                            case 3:
                                Console.WriteLine("Digite o valor ao maior lado do retângulo:");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente ao menor lado do retângulo:");
                                num2 = double.Parse(Console.ReadLine());
                                calculo = (num1 * 2) + (num2 * 2);
                                Console.WriteLine(nome + ", o perímetro desse retângulo é " + calculo);
                                break;

                            case 4:
                                Console.WriteLine("Digite o valor correspondente ao raio do círculo:");
                                num1 = double.Parse(Console.ReadLine());
                                calculo = 2 * pi * num1;
                                Console.WriteLine(nome + ", o perímetro desse círculo é " + calculo);
                                break;

                            case 5:
                                Console.WriteLine("Digite o valor correspondente a base maior do trapézio:");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a base menor do trapézio:");
                                num2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente a um dos lados do trapézio:");
                                num3 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor correspondente ao outro lado do trapézio:");
                                num4 = double.Parse(Console.ReadLine());
                                calculo = num1 + num2 + num3 + num4;
                                Console.WriteLine(nome + ", o perímetro desse trapézio é " + calculo);
                                break;

                            case 6:
                                Console.WriteLine("Digite o valor correspondente a um dos lados do losango:");
                                num1 = double.Parse(Console.ReadLine());
                                calculo = num1 * 4;
                                Console.WriteLine(nome + ", o perímetro desse losango é " + calculo);
                                break;
                        }
                    }
                    Console.WriteLine("Deseja continuar? (S) Sim ou (N) Não");
                    continuar = char.Parse(Console.ReadLine());
                } while (continuar == 's' || continuar == 'S');
            
                Console.WriteLine(nome + ", muito obrigado por ter participado do nosso projeto!");
                Console.WriteLine("Tenha um bom dia!");
                Console.WriteLine("By DeKovsky!");
            
            }
        }
    }
}
