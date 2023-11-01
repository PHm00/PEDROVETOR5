using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDROVETOREXERCICIO
{
    class model
    {

        public double[] notas;//Declarando Vetor de notas
        public int i;//Contador 
        private double soma;
        public int[] vetor;
        public int[] pares;
        public int j;//Contador
        public double[] VinteNum;
        public int[] QuinzePar;
        public double[] VinteCincoMaior;
        public double maior;//Váriavel
        public double menor;//Váriavel
        public double[] TrintaMenor;
        public int posicao;
        public double[] SegundoMaior;
        public double SegMaior;

        public model()
        {
            notas = new double[10];
            vetor = new int[5];
            pares = new int[10];
            VinteNum = new double[20];
            QuinzePar = new int[15];
            VinteCincoMaior = new double[25];
            TrintaMenor = new double[30];
            SegundoMaior = new double[50];
            SegMaior = 0;
            posicao = 0;
            menor = 0;
            maior = 0;
            i = 0;
            j = 0;
            ConsultarSoma = 0;
        }//Fim do construtor

        public double ConsultarSoma
        {
            get
            { return ConsultarSoma; }
            set { this.soma = value; }
        }

        //Guardar dez notas de dez alunos diferentes
        public double MediaNotas()
        {
            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + (" Nota: "));
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {
                        Console.WriteLine("Informe uma nota entre zero e dez!");
                    }//Fim da validação
                } while ((notas[i] < 0) || (notas[i] > 10));
                ConsultarSoma += notas[i];
            }//Fim do For
            return ConsultarSoma / i;
        }//Fim do método

        //Ler um vetor de cinco posições e mostrar em ordem inversa
        public void PreencherVetor()
        {
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + ("° Número: "));
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preenchendo               
            }//Fim do For
        }//Fim do método

        public void MostrarVetor()
        {
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(i + 1 + "ª Posição: " + vetor[i]);
            }//Fim do For
        }//Fim do mostrar

        //Exercício 2
        public void PreencherVetorDez()
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + ("° Número: "));
                pares[i] = Convert.ToInt32(Console.ReadLine());
            }//Fim do For
        }//Fim do método

        public void MostrarPares()
        {
            for (i = 0; i < 10; i++)
            {
                if (pares[i] % 2 == 0)
                {
                    Console.WriteLine(i + 1 + "° Número é Par: " + pares[i]);
                }//Fim da validação
            }//Fim do For
        }//Fim do método

        //Exercício 3
        public double MediaVinteNum()
        {
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1 + "° Número: ");
                VinteNum[i] = Convert.ToDouble(Console.ReadLine());
            }//Fim do For
            return ConsultarSoma / i;
        }//Fim do método

        //Exercício 4
        public void ParEntreQuinze()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine(i + 1 + "° Número: ");
                QuinzePar[i] = Convert.ToInt32(Console.ReadLine());

                if (QuinzePar[i] % 2 == 0)
                {
                    j = j + 1;
                }//Fim da validação
            }//Fim do for           
            Console.WriteLine(j + " Número(s) Par(es)");
        }//Fim do método

        //Exercício 5
        public void PreencherVetorVinteCinco()
        {
            for (i = 0; i < 25; i++)
            {
                Console.WriteLine(i + 1 + "° Número: ");
                VinteCincoMaior[i] = Convert.ToDouble(Console.ReadLine());
            }//Fim do For
        }//Fim do método

        public void MostrarMaiorVinteCinco()
        {
            for (i = 0; i < 25; i++)
            {
                if (maior < VinteCincoMaior[i])
                {
                    maior = VinteCincoMaior[i];
                    j = j + 1;
                }
            }//Fim do for
            Console.WriteLine("O maior número é: " + maior + " e sua posição é: " + j + 1);
        }//Fim do método

        //Execício 6
        public void PreencherVetorTrinta()
        {
            for (i = 0; i < 30; i++)
            {
                Console.WriteLine(i + 1 + "° Número: ");
                TrintaMenor[i] = Convert.ToDouble(Console.ReadLine());
            }//Fim do For
        }//Fim do método


        public void MostrarMenorTrinta()
        {
            menor = TrintaMenor[0];
            for (i = 1; i < 30; i++)
            {
                if (menor > TrintaMenor[i])
                {
                    menor = TrintaMenor[i];
                    j = j + 1;
                }
                else
                {
                    j = 1;
                }
            }//Fim do for
            Console.WriteLine("O menor número é: " + menor + " e sua posição é: " + j + "°");
        }//Fim do método

        //Exercício 7
        public void PreencherCinquenta()
        {
            for (i = 0; i < 50; i++)
            {
                Console.WriteLine(i + 1 + "° Número: ");
                SegundoMaior[i] = Convert.ToDouble(Console.ReadLine());
            }//Fim do for 
        }//Fim do método

        public void MostrarSegundoMaiorCinquenta()
        {
            for (i = 0; i < 50; i++)
            {
                if (SegundoMaior[i] > maior)
                {
                    maior = SegundoMaior[i];
                }
                else
                {
                    if ((SegundoMaior[i] > SegMaior) && (SegundoMaior[i] != maior))
                    {
                        SegMaior = SegundoMaior[i];
                    }
                }
            }//Fim do for
            Console.WriteLine("O segundo maior número é: " + SegMaior);

        }
    }
}

