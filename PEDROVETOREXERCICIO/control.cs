using PEDROVETOREXERCICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDROVETOREXERCICIO
{
    class control
    {

        model modelo;
        public int opcao;

        public control()
        {
            this.modelo = new model();//Criando uma chave            
            ConsultarOpcao = -1;
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                             "0. Sair\n" +
                             "1. Média de notas 10 alunos\n" +
                             "2. Vetor Inverso\n" +
                             "3. Números Páres\n" +
                             "4. Média de 20 valores\n" +
                             "5. Páres entre 15 números\n" +
                             "6. Maior valor dentre 25 números e sua posição\n" +
                             "7. Menor valor dentre 30 números e sua posição\n" +
                             "8. Mostrar segundo maior"
                                                                    );
            opcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do menu

        public void Operacao()
        {
            do
            {
                Menu();//Mostrar o menu em tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(this.modelo.MediaNotas());
                        break;
                    case 2:
                        this.modelo.PreencherVetor();
                        this.modelo.MostrarVetor();
                        break;
                    case 3:
                        this.modelo.PreencherVetorDez();
                        this.modelo.MostrarPares();
                        break;
                    case 4:
                        Console.WriteLine(this.modelo.MediaVinteNum());
                        break;
                    case 5:
                        this.modelo.ParEntreQuinze();
                        break;
                    case 6:
                        this.modelo.PreencherVetorVinteCinco();
                        this.modelo.MostrarMaiorVinteCinco();
                        break;
                    case 7:
                        this.modelo.PreencherVetorTrinta();
                        this.modelo.MostrarMenorTrinta();
                        break;
                    case 8:
                        this.modelo.PreencherCinquenta();
                        this.modelo.MostrarSegundoMaiorCinquenta();
                        break;
                    default:
                        Console.WriteLine("Erro! Escolha uma opção válida.");
                        break;
                }//Fim do switch
            } while (ConsultarOpcao != 0);
        }
    }
}

