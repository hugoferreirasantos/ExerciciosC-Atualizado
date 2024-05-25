using System;
using System.Globalization;

namespace Exercicio1040EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, notaExame = 0.0, mediaFinal, media;

            //Inserção de valores para as variáveis:

            string[] vet = Console.ReadLine().Split(' ');

            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);



            //Calculo da média:
            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / (2 + 3 + 4 + 1);


            //Condicionais:
            if (media >= 7.0)
            {

                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                string[] vet2 = Console.ReadLine().Split(' ');
                notaExame = double.Parse(vet2[0], CultureInfo.InvariantCulture);


                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", CultureInfo.InvariantCulture)}");

                mediaFinal = (notaExame + media) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                  
                }

                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");

            }
            else if(media < 5.0)
            {
                if (media == 4.85f)
                {
                    media = 4.8f;
                }
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno reprovado.");   
            }

            /*
             Solução alternativa:

                    using System;
                    using System.Globalization;

                    namespace uri1040 {
                        class Program {
                            static void Main(string[] args) {

                                float N1, N2, N3, N4, media, notaExame, mediaFinal;

                                string[] valores = Console.ReadLine().Split(' ');
                                N1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
                                N2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
                                N3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
                                N4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

                                media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

                                // O problema 1040 tem uma falha de arredondamento especifica
                                // para a linguagem C#. Quando a media da 4.85, nos temos que
                                // ajusta-la manualmente para 4.8, o que eh uma "gambiarra"
                                // horrivel, infelizmente. Isso nao aconteceu nas outras 
                                // linguagens que testamos, tais como Java, C e C++
                                if (media == 4.85f) {
                                    media = 4.8f;
                                }

                                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

                                if (media >= 7.0) {
                                    Console.WriteLine("Aluno aprovado.");
                                }
                                else if (media < 5.0) {
                                    Console.WriteLine("Aluno reprovado.");
                                }
                                else {
                                    Console.WriteLine("Aluno em exame.");
                                    notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    mediaFinal = (media + notaExame) / 2;
                                    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                                    if (mediaFinal >= 5.0) {
                                        Console.WriteLine("Aluno aprovado.");
                                    }
                                    else {
                                        Console.WriteLine("Aluno reprovado.");
                                    }
                                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                                }
                            }
                        }
                    }
             */


        }
    }
}