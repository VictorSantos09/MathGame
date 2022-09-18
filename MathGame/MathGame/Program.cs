using System;

namespace MathGame
{
    class Program
    {
        // inicio método para caso infinito
        static void Infinity()
        {
            Console.WriteLine("Digite SAIR para encerrar e ver o resultado a qualquer momento");
            bool looping = true;
            int erradoLoop = 0; int certoLoop = 0;
            while (looping)
            {
                int valor1Loop, valor2Loop, finalResult = 0; int userAnswerLoop = 0;
                Random numRandom1 = new Random();
                valor1Loop = numRandom1.Next(1, 31);
                Random numRandom2 = new Random();
                valor2Loop = numRandom2.Next(1, 31);
                finalResult = valor1Loop + valor2Loop;
                Console.WriteLine($"Quanto é {valor1Loop} + {valor2Loop}?");
                userAnswerLoop = Convert.ToInt32 (Console.ReadLine());

                if (userAnswerLoop != finalResult)
                {
                    erradoLoop = erradoLoop +1;
                    Console.WriteLine("Errou");
                }
                else
                {
                    certoLoop = certoLoop + 1;
                    Console.WriteLine("Acertou");
                }
                // converter para string para encerrar looping, operadores matematicos aleatorios, checagem de digito de numero
                if (userAnswerLoop == 1)
                {
                    Console.Clear();
                    int total = erradoLoop + certoLoop;
                    Console.WriteLine($"Parabéns você acertou {certoLoop} de {total} e errou {erradoLoop}!");
                    looping = false;
                }
            }
                // fim método para caso infinito
                // inicio para caso finito
        }
            static void Main (string[] args)
            {
                string nickname = "";int userAnswer = 0;
                int errado, certo = 0; int userTryChoice = 0;

                Console.WriteLine("Escreva seu nickname");
                nickname = Console.ReadLine();
                Console.WriteLine($"Quantas vezes deseja tentar {nickname}? Digite 1 para sem limites");
                userTryChoice = Convert.ToInt32(Console.ReadLine());
                if(userTryChoice == 1)
                {
                    Console.WriteLine($"Olá {nickname} clique ENTER para começar. Boa sorte!");
                    Console.ReadKey(); Console.Clear();
                    Infinity();
                }
                else
                {
                    Console.WriteLine($"Olá {nickname} clique ENTER para começar, você tem {userTryChoice} tentativas. Boa sorte!");
                    Console.ReadKey(); Console.Clear();

                    for (int i = 0; i < userTryChoice; i++)
                    {
                        int valor1, valor2, finalResult = 0; string operation = "";
                        Random numRandom1 = new Random();
                        valor1 = numRandom1.Next(1, 31);
                        Random numRandom2 = new Random();
                        valor2 = numRandom2.Next(1, 31);
                        finalResult = valor1 + valor2;

                        Console.WriteLine($"Quanto é {valor1} + {valor2}?");
                        userAnswer = Convert.ToInt32(Console.ReadLine());

                        if (userAnswer != finalResult)
                        {
                            errado = +1;
                            Console.WriteLine("Errou");
                        }
                        else
                        {
                            certo = certo +1;
                            Console.WriteLine("Acertou");
                        }
                    }
                    Console.Clear();
                    Console.WriteLine($"Parabéns você acertou {certo} de {userTryChoice}!");
                }
            }
    }
}
